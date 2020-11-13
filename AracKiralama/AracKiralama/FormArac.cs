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
using System.Data.OleDb;

namespace AracKiralama
{
    public partial class FormArac : Form
    {
        public FormArac()
        {
            InitializeComponent();
        }
        MyContext context = new MyContext();
     
        
        private void LoadCombo()
        {

            yakit_tip.DataSource = Enum.GetValues(typeof(YakitTipi));
            renk.DataSource = Enum.GetValues(typeof(Renk));
            vites.DataSource = Enum.GetValues(typeof(VitesTipi));
            marka_cmb.DataSource = context.Markalar.ToList();
            marka_cmb.DisplayMember = "Name";
            marka_cmb.ValueMember = "Id";
            arac_tip.DataSource = context.Tipler.ToList();
            arac_tip.DisplayMember = "AracTipi";
            arac_tip.ValueMember = "Id";
            
        }
      
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Araclar_Load(object sender, EventArgs e)
        {
        
            LoadCombo();
            LoadGrid();
           
        }
        private void LoadGrid()
        {
            var data = (from arac in context.Araclar
                        select new AracVM
                        {
                            Id = arac.Id,
                            Plaka = arac.Plakano,
                            Tip = arac.Tip.AracTipi,
                            Model = arac.Model.Name,
                            Marka = arac.Model.Marka.Name,
                            Renk = arac.Renk,
                            VitesTipi = arac.VitesTipi,
                            Kilometre = arac.Kilometre,
                            YakitTipi = arac.YakipTipi,
                            SigortaTarih = arac.SigortaTarihi,
                            RuhsatNo = arac.Ruhsatno,
                            KiraDurum = arac.KiraDurum
                            
                        }).ToList();
           
            dataGridView1.DataSource = data;         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Arac ekle = new Arac
                {
                    Plakano = txt_plaka.Text.ToUpper(),
                    YakipTipi = (YakitTipi)yakit_tip.SelectedValue,
                    SigortaTarihi = Convert.ToDateTime(sigorta.Value.ToString()),
                    Ruhsatno = Convert.ToInt32(txt_ruhsat.Text),
                    Renk = (Renk)renk.SelectedValue,
                    VitesTipi = (VitesTipi)vites.SelectedValue,
                    Kilometre = Convert.ToInt32(txt_km.Text),
                    ModelId = (Guid)model.SelectedValue,
                    TipId = (Guid)arac_tip.SelectedValue,

                };
                if (txt_ruhsat.Text.Length == 6)
                {

                    context.Araclar.Add(ekle);
                    context.SaveChanges();
                    MessageBox.Show(txt_plaka.Text.ToUpper() + " plaka numaralı araç başarıyla kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadGrid();
                    textclear(this);
                    txt_plaka.Focus();
                }
                else
                {
                    MessageBox.Show("Ruhsat numarası 6 basamakli olmalıdır.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(txt_plaka.Text + " plaka numaralı araç eklenirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_plaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            marka_cmb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            model.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            arac_tip.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            renk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            vites.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_km.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            yakit_tip.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            sigorta.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            txt_ruhsat.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Arac guncelleme = new Arac();
                var id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
                guncelleme = context.Araclar.FirstOrDefault(v => v.Id == id);
                guncelleme.Plakano = txt_plaka.Text;
                guncelleme.YakipTipi = (YakitTipi)yakit_tip.SelectedValue;
                guncelleme.SigortaTarihi = Convert.ToDateTime(sigorta.Value);
                guncelleme.Ruhsatno = Convert.ToInt32(txt_ruhsat.Text);
                guncelleme.Renk = (Renk)renk.SelectedValue;
                guncelleme.VitesTipi = (VitesTipi)vites.SelectedValue;
                guncelleme.Kilometre = Convert.ToInt32(txt_km.Text);
                guncelleme.ModelId = (Guid)model.SelectedValue;
                guncelleme.TipId = (Guid)arac_tip.SelectedValue;
                context.SaveChanges();
                MessageBox.Show(txt_plaka.Text + " plaka numaralı araç başarıyla güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadGrid();
                textclear(this);
                txt_plaka.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show(txt_plaka.Text + " plaka numaralı araç güncellenirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Arac sil = new Arac();
                var id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
                sil = context.Araclar.FirstOrDefault(v => v.Id == id);
                context.Araclar.Remove(sil);
                context.SaveChanges();
                MessageBox.Show(txt_plaka.Text + " plaka numaralı araç başarıyla silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textclear(this);
                LoadGrid();
            }
            catch (Exception)
            {
                MessageBox.Show(txt_plaka.Text + " plaka numaralı araç silinirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void marka_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(marka_cmb.SelectedIndex != -1) 
            {
                Marka context = marka_cmb.SelectedItem as Marka;
                model.DataSource = context.Modeller.ToList();
                model.DisplayMember = "Name";
                model.ValueMember = "Id";
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

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textclear(this);
        }
    }
}
