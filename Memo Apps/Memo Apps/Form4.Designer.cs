
namespace Memo_Apps
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.searchtextBox1 = new System.Windows.Forms.TextBox();
            this.trlabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.databutton2 = new System.Windows.Forms.Button();
            this.Calculatorbutton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cost1textBox2 = new System.Windows.Forms.TextBox();
            this.cost2textBox3 = new System.Windows.Forms.TextBox();
            this.addbutton1 = new System.Windows.Forms.Button();
            this.refreshbutton2 = new System.Windows.Forms.Button();
            this.Nextbutton3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalcosttextBox2 = new System.Windows.Forms.TextBox();
            this.totalsoldtextBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Chartbutton1 = new System.Windows.Forms.Button();
            this.piechart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.totalcalculationbutton1 = new System.Windows.Forms.Button();
            this.refgbutton2 = new System.Windows.Forms.Button();
            this.cdlabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piechart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(806, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 691);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // searchtextBox1
            // 
            this.searchtextBox1.Location = new System.Drawing.Point(1041, 49);
            this.searchtextBox1.Name = "searchtextBox1";
            this.searchtextBox1.Size = new System.Drawing.Size(208, 20);
            this.searchtextBox1.TabIndex = 2;
            this.searchtextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // trlabel1
            // 
            this.trlabel1.AutoSize = true;
            this.trlabel1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trlabel1.ForeColor = System.Drawing.Color.Yellow;
            this.trlabel1.Location = new System.Drawing.Point(985, 9);
            this.trlabel1.Name = "trlabel1";
            this.trlabel1.Size = new System.Drawing.Size(126, 24);
            this.trlabel1.TabIndex = 3;
            this.trlabel1.Text = "Total Records";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.panel1.Controls.Add(this.databutton2);
            this.panel1.Controls.Add(this.Calculatorbutton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 67);
            this.panel1.TabIndex = 4;
            // 
            // databutton2
            // 
            this.databutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("databutton2.BackgroundImage")));
            this.databutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.databutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.databutton2.FlatAppearance.BorderSize = 0;
            this.databutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databutton2.Location = new System.Drawing.Point(107, 28);
            this.databutton2.Name = "databutton2";
            this.databutton2.Size = new System.Drawing.Size(56, 36);
            this.databutton2.TabIndex = 1;
            this.databutton2.UseVisualStyleBackColor = true;
            this.databutton2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculatorbutton1
            // 
            this.Calculatorbutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculatorbutton1.BackgroundImage")));
            this.Calculatorbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Calculatorbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculatorbutton1.FlatAppearance.BorderSize = 0;
            this.Calculatorbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculatorbutton1.Location = new System.Drawing.Point(7, 28);
            this.Calculatorbutton1.Name = "Calculatorbutton1";
            this.Calculatorbutton1.Size = new System.Drawing.Size(56, 36);
            this.Calculatorbutton1.TabIndex = 1;
            this.Calculatorbutton1.UseVisualStyleBackColor = true;
            this.Calculatorbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "System DataBoard";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Nextbutton3);
            this.groupBox1.Controls.Add(this.refreshbutton2);
            this.groupBox1.Controls.Add(this.addbutton1);
            this.groupBox1.Controls.Add(this.cost2textBox3);
            this.groupBox1.Controls.Add(this.cost1textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 242);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add All Cost";
            // 
            // cost1textBox2
            // 
            this.cost1textBox2.Location = new System.Drawing.Point(69, 39);
            this.cost1textBox2.Name = "cost1textBox2";
            this.cost1textBox2.Size = new System.Drawing.Size(117, 24);
            this.cost1textBox2.TabIndex = 0;
            // 
            // cost2textBox3
            // 
            this.cost2textBox3.Location = new System.Drawing.Point(69, 85);
            this.cost2textBox3.Name = "cost2textBox3";
            this.cost2textBox3.Size = new System.Drawing.Size(117, 24);
            this.cost2textBox3.TabIndex = 0;
            // 
            // addbutton1
            // 
            this.addbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton1.Location = new System.Drawing.Point(136, 129);
            this.addbutton1.Name = "addbutton1";
            this.addbutton1.Size = new System.Drawing.Size(50, 29);
            this.addbutton1.TabIndex = 1;
            this.addbutton1.Text = "Add";
            this.addbutton1.UseVisualStyleBackColor = true;
            this.addbutton1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // refreshbutton2
            // 
            this.refreshbutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshbutton2.BackgroundImage")));
            this.refreshbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshbutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshbutton2.FlatAppearance.BorderSize = 0;
            this.refreshbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbutton2.Location = new System.Drawing.Point(136, 194);
            this.refreshbutton2.Name = "refreshbutton2";
            this.refreshbutton2.Size = new System.Drawing.Size(46, 32);
            this.refreshbutton2.TabIndex = 1;
            this.refreshbutton2.UseVisualStyleBackColor = true;
            this.refreshbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nextbutton3
            // 
            this.Nextbutton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nextbutton3.BackgroundImage")));
            this.Nextbutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nextbutton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nextbutton3.FlatAppearance.BorderSize = 0;
            this.Nextbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nextbutton3.Location = new System.Drawing.Point(7, 194);
            this.Nextbutton3.Name = "Nextbutton3";
            this.Nextbutton3.Size = new System.Drawing.Size(47, 32);
            this.Nextbutton3.TabIndex = 1;
            this.Nextbutton3.UseVisualStyleBackColor = true;
            this.Nextbutton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Chartbutton1);
            this.groupBox2.Controls.Add(this.totalsoldtextBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.totalcosttextBox2);
            this.groupBox2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(286, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 242);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profit/Loss";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Add : ";
            // 
            // totalcosttextBox2
            // 
            this.totalcosttextBox2.Location = new System.Drawing.Point(72, 39);
            this.totalcosttextBox2.Name = "totalcosttextBox2";
            this.totalcosttextBox2.Size = new System.Drawing.Size(122, 25);
            this.totalcosttextBox2.TabIndex = 0;
            // 
            // totalsoldtextBox3
            // 
            this.totalsoldtextBox3.Location = new System.Drawing.Point(72, 88);
            this.totalsoldtextBox3.Name = "totalsoldtextBox3";
            this.totalsoldtextBox3.Size = new System.Drawing.Size(122, 25);
            this.totalsoldtextBox3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cost :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 2;
            this.label6.Tag = "";
            this.label6.Text = "Sold : ";
            // 
            // Chartbutton1
            // 
            this.Chartbutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chartbutton1.BackgroundImage")));
            this.Chartbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Chartbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chartbutton1.FlatAppearance.BorderSize = 0;
            this.Chartbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chartbutton1.Location = new System.Drawing.Point(145, 191);
            this.Chartbutton1.Name = "Chartbutton1";
            this.Chartbutton1.Size = new System.Drawing.Size(49, 39);
            this.Chartbutton1.TabIndex = 3;
            this.Chartbutton1.UseVisualStyleBackColor = true;
            this.Chartbutton1.Click += new System.EventHandler(this.Chartbutton1_Click);
            // 
            // piechart1
            // 
            chartArea1.Name = "ChartArea1";
            this.piechart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.piechart1.Legends.Add(legend1);
            this.piechart1.Location = new System.Drawing.Point(21, 392);
            this.piechart1.Name = "piechart1";
            this.piechart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.piechart1.Series.Add(series1);
            this.piechart1.Size = new System.Drawing.Size(465, 363);
            this.piechart1.TabIndex = 7;
            this.piechart1.Text = "Loss And Profit";
            this.piechart1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(530, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(719, 725);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.Visible = false;
            // 
            // totalcalculationbutton1
            // 
            this.totalcalculationbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalcalculationbutton1.ForeColor = System.Drawing.Color.Red;
            this.totalcalculationbutton1.Location = new System.Drawing.Point(530, 5);
            this.totalcalculationbutton1.Name = "totalcalculationbutton1";
            this.totalcalculationbutton1.Size = new System.Drawing.Size(116, 42);
            this.totalcalculationbutton1.TabIndex = 9;
            this.totalcalculationbutton1.Text = "Click Here See Total Calculation";
            this.totalcalculationbutton1.UseVisualStyleBackColor = true;
            this.totalcalculationbutton1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // refgbutton2
            // 
            this.refgbutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refgbutton2.BackgroundImage")));
            this.refgbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refgbutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refgbutton2.FlatAppearance.BorderSize = 0;
            this.refgbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refgbutton2.Location = new System.Drawing.Point(1224, 4);
            this.refgbutton2.Name = "refgbutton2";
            this.refgbutton2.Size = new System.Drawing.Size(34, 31);
            this.refgbutton2.TabIndex = 10;
            this.refgbutton2.UseVisualStyleBackColor = true;
            this.refgbutton2.Visible = false;
            this.refgbutton2.Click += new System.EventHandler(this.refgbutton2_Click);
            // 
            // cdlabel1
            // 
            this.cdlabel1.AutoSize = true;
            this.cdlabel1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdlabel1.ForeColor = System.Drawing.Color.Yellow;
            this.cdlabel1.Location = new System.Drawing.Point(526, 14);
            this.cdlabel1.Name = "cdlabel1";
            this.cdlabel1.Size = new System.Drawing.Size(150, 24);
            this.cdlabel1.TabIndex = 3;
            this.cdlabel1.Text = "Calculated Data:";
            this.cdlabel1.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1270, 778);
            this.Controls.Add(this.refgbutton2);
            this.Controls.Add(this.totalcalculationbutton1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.piechart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cdlabel1);
            this.Controls.Add(this.trlabel1);
            this.Controls.Add(this.searchtextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Data Board";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piechart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.TextBox searchtextBox1;
        private System.Windows.Forms.Label trlabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Calculatorbutton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button databutton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Nextbutton3;
        private System.Windows.Forms.Button refreshbutton2;
        private System.Windows.Forms.Button addbutton1;
        private System.Windows.Forms.TextBox cost2textBox3;
        private System.Windows.Forms.TextBox cost1textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Chartbutton1;
        private System.Windows.Forms.TextBox totalsoldtextBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalcosttextBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart piechart1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button totalcalculationbutton1;
        private System.Windows.Forms.Button refgbutton2;
        private System.Windows.Forms.Label cdlabel1;
    }
}