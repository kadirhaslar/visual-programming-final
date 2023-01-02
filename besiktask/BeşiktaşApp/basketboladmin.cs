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
    public partial class basketboladmin : Form
    {
        Baglan baglan = new Baglan();
        public basketboladmin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.baglantiAc();
                MySqlCommand duzenle = new MySqlCommand("INSERT basketbol SET  isim = '" + textBox1.Text + "', soyisim = '" + textBox2.Text + "', numara = '" + textBox3.Text + "'", baglan.baglan);
                duzenle.ExecuteNonQuery();
                MessageBox.Show("Kayıt eklendi!");
                baglan.baglantiKapa();


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            branslaradmin brnsadmn = new branslaradmin();
            brnsadmn.Show();
            this.Hide();
        }

        private void basketboladmin_Load(object sender, EventArgs e)
        {
            baglan.baglantiAc();
            DataSet ds = new DataSet();
            MySqlDataAdapter verileriListele = new MySqlDataAdapter("SELECT * FROM basketbol", baglan.baglan);
            verileriListele.Fill(ds, "kulüp");
            dataGridView1.DataSource = ds.Tables["kulüp"];
            baglan.baglantiKapa();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.basketsil(textBox5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.baglantiAc();
            DataSet ds = new DataSet();
            MySqlDataAdapter verileriListele = new MySqlDataAdapter("SELECT * FROM basketbol", baglan.baglan);
            verileriListele.Fill(ds, "kulüp");
            dataGridView1.DataSource = ds.Tables["kulüp"];
            baglan.baglantiKapa();
        }
    }
}
