using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HDA_Hospital_Data_Analysis_.Model;

namespace HDA_Hospital_Data_Analysis_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Diseas diseas = new Diseas();
            MySqlDataReader reader = diseas.all();

            while (reader.Read()) {
                this.comboBox1.Items.Add(reader[1]);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Record record = new Record();
            string data = this.comboBox1.SelectedIndex+1 + "," + this.AdmittedtextBox1.Text + "," + this.recovertextBox4.Text + "," + this.DeathtextBox2.Text;
            record.insert("diseas_id, admitted, recovered, death", data);

            AdmittedtextBox1.Text = "";
            recovertextBox4.Text = "";
            DeathtextBox2.Text = "";
            //comboBox1.Items.Clear();
            AdmittedtextBox1.Focus();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewDiseas d = new NewDiseas();
            d.Show();
        }
    }
}
