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

namespace HDA_Hospital_Data_Analysis_
{
    public partial class NewDiseas : Form
    {
        public NewDiseas()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Diseas diseas = new Diseas();
            diseas.insert("name", "'"+this.diseas_name.Text+"'");
        }

        private void NewDiseas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
