namespace AracKiralama
{
    partial class frmAracListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboAraçlar = new System.Windows.Forms.ComboBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ücrettxt = new System.Windows.Forms.TextBox();
            this.YakitCombo = new System.Windows.Forms.ComboBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Yiltxt = new System.Windows.Forms.TextBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.SeriCombo = new System.Windows.Forms.ComboBox();
            this.MarkaCombo = new System.Windows.Forms.ComboBox();
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(255, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 566);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboAraçlar
            // 
            this.comboAraçlar.FormattingEnabled = true;
            this.comboAraçlar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.comboAraçlar.Location = new System.Drawing.Point(931, 26);
            this.comboAraçlar.Name = "comboAraçlar";
            this.comboAraçlar.Size = new System.Drawing.Size(121, 21);
            this.comboAraçlar.TabIndex = 1;
            this.comboAraçlar.SelectedIndexChanged += new System.EventHandler(this.comboAraçlar_SelectedIndexChanged);
            // 
            // btnResim
            // 
            this.btnResim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResim.ImageIndex = 1;
            this.btnResim.ImageList = this.ımageList1;
            this.btnResim.Location = new System.Drawing.Point(28, 412);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(152, 43);
            this.btnResim.TabIndex = 47;
            this.btnResim.Text = "Resim Değiştir";
            this.btnResim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResim.UseVisualStyleBackColor = false;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİptal.ImageIndex = 2;
            this.btnİptal.ImageList = this.ımageList1;
            this.btnİptal.Location = new System.Drawing.Point(121, 643);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(77, 61);
            this.btnİptal.TabIndex = 46;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGüncelle.ImageIndex = 3;
            this.btnGüncelle.ImageList = this.ımageList1;
            this.btnGüncelle.Location = new System.Drawing.Point(12, 643);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(97, 61);
            this.btnGüncelle.TabIndex = 45;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Yakıt Tipi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Kilometre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Model (Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Plaka";
            // 
            // Ücrettxt
            // 
            this.Ücrettxt.Location = new System.Drawing.Point(62, 378);
            this.Ücrettxt.Name = "Ücrettxt";
            this.Ücrettxt.Size = new System.Drawing.Size(136, 20);
            this.Ücrettxt.TabIndex = 35;
            // 
            // YakitCombo
            // 
            this.YakitCombo.FormattingEnabled = true;
            this.YakitCombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin + LPG"});
            this.YakitCombo.Location = new System.Drawing.Point(62, 333);
            this.YakitCombo.Name = "YakitCombo";
            this.YakitCombo.Size = new System.Drawing.Size(136, 21);
            this.YakitCombo.TabIndex = 34;
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(62, 245);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(136, 20);
            this.Renktxt.TabIndex = 33;
            // 
            // Yiltxt
            // 
            this.Yiltxt.Location = new System.Drawing.Point(62, 201);
            this.Yiltxt.Name = "Yiltxt";
            this.Yiltxt.Size = new System.Drawing.Size(136, 20);
            this.Yiltxt.TabIndex = 32;
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(62, 289);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(136, 20);
            this.Kmtxt.TabIndex = 31;
            // 
            // SeriCombo
            // 
            this.SeriCombo.FormattingEnabled = true;
            this.SeriCombo.Location = new System.Drawing.Point(62, 156);
            this.SeriCombo.Name = "SeriCombo";
            this.SeriCombo.Size = new System.Drawing.Size(136, 21);
            this.SeriCombo.TabIndex = 30;
            // 
            // MarkaCombo
            // 
            this.MarkaCombo.FormattingEnabled = true;
            this.MarkaCombo.Items.AddRange(new object[] {
            "Ford",
            "Fiat",
            "Renault",
            "Peugeot",
            "Citroen",
            "Hyundai",
            "Honda",
            "Audi"});
            this.MarkaCombo.Location = new System.Drawing.Point(62, 111);
            this.MarkaCombo.Name = "MarkaCombo";
            this.MarkaCombo.Size = new System.Drawing.Size(136, 21);
            this.MarkaCombo.TabIndex = 29;
            this.MarkaCombo.SelectedIndexChanged += new System.EventHandler(this.MarkaCombo_SelectedIndexChanged);
            // 
            // Plakatxt
            // 
            this.Plakatxt.Location = new System.Drawing.Point(62, 67);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(136, 20);
            this.Plakatxt.TabIndex = 28;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 0;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(975, 643);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 61);
            this.btnSil.TabIndex = 48;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 461);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "garbage.png");
            this.ımageList1.Images.SetKeyName(1, "replace.png");
            this.ımageList1.Images.SetKeyName(2, "door-exit.png");
            this.ımageList1.Images.SetKeyName(3, "car-update.png");
            // 
            // frmAracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1096, 721);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ücrettxt);
            this.Controls.Add(this.YakitCombo);
            this.Controls.Add(this.Renktxt);
            this.Controls.Add(this.Yiltxt);
            this.Controls.Add(this.Kmtxt);
            this.Controls.Add(this.SeriCombo);
            this.Controls.Add(this.MarkaCombo);
            this.Controls.Add(this.Plakatxt);
            this.Controls.Add(this.comboAraçlar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAracListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listele";
            this.Load += new System.EventHandler(this.frmAracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboAraçlar;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ücrettxt;
        private System.Windows.Forms.ComboBox YakitCombo;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.ComboBox SeriCombo;
        private System.Windows.Forms.ComboBox MarkaCombo;
        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}