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
    public partial class branslaradmin : Form
    {
        public branslaradmin()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            admin admn = new admin();
            admn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            basketboladmin basket = new basketboladmin();
            basket.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            futboladmin futboll = new futboladmin();
            futboll.Show();
            this.Hide();
        }
    }
}
