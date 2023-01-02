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

namespace BeşiktaşApp
{
    public partial class tarihce : Form
    {
        Baglan baglan = new Baglan();
        public tarihce()
        {
            InitializeComponent();
        }

        private void tarihce_Load(object sender, EventArgs e)
        {
            baglan.baglantiAc();

            MySqlCommand cms = new MySqlCommand("SELECT * FROM kulüp", baglan.baglan);
            MySqlDataReader dr = cms.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["tarihce"].ToString();
                
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
