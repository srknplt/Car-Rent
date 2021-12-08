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
    public partial class frmAracListele : Form
    {
        aracKiralama arac_Kiralama = new aracKiralama();
        public frmAracListele()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            Plakatxt.Text = satir.Cells["plaka"].Value.ToString();
            MarkaCombo.Text = satir.Cells["marka"].Value.ToString();
            SeriCombo.Text = satir.Cells["seri"].Value.ToString();
            Yiltxt.Text = satir.Cells["yil"].Value.ToString();
            Renktxt.Text = satir.Cells["renk"].Value.ToString();
            Kmtxt.Text = satir.Cells["km"].Value.ToString();
            YakitCombo.Text = satir.Cells["yakit"].Value.ToString();
            Ücrettxt.Text = satir.Cells["kiraucreti"].Value.ToString();
          
            pictureBox2.ImageLocation = satir.Cells["resim"].Value.ToString();
            

        }

        private void frmAracListele_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();
            try
            {
                comboAraçlar.SelectedIndex = 0;
            }
            catch
            {
                ;
            }
        }

        private void YenileAraçlarListesi()
        {
            string cumle = "select * from aracEkle";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
           
            dataGridView1.DataSource = arac_Kiralama.listele(adtr2, cumle);
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update aracEkle set marka=@marka, seri=@seri, yil=@yil, renk=@renk, km=@km, yakit=@yakit, kiraucreti=@kiraucreti,resim=@resim,tarih=@tarih where plaka=@plaka";
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@plaka", Plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", MarkaCombo.Text);
            komut2.Parameters.AddWithValue("@seri", SeriCombo.Text);
            komut2.Parameters.AddWithValue("@yil", Yiltxt.Text);
            komut2.Parameters.AddWithValue("@renk", Renktxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", YakitCombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", Ücrettxt.Text);
            komut2.Parameters.AddWithValue("@resim", pictureBox2.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            arac_Kiralama.ekle_sil_guncelle(komut2, cumle);
            SeriCombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox2.ImageLocation = "";
            YenileAraçlarListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cumle = "delete from aracEkle where plaka = '"+satır.Cells["plaka"].Value.ToString()+"'";
            OleDbCommand komut2 = new OleDbCommand();
            arac_Kiralama.ekle_sil_guncelle(komut2, cumle);
            YenileAraçlarListesi();
            pictureBox2.ImageLocation = "";
            SeriCombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = ""; 

        }

        private void MarkaCombo_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboAraçlar.SelectedIndex == 0)
                {
                    YenileAraçlarListesi();
                }
                if (comboAraçlar.SelectedIndex == 1)
                {
                    string cumle = "select * from aracEkle where durumu='BOŞ'";
                    OleDbDataAdapter adtr2 = new OleDbDataAdapter();

                    dataGridView1.DataSource = arac_Kiralama.listele(adtr2, cumle);
                }
                if (comboAraçlar.SelectedIndex == 2)
                {
                    string cumle = "select * from aracEkle where durumu='DOLU'";
                    OleDbDataAdapter adtr2 = new OleDbDataAdapter();

                    dataGridView1.DataSource = arac_Kiralama.listele(adtr2, cumle);
                }
            }
            catch 
            {
                ;
            }
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
