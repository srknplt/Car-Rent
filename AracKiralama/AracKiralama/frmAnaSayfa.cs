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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
            OleDbConnection AConnection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Serkan\\Documents\\Database2.accdb");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMusteriEkle ekle = new frmMusteriEkle();
            ekle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMusteriListele listele = new frmMusteriListele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAracKayit kayit = new frmAracKayit();
            kayit.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAracListele listele = new frmAracListele();
            listele.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSozlesme sözleşme = new frmSozlesme();
            sözleşme.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSatış satış = new frmSatış();
            satış.ShowDialog();
        }
    }
}
