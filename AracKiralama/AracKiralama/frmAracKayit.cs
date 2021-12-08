using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AracKiralama
{
    public partial class frmAracKayit : Form
    {
        aracKiralama arac_Kiralama = new aracKiralama();
        public frmAracKayit()
        {
            InitializeComponent();
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SeriCombo.Items.Clear();
                if (MarkaCombo.SelectedIndex == 0)
                {
                    SeriCombo.Items.Add("Focus");
                    SeriCombo.Items.Add("Fiesta");
                    SeriCombo.Items.Add("Mondeo");
                }
                if (MarkaCombo.SelectedIndex == 1)
                {
                    SeriCombo.Items.Add("Linea");
                    SeriCombo.Items.Add("Egea");
                    SeriCombo.Items.Add("Doblo");
                }
                if (MarkaCombo.SelectedIndex == 2)
                {
                    SeriCombo.Items.Add("Latitude");
                    SeriCombo.Items.Add("Talisman");
                    SeriCombo.Items.Add("Megane");
                    SeriCombo.Items.Add("Clio");
                }
                if (MarkaCombo.SelectedIndex == 3)
                {
                    SeriCombo.Items.Add("301");
                    SeriCombo.Items.Add("508");
                    SeriCombo.Items.Add("5008");
                }
                if (MarkaCombo.SelectedIndex == 4)
                {
                    SeriCombo.Items.Add("C-Elysee");
                    SeriCombo.Items.Add("C3");
                    SeriCombo.Items.Add("C5");
                }
                if (MarkaCombo.SelectedIndex == 5)
                {
                    SeriCombo.Items.Add("Elantra");
                    SeriCombo.Items.Add("I20");
                    SeriCombo.Items.Add("Accent");
                }
                if (MarkaCombo.SelectedIndex == 6)
                {
                    SeriCombo.Items.Add("Civic");
                    SeriCombo.Items.Add("Accord");
                    SeriCombo.Items.Add("CR-V");
                }
                if (MarkaCombo.SelectedIndex == 7)
                {
                    SeriCombo.Items.Add("A3");
                    SeriCombo.Items.Add("A4");
                    SeriCombo.Items.Add("RS7");
                }
            }
            catch
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string cumle = " insert into aracEkle(plaka, marka, seri,yil,renk,km,yakit,kiraucreti,resim,tarih,durumu)  values(@plaka, @marka, @seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@tarih,@durumu)";
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@plaka", Plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", MarkaCombo.Text);
            komut2.Parameters.AddWithValue("@seri", SeriCombo.Text);
            komut2.Parameters.AddWithValue("@yil", Yiltxt.Text);
            komut2.Parameters.AddWithValue("@renk", Renktxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", YakitCombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", Ücrettxt.Text);
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");

            arac_Kiralama.ekle_sil_guncelle(komut2, cumle);
            SeriCombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ücrettxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void YakitCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Renktxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Yiltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kmtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeriCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Plakatxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
