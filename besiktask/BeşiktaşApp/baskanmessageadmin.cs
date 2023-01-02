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
    public partial class baskanmessageadmin : Form
    {
        Baglan baglan =new Baglan();
        public baskanmessageadmin()
        {
            InitializeComponent();
        }

        private void baskanmessageadmin_Load(object sender, EventArgs e)
        {
            baglan.messagefrombaskan();
            richTextBox1.Text = baglan.message;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.baglantiAc();

            MySql.Data.MySqlClient.MySqlCommand duzenle = new MySql.Data.MySqlClient.MySqlCommand("UPDATE kulüp SET baskan_mesaj = '" + richTextBox1.Text + "'", baglan.baglan);
            duzenle.ExecuteNonQuery();
            MessageBox.Show("Mesaj Güncellendi!");
            baglan.baglantiKapa();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin admn = new admin();
            admn.Show();
            this.Hide();
        }
    }
}
