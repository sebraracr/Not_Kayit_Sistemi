namespace Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskNum = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtS3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKalanSayisi = new System.Windows.Forms.Label();
            this.lblGecenSayisi = new System.Windows.Forms.Label();
            this.lblOrt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbNotKayitDataSet = new Not_Kayit_Sistemi.DbNotKayitDataSet();
            this.tblDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDersTableAdapter = new Not_Kayit_Sistemi.DbNotKayitDataSetTableAdapters.TblDersTableAdapter();
            this.ogrIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNumaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblSnfOrt = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.mskNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 427);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Öğrenci Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(89, 158);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(143, 31);
            this.txtSoyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(89, 106);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(143, 31);
            this.txtAd.TabIndex = 2;
            // 
            // mskNum
            // 
            this.mskNum.Location = new System.Drawing.Point(89, 53);
            this.mskNum.Mask = "0000";
            this.mskNum.Name = "mskNum";
            this.mskNum.Size = new System.Drawing.Size(143, 31);
            this.mskNum.TabIndex = 1;
            this.mskNum.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtS1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtS3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtS2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(375, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 427);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Notları";
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(89, 61);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(143, 31);
            this.txtS1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtS3
            // 
            this.txtS3.Location = new System.Drawing.Point(89, 158);
            this.txtS3.Name = "txtS3";
            this.txtS3.Size = new System.Drawing.Size(143, 31);
            this.txtS3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sınav3 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sınav1 :";
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(89, 106);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(143, 31);
            this.txtS2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınav2 :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSnfOrt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblKalanSayisi);
            this.groupBox3.Controls.Add(this.lblGecenSayisi);
            this.groupBox3.Controls.Add(this.lblOrt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(723, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 427);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınav Notları";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblKalanSayisi
            // 
            this.lblKalanSayisi.AutoSize = true;
            this.lblKalanSayisi.Location = new System.Drawing.Point(148, 180);
            this.lblKalanSayisi.Name = "lblKalanSayisi";
            this.lblKalanSayisi.Size = new System.Drawing.Size(30, 23);
            this.lblKalanSayisi.TabIndex = 7;
            this.lblKalanSayisi.Text = "00";
            // 
            // lblGecenSayisi
            // 
            this.lblGecenSayisi.AutoSize = true;
            this.lblGecenSayisi.Location = new System.Drawing.Point(148, 145);
            this.lblGecenSayisi.Name = "lblGecenSayisi";
            this.lblGecenSayisi.Size = new System.Drawing.Size(30, 23);
            this.lblGecenSayisi.TabIndex = 6;
            this.lblGecenSayisi.Text = "00";
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.Location = new System.Drawing.Point(131, 82);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(30, 23);
            this.lblOrt.TabIndex = 5;
            this.lblOrt.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kalan Sayısı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Geçen Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ortalama: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(23, 470);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(992, 285);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sınav Notları:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrIdDataGridViewTextBoxColumn,
            this.ogrNumaraDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrS1DataGridViewTextBoxColumn,
            this.ogrS2DataGridViewTextBoxColumn,
            this.ogrS3DataGridViewTextBoxColumn,
            this.ortalamaDataGridViewTextBoxColumn,
            this.durumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblDersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(986, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDersBindingSource
            // 
            this.tblDersBindingSource.DataMember = "TblDers";
            this.tblDersBindingSource.DataSource = this.dbNotKayitDataSet;
            // 
            // tblDersTableAdapter
            // 
            this.tblDersTableAdapter.ClearBeforeFill = true;
            // 
            // ogrIdDataGridViewTextBoxColumn
            // 
            this.ogrIdDataGridViewTextBoxColumn.DataPropertyName = "OgrId";
            this.ogrIdDataGridViewTextBoxColumn.HeaderText = "OgrId";
            this.ogrIdDataGridViewTextBoxColumn.Name = "ogrIdDataGridViewTextBoxColumn";
            this.ogrIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrNumaraDataGridViewTextBoxColumn
            // 
            this.ogrNumaraDataGridViewTextBoxColumn.DataPropertyName = "OgrNumara";
            this.ogrNumaraDataGridViewTextBoxColumn.HeaderText = "OgrNumara";
            this.ogrNumaraDataGridViewTextBoxColumn.Name = "ogrNumaraDataGridViewTextBoxColumn";
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrS1DataGridViewTextBoxColumn
            // 
            this.ogrS1DataGridViewTextBoxColumn.DataPropertyName = "OgrS1";
            this.ogrS1DataGridViewTextBoxColumn.HeaderText = "OgrS1";
            this.ogrS1DataGridViewTextBoxColumn.Name = "ogrS1DataGridViewTextBoxColumn";
            // 
            // ogrS2DataGridViewTextBoxColumn
            // 
            this.ogrS2DataGridViewTextBoxColumn.DataPropertyName = "OgrS2";
            this.ogrS2DataGridViewTextBoxColumn.HeaderText = "OgrS2";
            this.ogrS2DataGridViewTextBoxColumn.Name = "ogrS2DataGridViewTextBoxColumn";
            // 
            // ogrS3DataGridViewTextBoxColumn
            // 
            this.ogrS3DataGridViewTextBoxColumn.DataPropertyName = "OgrS3";
            this.ogrS3DataGridViewTextBoxColumn.HeaderText = "OgrS3";
            this.ogrS3DataGridViewTextBoxColumn.Name = "ogrS3DataGridViewTextBoxColumn";
            // 
            // ortalamaDataGridViewTextBoxColumn
            // 
            this.ortalamaDataGridViewTextBoxColumn.DataPropertyName = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.HeaderText = "Ortalama";
            this.ortalamaDataGridViewTextBoxColumn.Name = "ortalamaDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewCheckBoxColumn
            // 
            this.durumDataGridViewCheckBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewCheckBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewCheckBoxColumn.Name = "durumDataGridViewCheckBoxColumn";
            // 
            // lblSnfOrt
            // 
            this.lblSnfOrt.AutoSize = true;
            this.lblSnfOrt.Location = new System.Drawing.Point(148, 114);
            this.lblSnfOrt.Name = "lblSnfOrt";
            this.lblSnfOrt.Size = new System.Drawing.Size(30, 23);
            this.lblSnfOrt.TabIndex = 9;
            this.lblSnfOrt.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sınıf Ortalaması:";
            // 
            // FrmOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1239, 767);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmOgretmenDetay";
            this.Text = "FrmOgretmenDetay";
            this.Load += new System.EventHandler(this.FrmOgretmenDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtS3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblKalanSayisi;
        private System.Windows.Forms.Label lblGecenSayisi;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource tblDersBindingSource;
        private DbNotKayitDataSetTableAdapters.TblDersTableAdapter tblDersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lblSnfOrt;
        private System.Windows.Forms.Label label11;
    }
}