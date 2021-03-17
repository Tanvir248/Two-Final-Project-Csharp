
namespace HDA_Hospital_Data_Analysis_
{
    partial class NewDiseas
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
            this.add_button = new System.Windows.Forms.Button();
            this.diseas_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(524, 194);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(103, 23);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // diseas_name
            // 
            this.diseas_name.Location = new System.Drawing.Point(261, 194);
            this.diseas_name.Name = "diseas_name";
            this.diseas_name.Size = new System.Drawing.Size(237, 20);
            this.diseas_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(256, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Disease to Database";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewDiseas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diseas_name);
            this.Controls.Add(this.add_button);
            this.Name = "NewDiseas";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.NewDiseas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox diseas_name;
        private System.Windows.Forms.Label label1;
    }
}