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
    public partial class FormKira : Form
    {
        public FormKira()
        {
            InitializeComponent();
        }
        MyContext context = new MyContext();

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

        private void LoadCombo()
        {
            cmb_plaka.DataSource = context.Araclar.Where(v => v.KiraDurum != true).ToList();
            cmb_plaka.DisplayMember = "Plakano";
            cmb_plaka.ValueMember = "Id";
            cmb_tc.DataSource = context.Musteriler.ToList();
            cmb_tc.DisplayMember = "MusteriTC";
            cmb_tc.ValueMember = "Id";
        }
        private void LoadGrid()
        {
            var data = (from kira in context.Kiralar
                        select new KiraVM
                        {
                            Id = kira.Id,
                            PlakaNo = kira.Arac.Plakano,
                            MusteriTC = kira.Musteri.MusteriTC,
                            BaslangicTarih = kira.Tarih,
                            BitisTarih = kira.Sure,
                            KiraSaat = kira.Saat,
                            KiraUcret = kira.Ucret,
                            KiraGun = kira.KiraGun,
                            Hasar = kira.Hasar,
                            HasarDetay = kira.Hasar_durum,
                            HasarTutar = kira.Hasar_tutar,
                            ToplamTutar = kira.Toplam_tutar,
                            Marka = kira.Marka,
                            Renk = kira.Renk
                            
                        }).ToList();
            dataGridView1.DataSource = data;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (hasar.Checked)
                {


                    Kira hasarliekle = new Kira()
                    {
                        Tarih = Convert.ToDateTime(tarih.Value),
                        Saat = Convert.ToDateTime(label8.Text),
                        Sure = Convert.ToDateTime(bitis.Value),
                        Ucret = Convert.ToInt32(txt_ucret.Text),
                        Hasar = Convert.ToBoolean(hasar.Checked),
                        Hasar_durum = Convert.ToString(hasar_detay.Text),
                        KiraGun = Convert.ToInt32(label22.Text),
                        Hasar_tutar = Convert.ToInt32(hasar_fiyat.Text),
                        Toplam_tutar = Convert.ToDouble(label24.Text),
                        MusteriId = (Guid)cmb_tc.SelectedValue,
                        AracId = (Guid)cmb_plaka.SelectedValue,
                        Renk = txtRenk.Text,
                        Marka = txtMarka.Text

                    };


                    context.Kiralar.Add(hasarliekle);
                    hasarliekle.Arac.KiraDurum = true;
                    context.SaveChanges();
                    MessageBox.Show("Araç başarıyla kiralandı.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadGrid();
                    LoadCombo();

                }
                else
                {
                    Kira ekle = new Kira()
                    {
                        Tarih = Convert.ToDateTime(tarih.Value),
                        Saat = Convert.ToDateTime(label8.Text),
                        Sure = Convert.ToDateTime(bitis.Value),
                        Ucret = Convert.ToInt32(txt_ucret.Text),
                        Hasar = Convert.ToBoolean(hasar.Checked),
                        KiraGun = Convert.ToInt32(label22.Text),
                        Toplam_tutar = Convert.ToDouble(label24.Text),
                        MusteriId = (Guid)cmb_tc.SelectedValue,
                        AracId = (Guid)cmb_plaka.SelectedValue,
                        Renk = txtRenk.Text,
                        Marka = txtMarka.Text

                    };

                    context.Kiralar.Add(ekle);

                    ekle.Arac.KiraDurum = true;
                    context.SaveChanges();
                    MessageBox.Show("Arac başarıyla kiralandı.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadGrid();
                    LoadCombo();
                }

            }
            catch (Exception)
            {
                MessageBox.Show(" Araç kiralanırken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (hasar.Checked)
            {
                cmb_tc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmb_plaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                label8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                bitis.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                txt_ucret.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                label22.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                hasar.Checked = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                hasar_detay.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                hasar_fiyat.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                label24.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                
            }
            else
            {
                cmb_tc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmb_plaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                tarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
                label8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                bitis.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
                txt_ucret.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                label22.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                label24.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                hasar_detay.Text = "";
                hasar_fiyat.Text = "";
            }
            textclear(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormKira_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadCombo();
            label8.Text = DateTime.Now.ToShortTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Kira guncelleme = new Kira();
                var id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
                guncelleme = context.Kiralar.FirstOrDefault(v => v.Id == id);
                guncelleme.Tarih = tarih.Value;
                guncelleme.Saat = Convert.ToDateTime(label8.Text);
                guncelleme.Sure = bitis.Value;
                guncelleme.Ucret = Convert.ToInt32(txt_ucret.Text);
                guncelleme.Hasar = hasar.Checked;
                guncelleme.Hasar_durum = hasar_detay.Text;
                guncelleme.KiraGun = Convert.ToInt32(label22.Text);
                guncelleme.Hasar_tutar = Convert.ToInt32(hasar_fiyat.Text);
                guncelleme.Toplam_tutar = Convert.ToDouble(label24.Text);
                guncelleme.MusteriId = (Guid)cmb_tc.SelectedValue;
                context.SaveChanges();
                MessageBox.Show("Kira basariyla guncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textclear(this);
                LoadGrid();
            }
            catch (Exception)
            {
                MessageBox.Show(" Araç güncellenirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
 
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Kira sil = new Kira();
                var id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
                sil = context.Kiralar.Where(x => x.Id == id).FirstOrDefault();
                if (sil != null)
                {
                    sil.Arac.KiraDurum = false;
                    Odeme odeme = new Odeme()
                    {
                        Id = sil.Id,

                        ToplamTutar = sil.Toplam_tutar,
                        BaslangicTarih = sil.Tarih,
                        BitisTarih = sil.Sure,
                        KiraGun = sil.KiraGun,
                        PlakaNo = sil.Arac.Plakano,
                        MusteriTC = sil.Musteri.MusteriTC,
                        Marka = sil.Marka
                    };
                    context.Kiralar.Remove(sil);
                    context.Odemeler.Add(odeme);
                    context.SaveChanges();
                    MessageBox.Show(" Araç teslim alındı.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                    FormOdeme formOdeme = new FormOdeme();
                    formOdeme.Show();
                   
                }

            }
            catch (Exception)
            {
                MessageBox.Show(" Araç teslim alınırken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void hasar_CheckedChanged(object sender, EventArgs e)
        {

            if (hasar.Checked == true)
            {
                hasar_detay.Visible = true;
                label21.Visible = true;
                hasar_fiyat.Visible = true;
                label9.Visible = true;
            }
        }
        
        private void cmb_plaka_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_plaka.SelectedIndex != -1)
            {
                Arac context = cmb_plaka.SelectedItem as Arac;
                txtMarka.Text = context.Model.Marka.Name;
                txtTip.Text = context.Tip.AracTipi;
                txtRenk.Text = context.Renk.ToString();
                txtVites.Text = context.VitesTipi.ToString();
                txt_kilometre.Text = context.Kilometre.ToString();

            }

        }

        private void cmb_tc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tc.SelectedIndex != -1)
            {
                Musteri context = cmb_tc.SelectedItem as Musteri;
                txtad.Text = context.Ad;
                txtsoyad.Text = context.Soyad;
                txt_tel.Text = context.Telno;
                txt_ehliyet.Text = context.Ehliyetno.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(hasar.Checked)
            {
                int hasar = Convert.ToInt32(hasar_fiyat.Text);
                DateTime bTarih = Convert.ToDateTime(tarih.Text);
                DateTime kTarih = Convert.ToDateTime(bitis.Text);
                TimeSpan sonuc = kTarih - bTarih;
                label22.Text = sonuc.TotalDays.ToString();
                int ucret = Convert.ToInt32(txt_ucret.Text);
                int gun = Convert.ToInt32(label22.Text);
                double toplam;
                toplam= Convert.ToDouble((ucret * gun) + hasar);
                label24.Text = toplam.ToString();
            }
            else
            {
                DateTime bTarih = Convert.ToDateTime(tarih.Text);
                DateTime kTarih = Convert.ToDateTime(bitis.Text);
                TimeSpan sonuc = kTarih - bTarih;
                label22.Text = sonuc.TotalDays.ToString();
                int ucret = Convert.ToInt32(txt_ucret.Text);
                int gun = Convert.ToInt32(label22.Text);
                double toplam;
                toplam = Convert.ToDouble(ucret * gun);
                label24.Text = toplam.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
            
        }
    }

}
