using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeşiktaşApp
{
    public partial class kayıt : Form
    {
        Baglan baglan = new Baglan();
        public kayıt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.kayitt(username.Text, password.Text, adi.Text, soyadi.Text, mail.Text, gsm.Text);

            //try
            //{
              
            //    if (username.Text=="" || password.Text=="" || adi.Text=="" || soyadi.Text=="" || mail.Text=="" || gsm.Text=="")
            //    {
            //        MessageBox.Show("Boş Alanları Doldurunuz.");
            //    }
            //    else
            //    {
            //        baglan.baglantiAc();
            //        MySqlCommand cmd = new MySqlCommand();
            //        string sql = "INSERT INTO taraftar (username,password,adi,soyadi,email,gsm) VALUES (@username,@password,@adi,@soyadi,@email,@gsm)";
            //        cmd.CommandText = sql;
            //        cmd.Parameters.AddWithValue("@username", username.Text);
            //        cmd.Parameters.AddWithValue("@password", password.Text);
            //        cmd.Parameters.AddWithValue("@adi", adi.Text);
            //        cmd.Parameters.AddWithValue("@soyadi", soyadi.Text);
            //        cmd.Parameters.AddWithValue("@email", mail.Text);
            //        cmd.Parameters.AddWithValue("@gsm", gsm.Text);
            //        cmd.Connection = baglan.baglan;
            //        cmd.ExecuteNonQuery();
            //        baglan.baglantiKapa();
            //        MessageBox.Show("Yeni Kayıt Eklendi!");
            //        this.Hide();
            //    }
            //}
            //catch(MySqlException ex) {
            //    MessageBox.Show("Hata: "+ ex.ToString());
            //} 

        }
    }
}
