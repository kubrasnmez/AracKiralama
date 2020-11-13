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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama
{
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
        }
        MyContext context = new MyContext();
        private void FormMusteri_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadCombo();
        }
        private void LoadCombo()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Cinsiyet));
        }
        private void LoadGrid()
        {
            var data = (from musteri in context.Musteriler
                        select new MusteriVM
                        {
                            Id = musteri.Id,
                            TcKimlik = musteri.MusteriTC,
                            Ad = musteri.Ad,
                            Soyad = musteri.Soyad,
                            TelefonNo = musteri.Telno,
                            Email = musteri.Email,
                            Adres = musteri.Adres,
                            EhliyetNo = musteri.Ehliyetno,
                            Cinsiyet = musteri.Cinsiyet,
                            DogumTarih = musteri.DogumTarih
                            
                        }).ToList();

            dataGridView1.DataSource = data;
        }
        int yas;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri ekle = new Musteri()
                {
                    MusteriTC = txt_tc.Text,
                    Ad = txt_ad.Text.Substring(0, 1).ToUpper() +
                       txt_ad.Text.Substring(1, txt_ad.Text.Length - 1).ToLower(),
                    Soyad = txt_soyad.Text.Substring(0, 1).ToUpper() +
                       txt_soyad.Text.Substring(1, txt_soyad.Text.Length - 1).ToLower(),
                    Telno = txt_telno.Text,
                    Email = txt_mail.Text,
                    Adres = txt_adres.Text,
                    Ehliyetno = Convert.ToInt32(txt_ehliyet.Text),
                    Cinsiyet = (Cinsiyet)comboBox1.SelectedValue,
                    DogumTarih =Convert.ToDateTime(dogum_tarih.Value.ToString())

                };


                if ((txt_ehliyet.Text.Length ==6) && (txt_tc.Text.Length == 11)&&(yas>=18))
                {

                    context.Musteriler.Add(ekle);
                    context.SaveChanges();
                    MessageBox.Show(txt_tc.Text + " numaralı müşteri basariyla kaydedildi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadGrid();
                    txt_tc.Focus();
                    textclear(this);
                    txt_adres.Text = " ";
                    txt_telno.Text = " ";
                }
                else if (txt_tc.Text.Length != 11)
                {
                    MessageBox.Show("TC kimlik numarası 11 basamakli olmalıdır.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(txt_ehliyet.Text.Length != 6)
                {
                    MessageBox.Show("Ehliyet numarası 6 basanaklı olmalıdır.", "Hata Penceresi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
                }
                else
                {
                    MessageBox.Show("Yaşınız 18'den büuük olmalıdır.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(txt_tc.Text + " numaralı müşteri eklenirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
       
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri guncelleme = new Musteri();
                var id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
                guncelleme = context.Musteriler.FirstOrDefault(v => v.Id == id);
                guncelleme.MusteriTC = txt_tc.Text;
                guncelleme.Ad = txt_ad.Text.Substring(0, 1).ToUpper() +
                       txt_ad.Text.Substring(1, txt_ad.Text.Length - 1).ToLower();
                guncelleme.Soyad = txt_soyad.Text.Substring(0, 1).ToUpper() +
                       txt_soyad.Text.Substring(1, txt_soyad.Text.Length - 1).ToLower();
                guncelleme.Telno = txt_telno.Text;
                guncelleme.Email = txt_mail.Text;
                guncelleme.Adres = txt_adres.Text;
                guncelleme.Ehliyetno = Convert.ToInt32(txt_ehliyet.Text);
                guncelleme.Cinsiyet = (Cinsiyet)comboBox1.SelectedValue;
                guncelleme.DogumTarih = Convert.ToDateTime(dogum_tarih.Value);
                context.SaveChanges();
                MessageBox.Show("Musteri basariyla güncellendi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadGrid();
                textclear(this);
                txt_tc.Focus();
                txt_adres.Text = " ";
                txt_telno.Text = " ";
            }
            catch (Exception)
            {
                MessageBox.Show(txt_tc.Text + " kimlik numaralı müşteri güncellenirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri sil = new Musteri();
                var id = (Guid)dataGridView1.CurrentRow.Cells[0].Value;
                sil = context.Musteriler.FirstOrDefault(v => v.Id == id);
                context.Musteriler.Remove(sil);
                context.SaveChanges();
                MessageBox.Show(txt_tc.Text + " numaralı müşteri başarıyla silindi.", "Bilgilendirme Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadGrid();
                textclear(this);
                txt_adres.Text = " ";
                txt_telno.Text = " ";
            }
            catch (Exception)
            {
                MessageBox.Show(txt_tc.Text + " numaralı müşteri silinirken bir hata oluşmuştur. Lütfen tekrar deneyiniz.", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_ad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_soyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_telno.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_mail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_adres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_ehliyet.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            dogum_tarih.Value =Convert.ToDateTime(dataGridView1.CurrentRow.Cells[9].Value.ToString());
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            

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
            txt_adres.Text = "";
            txt_telno.Text = " ";
            textclear(this); 
        }

        private void dogum_tarih_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan fark;
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(dogum_tarih.Value);
            fark = DateTime.Now.Date.Subtract(dogumtarihi);
            yas = Convert.ToInt32(fark.TotalDays) / 365;
           
        }
    }
}
