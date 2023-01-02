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
    public partial class gizlilikanlsma : Form
    {
        Baglan baglan = new Baglan();
        public gizlilikanlsma()
        {
            InitializeComponent();
        }

        private void gizlilikanlsma_Load(object sender, EventArgs e)
        {
            baglan.baglantiAc();

            MySqlCommand cms = new MySqlCommand("SELECT * FROM kulüp", baglan.baglan);
            MySqlDataReader dr = cms.ExecuteReader();
            if (dr.Read())
            {
               richTextBox1.Text = dr["gizlilik_anlasma"].ToString();
                


            }
            baglan.baglantiKapa();
        }
    }
}
