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
    public partial class frmSozlesme : Form
    {
        public frmSozlesme()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        aracKiralama arac = new aracKiralama();
        private void frmSozlesme_Load(object sender, EventArgs e)
        {
            Boş_Araçlar();
            Yenile();

        }

        private void Boş_Araçlar()
        {
            string sorgu2 = "select *from aracEkle where durumu ='BOŞ'";
            arac.Boş_Araçlar(comboAraçlar, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "select * from sözleşme";
            OleDbDataAdapter adtr2 = new OleDbDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2, sorgu3);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from aracEkle where plaka like '" + comboAraçlar.SelectedItem + "'";
            arac.CombodanGetir(comboAraçlar,txtMarka,txtSeri,txtYil,txtRenk,sorgu2);
        }

        private void txtKiraŞekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select *from aracEkle where plaka like '" + comboAraçlar.SelectedItem + "'";
            arac.Ücret_Hesapla(comboKiraŞekli,txtKiraÜcreti,sorgu2);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateDönüş.Text) - DateTime.Parse(dateÇıkış.Text);
            int gun2 = gun.Days;
            txtGün.Text = gun2.ToString();
            txtTutar.Text = (gun2 * int.Parse(txtKiraÜcreti.Text)).ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            dateÇıkış.Text = DateTime.Now.ToShortDateString();
            dateDönüş.Text = DateTime.Now.ToShortDateString();
            comboKiraŞekli.Text = "";
            txtKiraÜcreti.Text = "";
            txtGün.Text = "";
            txtTutar.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sözleşme(tc,adsoyad,telefon,ehliyetno,e_tarih,e_yer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,ctarih,dtarih) values(@tc,@adsoyad,@telefon,@ehliyetno,@e_tarih,@e_yer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@ctarih,@dtarih)";
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@TC", txtTc.Text);
            komut2.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtE_No.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtE_Tarih.Text);
            komut2.Parameters.AddWithValue("@e_yer",txtE_Yer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtYil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", comboKiraŞekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraÜcreti.Text));
            komut2.Parameters.AddWithValue("@gun", txtGün.Text);
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", dateÇıkış.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateDönüş.Text);
            arac.ekle_sil_guncelle(komut2,sorgu2);

            string sorgu3 = "update aracEkle set durumu='DOLU' where plaka='"+comboAraçlar.Text+"'";
            OleDbCommand komut3 = new OleDbCommand();
            arac.ekle_sil_guncelle(komut3, sorgu3);
            comboAraçlar.Items.Clear();

            Boş_Araçlar();
            Yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboAraçlar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Eklendi");



        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select *from musteriEkle where TC like '" + txtTcAra.Text + "'";
            arac.TC_Ara(txtTcAra, txtTc, txtAdSoyad, txtTelefon, sorgu2);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update sözleşme set tc=@tc, adsoyad=@adsoyad, telefon=@telefon, ehliyetno=@ehliyetno, e_tarih=@e_tarih, e_yer=@e_yer, marka=@marka, seri=@seri, yil=@yil, renk=@renk, kirasekli=@kirasekli, kiraucreti=@kiraucreti, gun=@gun, tutar=@tutar, ctarih=@ctarih, dtarih=@dtarih where plaka = @plaka"; 
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Parameters.AddWithValue("@TC", txtTc.Text);
            komut2.Parameters.AddWithValue("@AdSoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtE_No.Text);
            komut2.Parameters.AddWithValue("@e_tarih", txtE_Tarih.Text);
            komut2.Parameters.AddWithValue("@e_yer", txtE_Yer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtYil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", comboKiraŞekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraÜcreti.Text));
            komut2.Parameters.AddWithValue("@gun", txtGün.Text);
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@ctarih", dateÇıkış.Text);
            komut2.Parameters.AddWithValue("@dtarih", dateDönüş.Text);
            arac.ekle_sil_guncelle(komut2, sorgu2);

            
            comboAraçlar.Items.Clear();

            Boş_Araçlar();
            Yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboAraçlar.Text = "";
            Temizle();
            MessageBox.Show("Sözleşme Güncellendi");


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtE_No.Text = satır.Cells[3].Value.ToString();
            txtE_Tarih.Text = satır.Cells[4].Value.ToString();
            txtE_Yer.Text = satır.Cells[5].Value.ToString();
            comboAraçlar.Text = satır.Cells[6].Value.ToString();
            txtMarka.Text = satır.Cells[7].Value.ToString();
            txtSeri.Text = satır.Cells[8].Value.ToString();
            txtYil.Text = satır.Cells[9].Value.ToString();
            txtRenk.Text = satır.Cells[10].Value.ToString();
            comboKiraŞekli.Text = satır.Cells[11].Value.ToString();
            txtKiraÜcreti.Text = satır.Cells[12].Value.ToString();
            txtGün.Text = satır.Cells[13].Value.ToString();
            txtTutar.Text = satır.Cells[14].Value.ToString();
            dateÇıkış.Text = satır.Cells[15].Value.ToString();
            dateDönüş.Text = satır.Cells[16].Value.ToString();
        }

        private void txtEkstra_Click(object sender, EventArgs e)
        {

        }
    }
}
