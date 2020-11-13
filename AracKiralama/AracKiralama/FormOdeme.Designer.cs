namespace AracKiralama
{
    partial class FormOdeme
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.baslangicTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracKiralamaDBDataSet = new AracKiralama.AracKiralamaDBDataSet();
            this.odemelerTableAdapter = new AracKiralama.AracKiralamaDBDataSetTableAdapters.OdemelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(180)))), ((int)(((byte)(26)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(317, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "PDF AKTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.baslangicTarihDataGridViewTextBoxColumn,
            this.bitisTarihDataGridViewTextBoxColumn,
            this.plakaNoDataGridViewTextBoxColumn,
            this.musteriTCDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odemelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(806, 321);
            this.dataGridView1.TabIndex = 10;
            // 
            // baslangicTarihDataGridViewTextBoxColumn
            // 
            this.baslangicTarihDataGridViewTextBoxColumn.DataPropertyName = "BaslangicTarih";
            this.baslangicTarihDataGridViewTextBoxColumn.HeaderText = "BaslangicTarih";
            this.baslangicTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baslangicTarihDataGridViewTextBoxColumn.Name = "baslangicTarihDataGridViewTextBoxColumn";
            this.baslangicTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // bitisTarihDataGridViewTextBoxColumn
            // 
            this.bitisTarihDataGridViewTextBoxColumn.DataPropertyName = "BitisTarih";
            this.bitisTarihDataGridViewTextBoxColumn.HeaderText = "BitisTarih";
            this.bitisTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bitisTarihDataGridViewTextBoxColumn.Name = "bitisTarihDataGridViewTextBoxColumn";
            this.bitisTarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // plakaNoDataGridViewTextBoxColumn
            // 
            this.plakaNoDataGridViewTextBoxColumn.DataPropertyName = "PlakaNo";
            this.plakaNoDataGridViewTextBoxColumn.HeaderText = "PlakaNo";
            this.plakaNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaNoDataGridViewTextBoxColumn.Name = "plakaNoDataGridViewTextBoxColumn";
            this.plakaNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriTCDataGridViewTextBoxColumn
            // 
            this.musteriTCDataGridViewTextBoxColumn.DataPropertyName = "MusteriTC";
            this.musteriTCDataGridViewTextBoxColumn.HeaderText = "MusteriTC";
            this.musteriTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTCDataGridViewTextBoxColumn.Name = "musteriTCDataGridViewTextBoxColumn";
            this.musteriTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            this.toplamTutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // odemelerBindingSource
            // 
            this.odemelerBindingSource.DataMember = "Odemeler";
            this.odemelerBindingSource.DataSource = this.aracKiralamaDBDataSet;
            // 
            // aracKiralamaDBDataSet
            // 
            this.aracKiralamaDBDataSet.DataSetName = "AracKiralamaDBDataSet";
            this.aracKiralamaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odemelerTableAdapter
            // 
            this.odemelerTableAdapter.ClearBeforeFill = true;
            // 
            // FormOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(831, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FormOdeme";
            this.Text = "FormOdeme";
            this.Load += new System.EventHandler(this.FormOdeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AracKiralamaDBDataSet aracKiralamaDBDataSet;
        private System.Windows.Forms.BindingSource odemelerBindingSource;
        private AracKiralamaDBDataSetTableAdapters.OdemelerTableAdapter odemelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
    }
}