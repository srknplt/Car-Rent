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
    public partial class frmMusteriListele : Form
    {
        aracKiralama arac_Kiralama = new aracKiralama(); 
        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }

        private void YenileListele()
        {
            string cumle = "select * from musteriEkle";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            dataGridView1.DataSource = arac_Kiralama.listele(adtr2, cumle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[2].HeaderText = "Telefon";
            dataGridView1.Columns[3].HeaderText = "Adres";
            dataGridView1.Columns[4].HeaderText = "Mail";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select * from musteriEkle where TC like '%"+textBox1.Text+"%' ";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            
            dataGridView1.DataSource = arac_Kiralama.listele(adtr2, cumle);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtTc.Text = satir.Cells[0].Value.ToString();
            txtAdSoyad.Text = satir.Cells[1].Value.ToString();
            txtTelefon.Text = satir.Cells[2].Value.ToString();
            txtAdres.Text = satir.Cells[3].Value.ToString();
            txtEmail.Text = satir.Cells[4].Value.ToString();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        { 
            string cumle = "update musteriEkle set AdSoyad=@AdSoyad,Telefon=@Telefon,adres=@adres,mail=@mail where TC=@TC ";
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@TC", txtTc.Text);
            komut2.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@mail", txtEmail.Text);
            arac_Kiralama.ekle_sil_guncelle(komut2, cumle);
            foreach (Control item in this.Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "delete from musteriEkle where TC= '"+ satir.Cells["TC"].Value.ToString() + "' ";
            OleDbCommand komut2 = new OleDbCommand();
            arac_Kiralama.ekle_sil_guncelle(komut2, cumle);
            //foreach (Control item in this.Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }
    }
}
