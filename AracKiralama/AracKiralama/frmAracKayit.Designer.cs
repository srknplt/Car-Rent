namespace AracKiralama
{
    partial class frmAracKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracKayit));
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.MarkaCombo = new System.Windows.Forms.ComboBox();
            this.SeriCombo = new System.Windows.Forms.ComboBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Yiltxt = new System.Windows.Forms.TextBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.YakitCombo = new System.Windows.Forms.ComboBox();
            this.Ücrettxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnResim = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Plakatxt
            // 
            this.Plakatxt.Location = new System.Drawing.Point(124, 51);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(136, 20);
            this.Plakatxt.TabIndex = 0;
            this.Plakatxt.TextChanged += new System.EventHandler(this.Plakatxt_TextChanged);
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
            this.MarkaCombo.Location = new System.Drawing.Point(124, 95);
            this.MarkaCombo.Name = "MarkaCombo";
            this.MarkaCombo.Size = new System.Drawing.Size(136, 21);
            this.MarkaCombo.TabIndex = 2;
            this.MarkaCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SeriCombo
            // 
            this.SeriCombo.FormattingEnabled = true;
            this.SeriCombo.Location = new System.Drawing.Point(124, 140);
            this.SeriCombo.Name = "SeriCombo";
            this.SeriCombo.Size = new System.Drawing.Size(136, 21);
            this.SeriCombo.TabIndex = 3;
            this.SeriCombo.SelectedIndexChanged += new System.EventHandler(this.SeriCombo_SelectedIndexChanged);
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(124, 273);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(136, 20);
            this.Kmtxt.TabIndex = 4;
            this.Kmtxt.TextChanged += new System.EventHandler(this.Kmtxt_TextChanged);
            // 
            // Yiltxt
            // 
            this.Yiltxt.Location = new System.Drawing.Point(124, 185);
            this.Yiltxt.Name = "Yiltxt";
            this.Yiltxt.Size = new System.Drawing.Size(136, 20);
            this.Yiltxt.TabIndex = 5;
            this.Yiltxt.TextChanged += new System.EventHandler(this.Yiltxt_TextChanged);
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(124, 229);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(136, 20);
            this.Renktxt.TabIndex = 6;
            this.Renktxt.TextChanged += new System.EventHandler(this.Renktxt_TextChanged);
            // 
            // YakitCombo
            // 
            this.YakitCombo.FormattingEnabled = true;
            this.YakitCombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin + LPG"});
            this.YakitCombo.Location = new System.Drawing.Point(124, 317);
            this.YakitCombo.Name = "YakitCombo";
            this.YakitCombo.Size = new System.Drawing.Size(136, 21);
            this.YakitCombo.TabIndex = 7;
            this.YakitCombo.SelectedIndexChanged += new System.EventHandler(this.YakitCombo_SelectedIndexChanged);
            // 
            // Ücrettxt
            // 
            this.Ücrettxt.Location = new System.Drawing.Point(124, 362);
            this.Ücrettxt.Name = "Ücrettxt";
            this.Ücrettxt.Size = new System.Drawing.Size(136, 20);
            this.Ücrettxt.TabIndex = 8;
            this.Ücrettxt.TextChanged += new System.EventHandler(this.Ücrettxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Plaka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marka";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seri";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Model (Yıl)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Renk";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kilometre";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Yakıt Tipi";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kira Ücreti";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "car-add32.png");
            this.ımageList1.Images.SetKeyName(1, "door-exit.png");
            // 
            // btnResim
            // 
            this.btnResim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResim.ImageIndex = 1;
            this.btnResim.Location = new System.Drawing.Point(544, 277);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(77, 61);
            this.btnResim.TabIndex = 27;
            this.btnResim.Text = "Resim Ekle";
            this.btnResim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResim.UseVisualStyleBackColor = false;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(183, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 61);
            this.button1.TabIndex = 26;
            this.button1.Text = "İptal";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 0;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(80, 410);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 61);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "Kayıt";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(472, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmAracKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "frmAracKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.ComboBox MarkaCombo;
        private System.Windows.Forms.ComboBox SeriCombo;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.ComboBox YakitCombo;
        private System.Windows.Forms.TextBox Ücrettxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}