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
using System.IO;
using System.Data.SqlClient;

namespace ButceTarif
{
    public partial class Form_Main : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ButceTarif.mdf;Integrated Security=True");
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_ekle.Text))
            {
                MessageBox.Show("Eklemek istediğiniz değeri girmediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var eklenecek = tb_ekle.Text;
            if (!lb_cesit.Items.Contains(eklenecek))
            {
                lb_cesit.Items.Add(eklenecek);
                tb_ekle.Text = string.Empty;
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (lb_cesit.SelectedItem != null)
            {
                lb_cesit.Items.Remove(lb_cesit.SelectedItem);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tb_ekle.Clear();
            tb_butce.Clear();
            lb_cesit.Items.Clear();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (String.IsNullOrEmpty(tb_butce.Text))
            {
                MessageBox.Show("Bütçe girmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal butce = 0;
            try
            {
                butce = Convert.ToDecimal(tb_butce.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Girilen bütçe düzgün formatta değil. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> filtreKelimeler = new List<string>();
            foreach (var item in lb_cesit.SelectedItems)
            {
                if (!filtreKelimeler.Contains(item.ToString()))
                    filtreKelimeler.Add(item.ToString());
            }
            List<TarifModel> tarifler = new List<TarifModel>();
            foreach (var item in filtreKelimeler)
            {
                SqlCommand command = new SqlCommand($"Select* from Tbl_Tarif Where(tarifad LIKE '%{item}%' or tarifturu LIKE '%{item}%') and tariffiyat <= {butce}", connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TarifModel tarif = new TarifModel()
                    {
                        TarifId = (int)reader["tarifid"],
                        TarifTuru = reader["tarifturu"].ToString(),
                        TarifResim = reader["tarifresim"] == null ? (byte[])reader["tarifresim"] : null,
                        TarifAdi = reader["tarifad"].ToString(),
                        TarifKisilik = reader["tarifkisi"].ToString(),
                        TarifZaman = reader["tarifzamani"].ToString(),
                        TarifMalzeme = reader["tarifmalzeme"].ToString(),
                        TarifIcerik = reader["tarificerik"].ToString(),
                        TarifFiyat = (decimal)reader["tariffiyat"]
                    };
                    if (!tarifler.Contains(tarif))
                    {
                        tarifler.Add(tarif);
                    }
                }
                reader.Close();
            }
            connection.Close();
            Form_Tarif ftarif = new Form_Tarif(tarifler);
            ftarif.Show();
        }

        private void btn_mlistele_Click(object sender, EventArgs e)
        {
            // tarificerik,tarifmalzeme,tarifkisi menu yemeklerinde bulunmayacak
            // Tarif Listele ve Menu Listele Buttonlarında tariffiyat TL türüne çevirilecek.
            // Bütçe girilecek ve bütçe eğer 50 tlyse menünün toplamı 50 tlyi geçmeyecek şekilde menü önerecek ve menünün sonunda 
            // toplam tutarda gözükecek.
            connection.Open();
            if (String.IsNullOrEmpty(tb_butce.Text))
            {
                MessageBox.Show("Bütçe girmediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal butce = 0;
            try
            {
                butce = Convert.ToDecimal(tb_butce.Text);
                butce = (decimal)(butce / lb_cesit.SelectedItems.Count);
            }
            catch (Exception)
            {
                MessageBox.Show("Girilen bütçe düzgün formatta değil. Lütfen sadece sayı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> filtreKelimeler = new List<string>();
            foreach (var item in lb_cesit.SelectedItems)
            {
                if (!filtreKelimeler.Contains(item.ToString()))
                    filtreKelimeler.Add(item.ToString());
            }
            List<TarifModel> tarifler = new List<TarifModel>();
            butce = decimal.Round(butce);
            foreach (var item in filtreKelimeler)
            {
                SqlCommand command = new SqlCommand($"Select * from Tbl_Tarif Where(tarifad LIKE '%{item}%' or tarifturu LIKE '%{item}%') and tariffiyat <= {butce}", connection);
                var reader = command.ExecuteReader();
                //command.Parameters.AddWithValue("@butce", butce);
                while (reader.Read())
                {
                    TarifModel tarif = new TarifModel()
                    {
                        TarifId = (int)reader["tarifid"],
                        TarifTuru = reader["tarifturu"].ToString(),
                        TarifAdi = reader["tarifad"].ToString(),
                        TarifKisilik = reader["tarifkisi"].ToString(),
                        TarifZaman = reader["tarifzamani"].ToString(),
                        TarifFiyat = (decimal)reader["tariffiyat"]
                    };
                    if (!tarifler.Contains(tarif))
                    {
                        tarifler.Add(tarif);
                    }
                }
                reader.Close();
            }
            connection.Close();
            Form_Menu fmenu = new Form_Menu(tarifler);
            fmenu.Show();
        }
    }
}
