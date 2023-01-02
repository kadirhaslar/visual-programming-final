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
    public partial class taraftar : Form
    {
        public taraftar()
        {
            
            InitializeComponent();
        }
        Baglan baglan = new Baglan();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void taraftar_Load(object sender, EventArgs e)
        {
            baglan.baglantiAc();
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlDataAdapter verileriListele = new MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM taraftar", baglan.baglan);
            verileriListele.Fill(ds, "taraftar");
            dataGridView1.DataSource = ds.Tables["taraftar"];
            
            baglan.baglantiKapa();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kulup_kimlik.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           
        }
    }
}
