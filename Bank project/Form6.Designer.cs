using System;

namespace Bank_project
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.textamount = new System.Windows.Forms.TextBox();
            this.lblmsg3 = new System.Windows.Forms.Label();
            this.btnenter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.backbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter amount";
            // 
            // textamount
            // 
            this.textamount.BackColor = System.Drawing.Color.LightGray;
            this.textamount.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textamount.Location = new System.Drawing.Point(320, 292);
            this.textamount.Multiline = true;
            this.textamount.Name = "textamount";
            this.textamount.Size = new System.Drawing.Size(278, 69);
            this.textamount.TabIndex = 1;
            this.textamount.Text = " ";
            this.textamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textamount.TextChanged += new System.EventHandler(this.textamount_TextChanged);
            this.textamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textamount_KeyPress);
            // 
            // lblmsg3
            // 
            this.lblmsg3.AutoSize = true;
            this.lblmsg3.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg3.Location = new System.Drawing.Point(604, 311);
            this.lblmsg3.Name = "lblmsg3";
            this.lblmsg3.Size = new System.Drawing.Size(18, 25);
            this.lblmsg3.TabIndex = 13;
            this.lblmsg3.Text = " ";
            // 
            // btnenter
            // 
            this.btnenter.BackColor = System.Drawing.Color.Transparent;
            this.btnenter.BorderColor = System.Drawing.Color.White;
            this.btnenter.BorderRadius = 25;
            this.btnenter.BorderThickness = 2;
            this.btnenter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnenter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnenter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnenter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnenter.FillColor = System.Drawing.Color.Black;
            this.btnenter.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnenter.ForeColor = System.Drawing.Color.White;
            this.btnenter.Location = new System.Drawing.Point(392, 400);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(146, 51);
            this.btnenter.TabIndex = 27;
            this.btnenter.Text = "Enter";
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(153, 311);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(110, 42);
            this.guna2Button1.TabIndex = 28;
            this.guna2Button1.Text = "Clear";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.BorderColor = System.Drawing.Color.White;
            this.backbtn.BorderRadius = 22;
            this.backbtn.BorderThickness = 2;
            this.backbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backbtn.FillColor = System.Drawing.Color.Black;
            this.backbtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(27, 552);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(129, 48);
            this.backbtn.TabIndex = 39;
            this.backbtn.Text = "Back";
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 22;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Black;
            this.guna2Button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(742, 552);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(129, 48);
            this.guna2Button2.TabIndex = 40;
            this.guna2Button2.Text = "Cancel";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 623);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.lblmsg3);
            this.Controls.Add(this.textamount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnenter3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textamount;
        private System.Windows.Forms.Label lblmsg3;
        private Guna.UI2.WinForms.Guna2Button btnenter;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button backbtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}