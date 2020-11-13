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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void araçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void markaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void modelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void modelEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void aracTipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void musteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void odemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void araçEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormArac araclar = new FormArac();
            araclar.MdiParent = this;
            araclar.Show();
        }

        private void araçTipEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTip fromTip = new FormTip();
            fromTip.MdiParent = this;
            fromTip.Show();
        }

        private void markaEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMarka frmMarka = new FormMarka();
            frmMarka.MdiParent = this;
            frmMarka.Show();
        }

        private void modelEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormModel frmModel = new FormModel();
            frmModel.MdiParent = this;
            frmModel.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusteri formMusteri = new FormMusteri();
            formMusteri.MdiParent = this;
            formMusteri.Show();
        }

        private void araçKiralaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKira formKira = new FormKira();
            formKira.MdiParent = this;
            formKira.Show();
        }

        private void tesimAlınanAraçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOdeme formOdeme = new FormOdeme();
            formOdeme.MdiParent = this;
            formOdeme.Show();
        }

        private void araçRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRaporArac formRaporArac = new FormRaporArac();
            formRaporArac.MdiParent = this;
            formRaporArac.Show();
        }

        private void müşteriRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
