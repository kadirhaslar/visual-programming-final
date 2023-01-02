using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeşiktaşApp
{
    public partial class infobesiktas : Form
    {
        Baglan baglan = new Baglan();
        public infobesiktas()
        {
            
            InitializeComponent();
        }

        private void infobesiktas_Load(object sender, EventArgs e)
        {
            baglan.baglantiAc();

            MySqlCommand cms = new MySqlCommand("SELECT * FROM kulüp", baglan.baglan);
            MySqlDataReader dr = cms.ExecuteReader();
            if (dr.Read())
            {
                label11.Text = dr["Kulup_kimligi"].ToString();
                label12.Text = dr["kurulus_tarih"].ToString();
                label13.Text = dr["renkler"].ToString();
                label14.Text = dr["kurulus_ismi"].ToString();
                label15.Text = dr["ilk_baskan"].ToString();
                label16.Text = dr["ilk_sampiyonluk"].ToString();
                label17.Text = dr["futbolsube_kurulus"].ToString();
                label18.Text = dr["f_ilk_sampiyonluk"].ToString();
                label19.Text = dr["f_liggiris"].ToString();
            }
            baglan.baglantiKapa();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kulüp klp = new kulüp();
            klp.Show();
            this.Hide();
        }
    }
}
