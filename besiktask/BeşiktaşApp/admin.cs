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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kulüpadmin kulüppnl = new kulüpadmin();
            kulüppnl.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            branslar branslar= new branslar();
            branslar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            branslaradmin brnsadmn = new branslaradmin();
            brnsadmn.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baskanmessageadmin msgbaskan = new baskanmessageadmin();
            msgbaskan.Show();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            iletisimadmin iltsmadmn = new iletisimadmin();
            iltsmadmn.Show();
            this.Hide();
        }
    }
}
