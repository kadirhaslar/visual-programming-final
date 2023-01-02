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
    public partial class iletisimadmin : Form
    {
        Baglan baglan = new Baglan();
        public iletisimadmin()
        {
            InitializeComponent();
        }

        private void iletisimadmin_Load(object sender, EventArgs e)
        {
            baglan.baglantiAc();
            MySqlCommand cms = new MySqlCommand("SELECT * FROM kulüp", baglan.baglan);
            MySqlDataReader dr = cms.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["gsm"].ToString();
                textBox2.Text = dr["faks"].ToString();
                textBox3.Text = dr["kulup_mail"].ToString();
                textBox4.Text = dr["kulup_adres"].ToString();
            }
                baglan.baglantiKapa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.baglantiAc();

            MySqlCommand duzenle = new MySqlCommand("UPDATE kulüp SET gsm = '" + textBox1.Text + "', faks = '" + textBox2.Text +  "', kulup_mail = '" + textBox3.Text + "', kulup_adres = '"+ textBox4.Text+ "'", baglan.baglan);
            duzenle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi!");
            baglan.baglantiKapa();
        }
    }
}
