namespace AracKiralama
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 129);
            this.panel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.ImageIndex = 4;
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(1092, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 92);
            this.button7.TabIndex = 6;
            this.button7.Text = "Çıkış";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "car-add.png");
            this.ımageList1.Images.SetKeyName(1, "car-list.png");
            this.ımageList1.Images.SetKeyName(2, "contract.png");
            this.ımageList1.Images.SetKeyName(3, "customer.png");
            this.ımageList1.Images.SetKeyName(4, "exit.png");
            this.ımageList1.Images.SetKeyName(5, "profile-user.png");
            this.ımageList1.Images.SetKeyName(6, "promotion.png");
            this.ımageList1.Images.SetKeyName(7, "topluArac.png");
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.ImageIndex = 6;
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(912, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 92);
            this.button6.TabIndex = 5;
            this.button6.Text = "Satış İşlemleri";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.ImageIndex = 2;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(732, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 92);
            this.button5.TabIndex = 4;
            this.button5.Text = "Sözleşme";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImageIndex = 1;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(552, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 92);
            this.button4.TabIndex = 3;
            this.button4.Text = "Araç Listeleme";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(372, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 92);
            this.button3.TabIndex = 2;
            this.button3.Text = "Araç Kayıt";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(192, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 92);
            this.button2.TabIndex = 1;
            this.button2.Text = "Müşteri Listeleme";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "Müşteri Ekleme";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::AracKiralama.Properties.Resources.topluArac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 642);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

