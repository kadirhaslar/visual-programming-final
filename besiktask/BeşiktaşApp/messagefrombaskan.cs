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
    public partial class messagefrombaskan : Form
    {
        Baglan baglan= new Baglan();
        public messagefrombaskan()
        {
            InitializeComponent();
        }

        private void messagefrombaskan_Load(object sender, EventArgs e)
        {
              baglan.baglantiAc();

            MySqlCommand cms = new MySqlCommand("SELECT * FROM kulüp", baglan.baglan);
            MySqlDataReader dr = cms.ExecuteReader();
            if (dr.Read())
            {
                richTextBox1.Text = dr["baskan_mesaj"].ToString();
                label1.Text = dr["baskan_adi"].ToString();
                label2.Text = dr["baskan_soyadi"].ToString();
                label8.Text = dr["baskan_yas"].ToString();
                label7.Text = dr["baskan_dgtarih"].ToString();
                label6.Text = dr["baskan_görevbaslamatarihi"].ToString();

            }
            baglan.baglantiKapa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kulüp klp = new kulüp();
            klp.Show();
            this.Hide();
        }
    }
}
