namespace AracKiralama
{
    partial class FormRaporArac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ara = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plaka = new System.Windows.Forms.RadioButton();
            this.musteri = new System.Windows.Forms.RadioButton();
            this.txt_musteri = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_aktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(180)))), ((int)(((byte)(26)))));
            this.btn_ara.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.Location = new System.Drawing.Point(229, 234);
            this.btn_ara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(188, 45);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(197, 69);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(197, 109);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kira Başlangıç Tarihi : ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kira Bitiş Tarihi : ";
            this.label2.Visible = false;
            // 
            // plaka
            // 
            this.plaka.AutoSize = true;
            this.plaka.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plaka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plaka.Location = new System.Drawing.Point(16, 22);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(191, 21);
            this.plaka.TabIndex = 7;
            this.plaka.TabStop = true;
            this.plaka.Text = "Tarihe Göre Listeleme : ";
            this.plaka.UseVisualStyleBackColor = true;
            this.plaka.CheckedChanged += new System.EventHandler(this.plaka_CheckedChanged);
            // 
            // musteri
            // 
            this.musteri.AutoSize = true;
            this.musteri.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.musteri.Location = new System.Drawing.Point(482, 22);
            this.musteri.Name = "musteri";
            this.musteri.Size = new System.Drawing.Size(296, 21);
            this.musteri.TabIndex = 8;
            this.musteri.TabStop = true;
            this.musteri.Text = "TC Kimlik Numarasına Göre Listeleme :";
            this.musteri.UseVisualStyleBackColor = true;
            this.musteri.CheckedChanged += new System.EventHandler(this.musteri_CheckedChanged);
            // 
            // txt_musteri
            // 
            this.txt_musteri.Location = new System.Drawing.Point(608, 64);
            this.txt_musteri.Name = "txt_musteri";
            this.txt_musteri.Size = new System.Drawing.Size(170, 22);
            this.txt_musteri.TabIndex = 9;
            this.txt_musteri.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ada göre sıralama (A-Z)",
            "Toplam Tutar (Azalan)",
            "Kirada Kalan Gün Sayısı (Azalan)",
            "Müşteri Yaş (Azalan)"});
            this.comboBox1.Location = new System.Drawing.Point(94, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 27);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Önerilen Sıralama";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Toplam Tutar (Azalan)",
            "Kirada Kalan Gün Sayısı (Azalan)",
            "Kira Başlangıç Tarihi",
            "Kira Bitiş Tarihi"});
            this.comboBox2.Location = new System.Drawing.Point(521, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(238, 27);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "Önerilen Sıralama";
            this.comboBox2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 182);
            this.dataGridView1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(493, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Müşteri TC : ";
            this.label3.Visible = false;
            // 
            // btn_aktar
            // 
            this.btn_aktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(91)))), ((int)(((byte)(97)))));
            this.btn_aktar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aktar.Location = new System.Drawing.Point(454, 235);
            this.btn_aktar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(188, 45);
            this.btn_aktar.TabIndex = 6;
            this.btn_aktar.Text = "EXCEL AKTAR";
            this.btn_aktar.UseVisualStyleBackColor = false;
            this.btn_aktar.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // FormRaporArac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(833, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_musteri);
            this.Controls.Add(this.musteri);
            this.Controls.Add(this.plaka);
            this.Controls.Add(this.btn_aktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_ara);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRaporArac";
            this.Text = "FormRapor";
            this.Load += new System.EventHandler(this.FormRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton plaka;
        private System.Windows.Forms.RadioButton musteri;
        private System.Windows.Forms.TextBox txt_musteri;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_aktar;
    }
}