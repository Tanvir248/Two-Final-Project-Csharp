using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo_Apps
{
    public partial class Form1 : Form
    {
        int price = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttoFastFood1_Click(object sender, EventArgs e)
        {
            fastFoodlabel4.Visible = true;
            sidepanel22.Height = buttoFastFood1.Height;
            sidepanel22.Top = buttoFastFood1.Top;
            endlinkLabel1.BringToFront();
            panel21.BringToFront();
            panel20.BringToFront();
            panel17.BringToFront();
            panel28.BringToFront(); 
            fastFoodlabel4.BringToFront();
        }

        private void buttonTeamItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBiriyani2_Click(object sender, EventArgs e)
        {
            biriyanilabel5.Visible = true;
            sidepanel22.Height = buttonBiriyani2.Height;
            sidepanel22.Top = buttonBiriyani2.Top;
            endlinkLabel1.BringToFront();
            panel16.BringToFront();
            panel33.BringToFront();
            panel24.BringToFront();
            biriyanilabel5.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mishtannolabel6.Visible = true;
            sidepanel22.Height = buttonMishtanno3.Height;
            sidepanel22.Top = buttonMishtanno3.Top;


            endlinkLabel1.BringToFront();
            panel12.BringToFront();
            panel11.BringToFront();
            panel10.BringToFront();
            panel14.BringToFront();
            mishtannolabel6.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cakelabel8.Visible = true;
            sidepanel22.Height = buttonCakeItem4.Height;
            sidepanel22.Top = buttonCakeItem4.Top;
            endlinkLabel1.BringToFront();
            panel14.BringToFront();
            panel11.BringToFront();
            cakelabel8.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drinkslabel9.Visible = true;
            sidepanel22.Height = buttonDrinks5.Height;
            sidepanel22.Top = buttonDrinks5.Top;
            endlinkLabel1.BringToFront();
            panel12.BringToFront();
            panel31.BringToFront();
            drinkslabel9.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            meatlabel2.Visible = true;
            sidepanel22.Height = buttonMeate2.Height;
            sidepanel22.Top = buttonMeate2.Top;
            endlinkLabel1.BringToFront();
            panel19.BringToFront();
            panel20.BringToFront();
            panel21.BringToFront();
            meatlabel2.BringToFront();
        }

        private void buttonHomr1_Click(object sender, EventArgs e)
        {
            aboutUsbutton2.Visible = true;
            //databasebutton2.Visible = true;
            secrettextBox1.Visible = true;
            secretbutton2.Visible = true;
        }

       

        

       

        
        private void checkBoxChocoicm120_6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChocone120_6.Checked)
            {
                price += 120;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Chocolate Cone = 120/=");
            }
        }

        private void checkBoxCocaCola42_29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCocaCola42_29.Checked)
            {
                price += 42;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Cocacola = 42/=");
            }
        }

        

        private void checkBoxMiniDoi150_29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMiniDoi150_29.Checked)
            {
                price += 150;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Mini Doi = 150/=");
            }
        }

        private void checkBoxFriedChicken90_11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFriedChicken90_11.Checked)
            {
                price += 90;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Fried Chicken = 90/=");
            }
        }
        private void checkBoxFriedFullc600_5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFriedFullc600_5.Checked)
            {
                price += 600;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Fried Full Chicken = 600/=");
            }
        }
        private void checkBoxFriedMuc900_14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFriedMuc900_14.Checked)
            {
                price += 900;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Fried Mutton Chest = 900/=");
            }
        }
        private void checkBoxGrillPorata110_10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGrillPorata110_10.Checked)
            {
                price += 110;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Grill Porata = 110/=");
            }
        }
        private void checkBoxHotdog500_13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHotdog500_13.Checked)
            {
                price += 500;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Hot Dog = 500/=");
            }
        }
        private void checkBoxHydraBiri900_12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHydraBiri900_12.Checked)
            {
                price += 900;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Hydrabadi Biriyani = 900/=");
            }
        }

        private void checkBoxKalavuna500_15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKalavuna500_15.Checked)
            {
                price += 500;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Kalavuna = 500/=");
            }
        }

        private void checkBoxLavender400_16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLavender400_16.Checked)
            {
                price += 400;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Lavender = 400/=");
            }
        }

       

        

        private void checkBoxSpmuBri280_22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpmuBri280_22.Checked)
            {
                price += 280;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Special Mutton Biriyani = 280/=");
            }
        }

        private void checkBoxLj55_21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLj55_21.Checked)
            {
                price += 55;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Lemon Juice = 55/=");
            }
        }

        

        private void checkBoxRegularbu290_19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRegularbu290_19.Checked)
            {
                price += 290;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Regular Burger = 290/=");
            }
        }

        

        

        private void checkBoxTehari180_24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTehari180_24.Checked)
            {
                price += 180;
                Pricelbl2.Text = price.ToString();
                Food_List.Items.Add("Tehari = 180/=");
            }
        }

        

        
       
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(price >= 0)
            {
                price = 0;
                Pricelbl2.Text = price.ToString();
            }
            databasebutton2.Visible = false;
            secretbutton2.Visible = false;
            secrettextBox1.Visible = false;
            secrettextBox1.Text = "";
            nextlabel3.Text = "";
            
            Food_List.Items.Clear();
            if (checkBoxChocone120_6.Checked)
            {
                checkBoxChocone120_6.Checked = false;
            }
            if (checkBoxCocaCola42_29.Checked)
            {
                checkBoxCocaCola42_29.Checked = false;
            }
            if (checkBoxMiniDoi150_29.Checked)
            {
                checkBoxMiniDoi150_29.Checked = false;
            }
            if (checkBoxFriedChicken90_11.Checked)
            {
                checkBoxFriedChicken90_11.Checked = false;
            }
            if (checkBoxFriedFullc600_5.Checked)
            {
                checkBoxFriedFullc600_5.Checked = false;
            }
            if (checkBoxFriedMuc900_14.Checked)
            {
                checkBoxFriedMuc900_14.Checked = false;
            }
            if (checkBoxGrillPorata110_10.Checked)
            {
                checkBoxGrillPorata110_10.Checked = false;
            }
            if (checkBoxHotdog500_13.Checked)
            {
                checkBoxHotdog500_13.Checked = false;
            }
            if (checkBoxHydraBiri900_12.Checked)
            {
                checkBoxHydraBiri900_12.Checked = false;
            }
            if (checkBoxKalavuna500_15.Checked) {
                checkBoxKalavuna500_15.Checked = false;
            }
            if (checkBoxLavender400_16.Checked)
            {
                checkBoxLavender400_16.Checked = false;
            }
            if (checkBoxSpmuBri280_22.Checked)
            {
                checkBoxSpmuBri280_22.Checked = false;
            }
            if (checkBoxLj55_21.Checked)
            {
                checkBoxLj55_21.Checked = false;
            }
            if (checkBoxRegularbu290_19.Checked)
            {
                checkBoxRegularbu290_19.Checked = false;
            }
            if (checkBoxTehari180_24.Checked)
            {
                checkBoxTehari180_24.Checked = false;
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Specialbutton2_Click(object sender, EventArgs e)
        {
            speciallabel10.Visible = true;
            sidepanel22.Height = Specialbutton2.Height;
            sidepanel22.Top = Specialbutton2.Top;
            endlinkLabel1.BringToFront();
            panel10.BringToFront();
            panel20.BringToFront();
            panel33.BringToFront();
            panel15.BringToFront();
            panel19.BringToFront();
            speciallabel10.BringToFront();
        }

        private void aboutUsbutton2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void orderbutton2_Click(object sender, EventArgs e)
        {
            
            int x = Food_List.Items.Count;
            Food_List.Sorted = true;
            nextlabel3.Text = "";
            for(int i=0; i<x; i++)
            {
                nextlabel3.Text+=Food_List.Items[i].ToString();
               // nextlistBox2.Items.Add(Food_List.Items[i]);
            }
            Form3 f3 = new Form3(Pricelbl2.Text,nextlabel3.Text, x.ToString(),nextlabel3.Text);
            f3.ShowDialog();
        }

        private void Pricelbl2_Click(object sender, EventArgs e)
        {
           
        }

        private void secretbutton2_Click(object sender, EventArgs e)
        {
           
            string s = "teamsparta";
            if(secrettextBox1.Text == s)
            {
                databasebutton2.Visible = true;
            }
            else if (secrettextBox1.Text == "" || secrettextBox1.Text != s)
            {
                MessageBox.Show("ERROR!....Please enter given secret code! then unlock button.");
            }

            secrettextBox1.Clear();
            secrettextBox1.Visible = false;
            secretbutton2.Visible = false;
        }

        private void databasebutton2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();

        }
    }
}
