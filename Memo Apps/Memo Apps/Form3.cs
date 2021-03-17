using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
namespace Memo_Apps
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }
        public Form3( string value,string foodtext, string quantity, string sendl)
        {
            InitializeComponent();
            this.value = value;
            pricelabel6.Text = value;
            FoodtextBox.Text = foodtext;
            Quantitylabel8.Text = quantity;
            sendlabel11.Text = sendl;
        }
        
        public string value { get; set; }

        private void pricelabel6_Click(object sender, EventArgs e)
        {

        }

        private void Food_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Quantitylabel8_Click(object sender, EventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void sendButtonbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost; username=root;password=; database=client";
                string Query = "insert into client.client(Name,Phone,Food,Price) values('" + this.NametextBox1.Text + "','" + this.mobileNotextBox2.Text + "','" + this.sendlabel11.Text + "','" + this.pricelabel6.Text + "');";
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
            MailMessage message = new MailMessage();
            try
            {
                message.To.Add(new MailAddress("teamsparta48@gmail.com"));
                message.From = new MailAddress("tanvirdox@gmail.com");
                message.Subject = "See Food Item and Verification Money!";
               
                message.Body = ("This person is", NametextBox1.Text, ".\n", "Mobile No is:", mobileNotextBox2.Text, ".\n", "His messege : ", meessegetextBox3.Text, "\n", "All The Item : ", sendlabel11.Text, ".\n", "Total Price : ", pricelabel6.Text, ".\n", "His Seat No : ", seattextBox1.Text, "\n").ToString();
            
            
            message.BodyEncoding = System.Text.Encoding.UTF8;
                message.SubjectEncoding = System.Text.Encoding.UTF8;
               
                SmtpClient client = new SmtpClient();
                client.Port = 587; 
                client.Host = "smtp.gmail.com";
                System.Net.NetworkCredential nc = new System.Net.NetworkCredential("tanvirdox@gmail.com","@@T*****.");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = nc;
                client.Send(message);
                MessageBox.Show("Thank You. Please Wait Sometimes for Prepare Your Food");


            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Request not submitted. " + ex.Message);
            }
        }

        private void meessegetextBox3_TextChanged(object sender, EventArgs e)
        {
            optionallabel12.Visible = false;
        }

        private void verificationgroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
