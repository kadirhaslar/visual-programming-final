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
    public partial class vakıf : Form
    {
        Baglan baglan = new Baglan();
        public vakıf()
        {
            InitializeComponent();
        }

        private void vakıf_Load(object sender, EventArgs e)
        {
            
            baglan.vakifbilgi();
         richTextBox1.Text =   baglan.nasil_bagis_yaparim;
          richTextBox2.Text=  baglan.bagis_gsm;
           richTextBox3.Text= baglan.bagis_nakit;
           richTextBox6.Text= baglan.bagis_banka;
           richTextBox5.Text= baglan.bagis_vakifbank;
            richTextBox4.Text = baglan.bagis_mail;
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kulüp klp = new kulüp();
            klp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.vakifgonder(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }
    }
}
