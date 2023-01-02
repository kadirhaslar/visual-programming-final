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
    public partial class brans : Form
    {
        Baglan baglan = new Baglan();
        public brans()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            baglan.baglantiAc();
            MySqlCommand basketListele = new MySqlCommand("SELECT * FROM basketbol", baglan.baglan);
            MySqlDataReader basketoku = basketListele.ExecuteReader();
            while (basketoku.Read())
            {
                listBox1.Items.Add(basketoku["isim"].ToString() + " " + basketoku["soyisim"].ToString() + ", " + basketoku["numara"].ToString() );
            }
            basketoku.Close();
            baglan.baglantiKapa();





        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            baglan.baglantiAc();
            MySqlCommand futbolcuListele = new MySqlCommand("SELECT * FROM futbol", baglan.baglan);
            MySqlDataReader futbolcuOku = futbolcuListele.ExecuteReader();
            while (futbolcuOku.Read())
            {
                listBox1.Items.Add(futbolcuOku["isim"].ToString() + " " + futbolcuOku["soyisim"].ToString() +", "+ futbolcuOku["numara"].ToString()+" ile " + futbolcuOku["brans"]+" pozisyonunda oynuyor.");
            }
            futbolcuOku.Close();
            baglan.baglantiKapa();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            index index = new index();
            index.Show();
            this.Hide();
        }
    }
}
