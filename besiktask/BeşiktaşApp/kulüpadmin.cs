
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Google.Protobuf.WellKnownTypes;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using System.Xml.Linq;

namespace BeşiktaşApp
{
    public partial class kulüpadmin : Form
    {
        Baglan baglan = new Baglan();
        public kulüpadmin()
        {
            
            InitializeComponent();
        }
        
        private void kulüpadmin_Load(object sender, EventArgs e)
        {
            baglan.baglantiAc();
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlDataAdapter verileriListele = new MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM kulüp", baglan.baglan);
            verileriListele.Fill(ds, "kulüp");
            dataGridView1.DataSource = ds.Tables["kulüp"];
            baglan.baglantiKapa();

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.baglantiAc();

            MySql.Data.MySqlClient.MySqlCommand duzenle = new MySql.Data.MySqlClient.MySqlCommand("UPDATE kulüp SET Kulup_kimligi = '" + kulup_kimlik.Text + "', kurulus_tarih = '" + textBox2.Text + "', renkler = '" +textBox3.Text + "', kurulus_ismi = '" + textBox4.Text + "', ilk_baskan = '" + textBox5.Text + "', ilk_sampiyonluk = '" + textBox6.Text + "', futbolsube_kurulus = '" + textBox7.Text + "', f_ilk_sampiyonluk = '" + textBox8.Text + "'", baglan.baglan);
            duzenle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi!");
            baglan.baglantiKapa();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kulup_kimlik.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox17.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox16.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox15.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            textBox14.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            textBox22.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();


        }
    }
    }



