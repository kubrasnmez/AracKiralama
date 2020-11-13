using AracKiralama.Entity;
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

namespace AracKiralama
{
    public partial class FormModel : Form
    {
        public FormModel()
        {
            InitializeComponent();
        }
        MyContext context = new MyContext();
        
        private void FormModel_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadGrid();
        }
        private void LoadCombo()
        {
            comboBox1.DataSource = context.Markalar.ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Model yeni = new Model()
                {

                    Name = txtmodel.Text,
                    MarkaId = (Guid)comboBox1.SelectedValue
                };
                context.Modeller.Add(yeni);
                context.SaveChanges();
                MessageBox.Show(txtmodel.Text.Substring(0, 1).ToUpper() +
                   txtmodel.Text.Substring(1, txtmodel.Text.Length - 1).ToLower() + " modeli başarıyla kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadGrid();
                txtmodel.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show(txtmodel.Text + " modeli eklenirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadGrid()
        {
            var data = (from model in context.Modeller
                        select new ModelVM
                        {
                            Id = model.Id,
                            Model_isim = model.Name,
                            Marka_isim = model.Marka.Name
                        }).ToList();
            dataGridView1.DataSource = data;

            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmodel.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Model guncelleme = new Model();
                var id = (Guid)dataGridView1.SelectedRows[0].Cells[0].Value;
                guncelleme = context.Modeller.FirstOrDefault(v => v.Id == id);
                guncelleme.Name = txtmodel.Text;
                guncelleme.MarkaId = (Guid)comboBox1.SelectedValue;
                context.SaveChanges();
                MessageBox.Show(txtmodel.Text + " modeli başarıyla güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadGrid();
                txtmodel.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show(txtmodel.Text + " modeli güncellenirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Model sil = new Model();
                var id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
                sil = context.Modeller.FirstOrDefault(v => v.Id == id);
                context.Modeller.Remove(sil);
                context.SaveChanges();
                MessageBox.Show(txtmodel.Text + " modeli başarıyla silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadGrid();
                txtmodel.Text = " ";
            }
            catch(Exception)
            {
                MessageBox.Show(txtmodel.Text + " modeli silinirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
