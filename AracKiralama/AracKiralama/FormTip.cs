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
    public partial class FormTip : Form
    {
        public FormTip()
        {
            InitializeComponent();
        }
        MyContext context = new MyContext();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Tip yeni = new Tip
                {
                    AracTipi = txt_aractip.Text.Substring(0, 1).ToUpper() +
                   txt_aractip.Text.Substring(1, txt_aractip.Text.Length - 1).ToLower()
                };
                context.Tipler.Add(yeni);
                context.SaveChanges();
                MessageBox.Show(txt_aractip.Text.Substring(0, 1).ToUpper() +
                   txt_aractip.Text.Substring(1, txt_aractip.Text.Length - 1).ToLower() + " tipi başarılı bir şekilde eklenmiştir.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadGrid();
                textclear(this);
            }
            catch(Exception)
            {
                MessageBox.Show(txt_aractip.Text + "tipi eklenirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadGrid()
        {
            var data = (from tip in context.Tipler
                        select new TipVM
                        {
                            Id = tip.Id,
                            AracTipi = tip.AracTipi
                        }).ToList();
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_aractip.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void FormTip_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Tip sil = new Tip();
                var id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
                sil = context.Tipler.FirstOrDefault(v => v.Id == id);
                context.Tipler.Remove(sil);
                context.SaveChanges();
                MessageBox.Show(txt_aractip.Text.Substring(0, 1).ToUpper() +
                   txt_aractip.Text.Substring(1, txt_aractip.Text.Length - 1).ToLower() + " başarıyla silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                textclear(this);
            }
            catch (Exception)
            {
                MessageBox.Show(txt_aractip.Text + " tipi silinirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                Tip guncelle = new Tip();
                var id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
                guncelle = context.Tipler.FirstOrDefault(v => v.Id == id);
                guncelle.AracTipi = txt_aractip.Text;
                context.SaveChanges();
                MessageBox.Show(txt_aractip.Text.Substring(0, 1).ToUpper() +
                   txt_aractip.Text.Substring(1, txt_aractip.Text.Length - 1).ToLower() + " tipi basarili bir şekilde güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                textclear(this);
            }
            catch (Exception)
            {
                MessageBox.Show(txt_aractip.Text + " tipi güncellenirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textclear(Control ctl)
        {
            foreach (Control item in ctl.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item.Controls.Count > 0)
                {
                    textclear(item);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textclear(this);
        }
    }
}
