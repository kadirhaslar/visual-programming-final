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
    public partial class kulüp : Form
    {
        public kulüp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infobesiktas bjkinfo= new infobesiktas();
            bjkinfo.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            index anasayfa = new index();
            anasayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tarihce trh = new tarihce();
            trh.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            messagefrombaskan msg = new messagefrombaskan();
            msg.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vakıf vakıf = new vakıf();
            vakıf.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            iletisim iltsm = new iletisim  ();
            iltsm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gizlilikanlsma gzl = new gizlilikanlsma();
            gzl.Show();
        }
    }
}
