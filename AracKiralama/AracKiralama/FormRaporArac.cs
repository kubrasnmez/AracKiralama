
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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace AracKiralama
{
    public partial class FormRaporArac : Form
    {
        public FormRaporArac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        MyContext context = new MyContext();
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormRapor_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<RaporAracVM> list(List<RaporAracVM> data, int sayi)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    return data.OrderBy(o => o.MusteriAd).ToList();

                case 1:
                   return data.OrderByDescending(o => o.ToplamTutar).ToList();

                case 2:
                   return data.OrderByDescending(o => o.KiraGun).ToList();
                case 3:
                    return data.OrderBy(o => o.MusteriDogumTarihi).ToList();
                default:
                    return data;
            }
            
        }
        List<RaporMusteriVM> list(List<RaporMusteriVM>data,int sayi)
        {
            switch (comboBox2.SelectedIndex)
            {
                
                case 0:
                    return data.OrderByDescending(p => p.OdemeTutar).ToList();
                case 1:
                    return data.OrderByDescending(p => p.KiraGun).ToList();
                case 2:
                    return data.OrderBy(p => p.KiraBaslangic).ToList();
                case 3:
                    return data.OrderBy(p => p.KiraBitis).ToList();
                default:
                    return data;

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            if (plaka.Checked)
            {
                try
                {
                    var data = (from odeme in context.Odemeler
                                join arac in context.Araclar on odeme.PlakaNo equals arac.Plakano
                                join musteri in context.Musteriler on odeme.MusteriTC equals musteri.MusteriTC
                                where odeme.BaslangicTarih >= dateTimePicker1.Value && odeme.BitisTarih <= dateTimePicker2.Value
                                select new RaporAracVM
                                {
                                    PlakaNo = odeme.PlakaNo,
                                    BaslangicTarih = odeme.BaslangicTarih,
                                    BitisTarih = odeme.BitisTarih,
                                    KiraGun = odeme.KiraGun,
                                    ToplamTutar = odeme.ToplamTutar,
                                    Marka = odeme.Marka,
                                    RuhsatNo = arac.Ruhsatno,
                                    SigortaTarih = arac.SigortaTarihi,
                                    MusteriTC = odeme.MusteriTC,
                                    MusteriAd = musteri.Ad,
                                    MusteriSoyad = musteri.Soyad,
                                    MusteriTel = musteri.Telno,
                                    MusteriDogumTarihi = musteri.DogumTarih,
                                }).ToList();
                    dataGridView1.DataSource = list(data, comboBox1.SelectedIndex);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }


            }
            else if (musteri.Checked)
            {
                try
                {

                    var data = (from odeme in context.Odemeler
                                join musteri in context.Musteriler on odeme.MusteriTC equals musteri.MusteriTC
                                join arac in context.Araclar on odeme.PlakaNo equals arac.Plakano
                                where odeme.MusteriTC.Contains(txt_musteri.Text)
                                select new RaporMusteriVM
                                {
                                    PlakaNo = odeme.PlakaNo,
                                    KiraBaslangic = odeme.BaslangicTarih,
                                    KiraBitis = odeme.BitisTarih,
                                    KiraGun = odeme.KiraGun,
                                    OdemeTutar = odeme.ToplamTutar,
                                    MusteriAd = musteri.Ad,
                                    MusteriSoyad = musteri.Soyad,
                                    MusteriAdres = musteri.Adres,
                                    MusteriTelNo = musteri.Telno,
                                    MusteriEmail = musteri.Email,
                                    MusteriDogumTarih = musteri.DogumTarih,
                                }).ToList();
                    dataGridView1.DataSource = list(data, comboBox2.SelectedIndex);
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata");
                }
            }
            else
            {
                MessageBox.Show("Lütfen seçim yapın");

            }

        }



        private void button1_Click_3(object sender, EventArgs e)
        {
            if (plaka.Checked)
            {
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                    excel.Cells[StartCol, StartRow + j].Interior.Color = System.Drawing.Color.FromArgb(253, 180, 26);
                    excel.Cells[StartCol, StartRow + j].ColumnWidth = 13;
                    excel.Cells[StartCol, StartRow + j].Font.Bold = true;
                    excel.Cells[StartCol, StartRow + j].Borders.LineStyle = XlLineStyle.xlContinuous;


                }
                StartRow++;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.Select();

                    }
                }
            }
            else if (musteri.Checked)
            {
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                    excel.Cells[StartCol, StartRow + j].Interior.Color = System.Drawing.Color.FromArgb(253, 180, 26);
                    excel.Cells[StartCol, StartRow + j].ColumnWidth = 20;
                    excel.Cells[StartCol, StartRow + j].Font.Bold = true;
                    
                }
                StartRow++;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value.ToString() == null ? "" : dataGridView1[j, i].Value.ToString();
                        myRange.Select();
                    }
                }
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }

        private void plaka_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            comboBox1.Visible = true;
            txt_musteri.Visible = false;
            label3.Visible = false;
            comboBox2.Visible = false;
           
        }

        private void musteri_CheckedChanged(object sender, EventArgs e)
        {
            txt_musteri.Visible = true;
            label3.Visible = true;
            comboBox2.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            comboBox1.Visible = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }



}





 