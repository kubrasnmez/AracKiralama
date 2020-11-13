using AracKiralama.Entity;
using AracKiralama.Enums;
using AracKiralama.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace AracKiralama
{
    public partial class FormOdeme : Form
    {
        public FormOdeme()
        {
            InitializeComponent();
        }
        MyContext context = new MyContext();

        private void FormOdeme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'aracKiralamaDBDataSet.Odemeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odemelerTableAdapter.Fill(this.aracKiralamaDBDataSet.Odemeler);

            LoadGrid();
           
        }

        private void LoadGrid()
        {

            var data = (from odeme in context.Odemeler
                        select new OdemeVM
                        {
                            Id = odeme.Id,
                            PlakaNo = odeme.PlakaNo,
                            MusteriTc = odeme.MusteriTC,
                            BaslangicTarih = odeme.BaslangicTarih,
                            BitisTarih = odeme.BitisTarih,
                            ToplamGun = odeme.KiraGun,
                            ToplamTutar = odeme.ToplamTutar,
                            Marka = odeme.Marka

                        }).ToList();

            dataGridView1.DataSource = data;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }
        public void pdefeaktar(DataGridView dataGrid, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.EMBEDDED);
            PdfPTable pdfPTable = new PdfPTable(dataGrid.Columns.Count);
            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfPTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var savefiledialog = new SaveFileDialog();
            savefiledialog.FileName = filename;
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdocument = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdocument, stream);
                    pdfdocument.Open();
                    pdfdocument.Add(pdfPTable);
                    pdfdocument.Close();
                    stream.Close();

                }
            }
        }
            private void button1_Click_2(object sender, EventArgs e)
        {
            pdefeaktar(dataGridView1, "fatura");
        }
      
    }
}

