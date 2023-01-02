using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeşiktaşApp
{
    public partial class iletisim : Form
    {
        Baglan baglan = new Baglan();
        public iletisim()
        {
            InitializeComponent();
        }

        private void iletisim_Load(object sender, EventArgs e)
        {
            baglan.baglantiAc();

            MySqlCommand cms = new MySqlCommand("SELECT * FROM kulüp", baglan.baglan);
            MySqlDataReader dr = cms.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = dr["gsm"].ToString();
                label4.Text = dr["faks"].ToString();
                richTextBox1.Text = dr["kulup_adres"].ToString();
                label6.Text = dr["kulup_mail"].ToString();


            }
            baglan.baglantiKapa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kulüp klp = new kulüp();
            klp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.baglantiAc();
                MySqlCommand duzenle = new MySqlCommand("INSERT iletisim SET  isim = '" + textBox1.Text + "', gsm = '" + textBox2.Text + "', mail = '" + textBox3.Text + "', message = '" + textBox4.Text + "'", baglan.baglan);
                duzenle.ExecuteNonQuery();
                MessageBox.Show("Kayıt Güncellendi!");
                baglan.baglantiKapa();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
            }
        }
    }
}
