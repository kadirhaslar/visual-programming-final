using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeşiktaşApp
{
    public partial class lig : Form
    {
        public lig()
        {
            InitializeComponent();
        }

        private void lig_Load(object sender, EventArgs e)
        {
            JObject leagues;
            using (StreamReader file = File.OpenText(@"..\..\Resources\lig.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                leagues = (JObject)JToken.ReadFrom(reader);
            }
            foreach (var club in leagues["clubs"])
            {
                listBox1.Items.Add(club["name"].ToString());
            }
            
            
        }
    }
}
