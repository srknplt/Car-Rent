﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace AracKiralama
{
    class aracKiralama
    {
        OleDbConnection AConnection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Serkan\\Documents\\Database2.accdb");
        DataTable tablo;
        

        public void ekle_sil_guncelle(OleDbCommand komut, string sorgu)
        {
            AConnection.Open();
            komut.Connection = AConnection;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            AConnection.Close();
            
        }

        public DataTable listele(OleDbDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new OleDbDataAdapter(sorgu, AConnection);
            adtr.Fill(tablo);
            AConnection.Close();
            return tablo;
        }
        public void Boş_Araçlar(ComboBox combo, string sorgu)
        {
            AConnection.Open();
            OleDbCommand komut = new OleDbCommand(sorgu,AConnection);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());

            }
            AConnection.Close();
        }

        public void TC_Ara(TextBox tcara, TextBox tc, TextBox adsoyad, TextBox telefon, string sorgu)
        {
            AConnection.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, AConnection);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text = read["adsoyad"].ToString();
                telefon.Text = read["telefon"].ToString();

            }
            AConnection.Close();
        }

        public void CombodanGetir(ComboBox araclar, TextBox marka, TextBox seri, TextBox yil, TextBox renk, string sorgu)
        {
            AConnection.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, AConnection);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yil.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();

            }
            AConnection.Close();
        }

        public void Ücret_Hesapla(ComboBox combokiraşekli, TextBox ucret, string sorgu)
        {
            AConnection.Open();
            OleDbCommand komut = new OleDbCommand(sorgu, AConnection);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (combokiraşekli.SelectedIndex == 0) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 1).ToString();
                if (combokiraşekli.SelectedIndex == 1) ucret.Text = (int.Parse(read["kiraucreti"].ToString())* 0.80).ToString();
                if (combokiraşekli.SelectedIndex == 2) ucret.Text = (int.Parse(read["kiraucreti"].ToString()) * 0.70).ToString();



            }
            AConnection.Close();
        }
    }
}
