namespace AracKiralama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.araçEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.araçTipEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modelEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracTipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçKiralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesimAlınanAraçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçEkleToolStripMenuItem,
            this.markaEkleToolStripMenuItem,
            this.modelEkleToolStripMenuItem,
            this.aracTipToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // araçEkleToolStripMenuItem
            // 
            this.araçEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçEkleToolStripMenuItem1,
            this.araçTipEkleToolStripMenuItem});
            this.araçEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("araçEkleToolStripMenuItem.Image")));
            this.araçEkleToolStripMenuItem.Name = "araçEkleToolStripMenuItem";
            this.araçEkleToolStripMenuItem.Size = new System.Drawing.Size(133, 46);
            this.araçEkleToolStripMenuItem.Text = "Araç İşlemleri";
            this.araçEkleToolStripMenuItem.Click += new System.EventHandler(this.araçEkleToolStripMenuItem_Click);
            // 
            // araçEkleToolStripMenuItem1
            // 
            this.araçEkleToolStripMenuItem1.Name = "araçEkleToolStripMenuItem1";
            this.araçEkleToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.araçEkleToolStripMenuItem1.Text = "Araç Ekle";
            this.araçEkleToolStripMenuItem1.Click += new System.EventHandler(this.araçEkleToolStripMenuItem1_Click);
            // 
            // araçTipEkleToolStripMenuItem
            // 
            this.araçTipEkleToolStripMenuItem.Name = "araçTipEkleToolStripMenuItem";
            this.araçTipEkleToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.araçTipEkleToolStripMenuItem.Text = "Araç Tip Ekle";
            this.araçTipEkleToolStripMenuItem.Click += new System.EventHandler(this.araçTipEkleToolStripMenuItem_Click);
            // 
            // markaEkleToolStripMenuItem
            // 
            this.markaEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaEkleToolStripMenuItem1,
            this.modelEkleToolStripMenuItem1});
            this.markaEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("markaEkleToolStripMenuItem.Image")));
            this.markaEkleToolStripMenuItem.Name = "markaEkleToolStripMenuItem";
            this.markaEkleToolStripMenuItem.Size = new System.Drawing.Size(137, 46);
            this.markaEkleToolStripMenuItem.Text = "Marka/ Model";
            this.markaEkleToolStripMenuItem.Click += new System.EventHandler(this.markaEkleToolStripMenuItem_Click);
            // 
            // markaEkleToolStripMenuItem1
            // 
            this.markaEkleToolStripMenuItem1.Name = "markaEkleToolStripMenuItem1";
            this.markaEkleToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.markaEkleToolStripMenuItem1.Text = "Marka Ekle";
            this.markaEkleToolStripMenuItem1.Click += new System.EventHandler(this.markaEkleToolStripMenuItem1_Click);
            // 
            // modelEkleToolStripMenuItem1
            // 
            this.modelEkleToolStripMenuItem1.Name = "modelEkleToolStripMenuItem1";
            this.modelEkleToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.modelEkleToolStripMenuItem1.Text = "Model Ekle";
            this.modelEkleToolStripMenuItem1.Click += new System.EventHandler(this.modelEkleToolStripMenuItem1_Click);
            // 
            // modelEkleToolStripMenuItem
            // 
            this.modelEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem});
            this.modelEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modelEkleToolStripMenuItem.Image")));
            this.modelEkleToolStripMenuItem.Name = "modelEkleToolStripMenuItem";
            this.modelEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 46);
            this.modelEkleToolStripMenuItem.Text = "Müşteri İşlemleri";
            this.modelEkleToolStripMenuItem.Click += new System.EventHandler(this.modelEkleToolStripMenuItem_Click_1);
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // aracTipToolStripMenuItem
            // 
            this.aracTipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçKiralaToolStripMenuItem,
            this.tesimAlınanAraçlarToolStripMenuItem});
            this.aracTipToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aracTipToolStripMenuItem.Image")));
            this.aracTipToolStripMenuItem.Name = "aracTipToolStripMenuItem";
            this.aracTipToolStripMenuItem.Size = new System.Drawing.Size(129, 46);
            this.aracTipToolStripMenuItem.Text = "Kira İşlemleri";
            this.aracTipToolStripMenuItem.Click += new System.EventHandler(this.aracTipToolStripMenuItem_Click);
            // 
            // araçKiralaToolStripMenuItem
            // 
            this.araçKiralaToolStripMenuItem.Name = "araçKiralaToolStripMenuItem";
            this.araçKiralaToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.araçKiralaToolStripMenuItem.Text = "Araç Kirala";
            this.araçKiralaToolStripMenuItem.Click += new System.EventHandler(this.araçKiralaToolStripMenuItem_Click);
            // 
            // tesimAlınanAraçlarToolStripMenuItem
            // 
            this.tesimAlınanAraçlarToolStripMenuItem.Name = "tesimAlınanAraçlarToolStripMenuItem";
            this.tesimAlınanAraçlarToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.tesimAlınanAraçlarToolStripMenuItem.Text = "Tesim Alınan Araçlar";
            this.tesimAlınanAraçlarToolStripMenuItem.Click += new System.EventHandler(this.tesimAlınanAraçlarToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçRaporToolStripMenuItem});
            this.raporToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("raporToolStripMenuItem.Image")));
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(83, 46);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // araçRaporToolStripMenuItem
            // 
            this.araçRaporToolStripMenuItem.Name = "araçRaporToolStripMenuItem";
            this.araçRaporToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.araçRaporToolStripMenuItem.Text = "Araç Rapor";
            this.araçRaporToolStripMenuItem.Click += new System.EventHandler(this.araçRaporToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arac Kiralama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem araçEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracTipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem araçTipEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modelEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçKiralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesimAlınanAraçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçRaporToolStripMenuItem;
    }
}

