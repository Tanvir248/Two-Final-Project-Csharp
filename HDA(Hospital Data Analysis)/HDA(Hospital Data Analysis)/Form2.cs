using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HDA_Hospital_Data_Analysis_.Model;
using MySql.Data.MySqlClient;

namespace HDA_Hospital_Data_Analysis_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            loadGraph();


            Diseas diseas2 = new Diseas();
            MySqlDataReader reader2 = diseas2.all();

            while (reader2.Read())
            {
                this.comboBox1.Items.Add(reader2[1]);
            }

            comboBox1.SelectedIndex = 0;

        }

        private void loadGraph()
        {
            chart1.Series[0].Points.Clear();

            Diseas diseas = new Diseas();
            Record record = new Record();

            MySqlDataReader reader3;

            if (comboBox1.SelectedItem != null)
            {
                reader3 = diseas.where("name", comboBox1.SelectedItem.ToString());
            }
            else
            {
                reader3 = diseas.where("name", "COVID 19");
            }

            string diseas_id = "21";

            while (reader3.Read())
            {
                diseas_id = reader3[0].ToString();
                System.Diagnostics.Trace.WriteLine(diseas_id);
            }


            int admitted = 0;
            int death = 0;
            int recovery = 0;
            MySqlDataReader reader = record.last("diseas_id", diseas_id);

            while (reader.Read())
            {
                admitted = int.Parse(diseas.admitted(diseas_id, reader[0].ToString()).ToString());
                death = int.Parse(reader[4].ToString());
                recovery = int.Parse(reader[3].ToString());
            }

            chart1.Series[0].Points.AddXY("Admitted", (((admitted * 100) / (admitted + recovery + death))));
            chart1.Series[0].Points.AddXY("Recovery", (((recovery * 100) / (admitted + recovery + death))));
            chart1.Series[0].Points.AddXY("Death", (((death * 100) / (admitted + recovery + death))));


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //System.Diagnostics.Trace.WriteLine();
            loadGraph();
        }
    }
}
