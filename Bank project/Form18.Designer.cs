namespace Bank_project
{
    partial class Form18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form18));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enterpin = new System.Windows.Forms.TextBox();
            this.cnfrmpin = new System.Windows.Forms.TextBox();
            this.btnenter2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblmsg = new System.Windows.Forms.Label();
            this.lblmsg2 = new System.Windows.Forms.Label();
            this.lblmsg3 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 55);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pin Changing Validation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 55);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter New Pin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 55);
            this.label3.TabIndex = 17;
            this.label3.Text = "Confirm  Pin";
            // 
            // enterpin
            // 
            this.enterpin.BackColor = System.Drawing.Color.LightGray;
            this.enterpin.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterpin.Location = new System.Drawing.Point(520, 205);
            this.enterpin.Multiline = true;
            this.enterpin.Name = "enterpin";
            this.enterpin.PasswordChar = '*';
            this.enterpin.Size = new System.Drawing.Size(177, 62);
            this.enterpin.TabIndex = 18;
            this.enterpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enterpin.TextChanged += new System.EventHandler(this.enterpin_TextChanged);
            this.enterpin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterpin_KeyPress);
            // 
            // cnfrmpin
            // 
            this.cnfrmpin.BackColor = System.Drawing.Color.LightGray;
            this.cnfrmpin.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnfrmpin.Location = new System.Drawing.Point(520, 312);
            this.cnfrmpin.Multiline = true;
            this.cnfrmpin.Name = "cnfrmpin";
            this.cnfrmpin.PasswordChar = '*';
            this.cnfrmpin.Size = new System.Drawing.Size(177, 62);
            this.cnfrmpin.TabIndex = 19;
            this.cnfrmpin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cnfrmpin.TextChanged += new System.EventHandler(this.cnfrmpin_TextChanged);
            this.cnfrmpin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnfrmpin_KeyPress);
            // 
            // btnenter2
            // 
            this.btnenter2.BackColor = System.Drawing.Color.Transparent;
            this.btnenter2.BorderColor = System.Drawing.Color.White;
            this.btnenter2.BorderRadius = 28;
            this.btnenter2.BorderThickness = 2;
            this.btnenter2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnenter2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnenter2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnenter2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnenter2.FillColor = System.Drawing.Color.Black;
            this.btnenter2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
            this.btnenter2.ForeColor = System.Drawing.Color.White;
            this.btnenter2.Location = new System.Drawing.Point(652, 494);
            this.btnenter2.Name = "btnenter2";
            this.btnenter2.Size = new System.Drawing.Size(155, 56);
            this.btnenter2.TabIndex = 20;
            this.btnenter2.Text = "Change";
            this.btnenter2.Click += new System.EventHandler(this.btnenter2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(49, 504);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(123, 46);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "Back";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.Location = new System.Drawing.Point(713, 226);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(21, 31);
            this.lblmsg.TabIndex = 22;
            this.lblmsg.Text = " ";
            // 
            // lblmsg2
            // 
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg2.Location = new System.Drawing.Point(713, 333);
            this.lblmsg2.Name = "lblmsg2";
            this.lblmsg2.Size = new System.Drawing.Size(21, 31);
            this.lblmsg2.TabIndex = 23;
            this.lblmsg2.Text = " ";
            // 
            // lblmsg3
            // 
            this.lblmsg3.AutoSize = true;
            this.lblmsg3.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg3.Location = new System.Drawing.Point(169, 420);
            this.lblmsg3.Name = "lblmsg3";
            this.lblmsg3.Size = new System.Drawing.Size(0, 31);
            this.lblmsg3.TabIndex = 24;
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
            this.guna2Button2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(545, 391);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(123, 46);
            this.guna2Button2.TabIndex = 25;
            this.guna2Button2.Text = "Clear";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.BorderRadius = 22;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Black;
            this.guna2Button3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(357, 504);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(123, 46);
            this.guna2Button3.TabIndex = 26;
            this.guna2Button3.Text = "Cancel";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 605);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.lblmsg3);
            this.Controls.Add(this.lblmsg2);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnenter2);
            this.Controls.Add(this.cnfrmpin);
            this.Controls.Add(this.enterpin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form18";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form18";
            this.Load += new System.EventHandler(this.Form18_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enterpin;
        private System.Windows.Forms.TextBox cnfrmpin;
        private Guna.UI2.WinForms.Guna2Button btnenter2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lblmsg2;
        private System.Windows.Forms.Label lblmsg3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}