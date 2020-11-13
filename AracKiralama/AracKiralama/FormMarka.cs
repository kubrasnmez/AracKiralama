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
    public partial class FormMarka : Form
    {
        public FormMarka()
        {
            InitializeComponent();
        }
        MyContext context = new MyContext();
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Marka yeni = new Marka
                {
                    Name = markatxt.Text.Substring(0, 1).ToUpper() +
                   markatxt.Text.Substring(1, markatxt.Text.Length - 1).ToLower()
                };
                context.Markalar.Add(yeni);
                context.SaveChanges();
                MessageBox.Show(markatxt.Text + " marka başarılı bir şekilde eklenmiştir.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadGrid();
                markatxt.Text = "";
            }
            catch(Exception )
            {
                
                MessageBox.Show( markatxt.Text + " eklenememiştir. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadGrid()
        {

            var data = (from marka in context.Markalar
                        select new MarkaVM
                        {
                            Id = marka.Id,
                            Marka_isim = marka.Name
                        }).ToList();

            dataGridView1.DataSource = data;
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            markatxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void FormMarka_Load(object sender, EventArgs e)
        {
            
            LoadGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Marka guncelleme = new Marka();
                var id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
                guncelleme = context.Markalar.FirstOrDefault(v => v.Id == id);
                guncelleme.Name = markatxt.Text;
                context.SaveChanges();
                MessageBox.Show(markatxt.Text + "markası başarıyla güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadGrid();
                markatxt.Text = " ";
                
            }
            catch(Exception)
            {
                MessageBox.Show(markatxt.Text + "markası güncellenirken bir hata oluştu. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Marka sil = new Marka();
                var id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
                sil = context.Markalar.FirstOrDefault(v => v.Id == id);
                context.Markalar.Remove(sil);
                MessageBox.Show(markatxt.Text + " markası başarıyla silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                context.SaveChanges();
                LoadGrid();
                markatxt.Text = " ";
            }
            catch(Exception)
            {
                MessageBox.Show(markatxt.Text + "markası silinirken bir hata oluştu. Lütfen tekrar deneyiniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }

