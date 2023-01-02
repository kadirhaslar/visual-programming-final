using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BeşiktaşApp
{
    public partial class Giris : Form
    {

        Baglan baglan = new Baglan();
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            try
            {

                baglan.baglantiAc();
                MySqlCommand giris=new MySqlCommand("SELECT * FROM taraftar WHERE username=@username AND password=@password", baglan.baglan);
                giris.Parameters.AddWithValue("@username",username.Text);
                giris.Parameters.AddWithValue("@password",password.Text);
                MySqlDataReader oku=giris.ExecuteReader();
                if (oku.Read())
                {
                
                index anasayfa = new index();
                anasayfa.Show();
                this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız");
                }
               

            }
        catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:"+ ex.ToString());
            }
            baglan.baglantiKapa();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıt kyt = new kayıt();
            kyt.Show();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                baglan.baglantiAc();
                MySqlCommand grs = new MySqlCommand("SELECT * FROM admin WHERE username=@username AND password=@password", baglan.baglan);
                grs.Parameters.AddWithValue("@username", adminusername.Text);
                grs.Parameters.AddWithValue("@password", adminpassword.Text);
                MySqlDataReader read = grs.ExecuteReader();
                if (read.Read())
                {
                    admin pnl = new admin();
                    pnl.Show();
                    this.Hide();
                    baglan.baglantiKapa();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu:" + ex.ToString());
            }
            baglan.baglantiKapa();
        }
    }
}
