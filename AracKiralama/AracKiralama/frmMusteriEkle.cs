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
    public partial class frmMusteriEkle : Form
    {
        aracKiralama arac_Kiralama = new aracKiralama();
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into musteriEkle (TC,AdSoyad,Telefon,adres,mail) values(@TC,@AdSoyad,@Telefon,@adres,@mail)";
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@TC", txtTc.Text);
            komut2.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@mail", txtEmail.Text);
            arac_Kiralama.ekle_sil_guncelle(komut2, cumle);
            foreach (Control item in this.Controls) if (item is TextBox) item.Text = "";

        }

    }
}
