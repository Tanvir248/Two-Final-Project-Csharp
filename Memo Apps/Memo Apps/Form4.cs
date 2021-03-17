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
namespace Memo_Apps
{
    public partial class Form4 : Form
    {
        double Input1, Input2, Result;
        //string MyConnection2 = "datasource=localhost; username=root;password=; database=client";
        public Form4()
        {
            InitializeComponent();
            LoadData();
        }
       void LoadData()
        {
           // string MyConnection2 = "datasource=localhost; username=root;password=; database=client";
           // string Query = "insert into client.client(Name,Phone,Food,Price) values('" + this.NametextBox1.Text + "','" + this.mobileNotextBox2.Text + "','" + this.sendlabel11.Text + "','" + this.pricelabel6.Text + "');";

            MySqlConnection con = new MySqlConnection(AppSetting.ConnectionString());
            con.Open();
           MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM client";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSetting.ConnectionString());
            string searchgrid = "select * from client where Phone like '" + searchtextBox1.Text + "%'";
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM client";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView1.DataSource = dtrecord;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalcosttextBox2.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cost1textBox2.Text == "" || cost2textBox3.Text == "")
            {
                MessageBox.Show("Error! Fill The Blank TextBoxs");
            }
            else
            {
                if (cost1textBox2.Text != "" || cost2textBox3.Text != "")
                {
                    Input1 = Convert.ToDouble(cost1textBox2.Text);
                    Input2 = Convert.ToDouble(cost2textBox3.Text);

                    Result = Input1 + Input2;
                    cost1textBox2.Text = Result.ToString();
                    //MessageBox.Show(Result.ToString());
                    cost2textBox3.Clear();
                    cost2textBox3.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter Number!");
                }
            }
        }

        private void Chartbutton1_Click(object sender, EventArgs e)
        {

            int result1, result2, loss, profit, ans, priceloss = 0, priceprofit = 0, percent = 0;
            
            if (totalcosttextBox2.Text == "" && totalcosttextBox2.Text == "")
            {
                MessageBox.Show("Error! Fill Up Above  two text Boxs!");
            }
            else
            {
                piechart1.Visible = true;
                int input1 = Convert.ToInt32(totalcosttextBox2.Text);
                int input2 = Convert.ToInt32(totalsoldtextBox3.Text);
                result1 = (input1 * 100) / (input1 + input2);
                result2 = (input2 * 100) / (input1 + input2);
                // MessageBox.Show(result1.ToString());
                // MessageBox.Show(result2.ToString());
                if (input1 - input2 <= 0)
                {
                    priceloss += 0;
                }
                else if (input1 - input2 > 0)
                {
                    priceloss += (input1 - input2);
                }
                if (input2 - input1 <= 0)
                {
                    priceprofit += 0;
                }
                else if (input2 - input1 > 0)
                {
                    priceprofit += (input2 - input1);
                }
                if (result1 > result2)
                {
                    percent += (result1 - result2);
                }
                else if (result1 < result2)
                {
                    percent += (result2 - result1);
                }
                try
                {
                    string MyConnection2 = "datasource=localhost; username=root;password=; database=client";
                    string Query = "insert into `calculate_data`(cost,sell,loss,profit,Profit_loss) values('" + this.totalcosttextBox2.Text + "','" + this.totalsoldtextBox3.Text + "','" + priceloss + "','" + priceprofit + "','" + percent + "');";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    // MessageBox.Show("Save Data");
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (input1 > input2)
                {
                    loss = input1 - input2;
                    ans = result1 - result2;
                    piechart1.Titles.Add("Total Loss : ");
                    piechart1.Titles.Add(loss.ToString());
                    piechart1.Titles.Add(ans.ToString());

                }
                else if (input2 > input1)
                {
                    profit = input2 - input1;
                    ans = result2 - result1;
                    piechart1.Titles.Add("Total Profit : ");
                    piechart1.Titles.Add(profit.ToString());
                    piechart1.Titles.Add(ans.ToString());

                }
                piechart1.Series["Series1"].IsValueShownAsLabel = true;
                piechart1.Series["Series1"].Points.AddXY("Loss %", result1.ToString());
                piechart1.Series["Series1"].Points.AddXY("Profit %", result2.ToString());
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            refgbutton2.Visible = true;
            trlabel1.Visible = false;
            cdlabel1.Visible = true;
            dataGridView2.Visible = true;
            MySqlConnection con = new MySqlConnection(AppSetting.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT *FROM `calculate_data`";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtrecord = new DataTable();
            dtrecord.Load(sdr);
            dataGridView2.DataSource = dtrecord;
            totalcalculationbutton1.Visible = false;
        }

        private void refgbutton2_Click(object sender, EventArgs e)
        {
            cdlabel1.Visible = false;
            trlabel1.Visible = true;
            dataGridView2.Visible = false;
            searchtextBox1.Clear();
            totalcalculationbutton1.Visible = true;
            refgbutton2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if(cost2textBox3.Text != "")
            {
                MessageBox.Show("Please Clieck Add button!");
            }
            if (totalcosttextBox2.Text == "")
            {

                totalcosttextBox2.Text = cost1textBox2.Text;
            }
            else
                totalsoldtextBox3.Text = cost1textBox2.Text;

            cost2textBox3.Focus();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cost1textBox2.Clear();
            cost2textBox3.Clear();
            totalcosttextBox2.Clear();
            totalsoldtextBox3.Clear();
            piechart1.ResetText();
            piechart1.Visible = false;
            cost1textBox2.Focus();
        }
    }
}
