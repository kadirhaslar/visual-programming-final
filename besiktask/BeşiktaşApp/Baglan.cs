  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BeşiktaşApp
{
    internal class Baglan
    {
        public MySqlConnection baglan;
        public Baglan()
        {

            baglan = new MySqlConnection("server=localhost;database=besiktas; uid=root; password=''");


        }
        public void baglantiAc()
        {
            baglan.Open();
            //MessageBox.Show("okitos");
        }
        public void baglantiKapa() { baglan.Close(); }
        public void kayitt(string username, string password, string adi, string soyadi, string email, string gsm)
        {
            try
            {


                baglan.Open();
                MySqlCommand cmd = new MySqlCommand();
                string sql = "INSERT INTO taraftar (username,password,adi,soyadi,email,gsm) VALUES (@username,@password,@adi,@soyadi,@email,@gsm)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@adi", adi);
                cmd.Parameters.AddWithValue("@soyadi", soyadi);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@gsm", gsm);
                cmd.Connection = baglan;
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Yeni Kayıt Eklendi!");


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
            }
        }
        public string nasil_bagis_yaparim, bagis_gsm, bagis_nakit, bagis_banka, bagis_vakifbank, bagis_mail;
        public void vakifbilgi()
        {
            baglan.Open();
            MySqlCommand cms = new MySqlCommand("SELECT * FROM vakıf", baglan);
            MySqlDataReader dr = cms.ExecuteReader();
            dr.Read();
            nasil_bagis_yaparim = dr["nasil_bagis_yaparim"].ToString();
            bagis_gsm = dr["bagis_gsm"].ToString();
            bagis_nakit = dr["bagis_nakit"].ToString();
            bagis_banka = dr["bagis_banka"].ToString();
            bagis_vakifbank = dr["bagis_vakifbank"].ToString();
            bagis_mail = dr["bagis_mail"].ToString();
            baglan.Close();
        }

        public void vakifgonder(string isim, string gsm, string mail, string message)
        {
            try
            {


                baglan.Open();
                MySqlCommand cmd = new MySqlCommand();
                string sql = "INSERT INTO vakif_mesage (isim,gsm,mail,mesage) VALUES (@isim,@gsm,@mail,@mesage)";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@isim", isim);
                cmd.Parameters.AddWithValue("@gsm", gsm);
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@mesage", message);



                cmd.Connection = baglan;
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("mesaj gönderildi");


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
            }
        }
        public string message;
        public void messagefrombaskan()
        {
            baglan.Open();
            MySqlCommand cms = new MySqlCommand("SELECT * FROM kulüp", baglan);
            MySqlDataReader dr = cms.ExecuteReader();
            while (dr.Read())
            {
                message = dr["baskan_mesaj"].ToString();
            }


            baglan.Close();
        }
        public void futbolsil(string id)
        {
            baglan.Open();
            MySqlCommand sil = new MySqlCommand("delete from futbol where id='" + id + "'", baglan);
            sil.ExecuteNonQuery();
            MessageBox.Show("silindi.", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            baglan.Close();
        }

        public void futbolcek(string isim, string soyadi,string numara,string brans)
        {
            for (int i = 0; i < 200; i++)
            {

                baglan.Open();

                MySqlCommand komut = new MySqlCommand("select * from iletisim where id='" + i.ToString() + "'", baglan);
                MySqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                  //  isim = oku.FieldCount.ToString();
                    isim = oku["baslik"].ToString();
                    soyadi = oku["mesaj"].ToString();
                    numara =oku["mesaj"].ToString();
                    brans=oku["mesaj"].ToString();



                }
                baglan.Close();
            }
            
        }
        public void basketsil(string id)
        {
            baglan.Open();
            MySqlCommand sil = new MySqlCommand("delete from basketbol where id='" + id + "'", baglan);
            sil.ExecuteNonQuery();
            MessageBox.Show("silindi.", "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            baglan.Close();

        }
    }
}
    


