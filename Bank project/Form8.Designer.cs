namespace Bank_project
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.label1 = new System.Windows.Forms.Label();
            this.textaccountno = new System.Windows.Forms.TextBox();
            this.lblmsg5 = new System.Windows.Forms.Label();
            this.btncorrect = new Guna.UI2.WinForms.Guna2Button();
            this.btnincorrect = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter your account number";
            // 
            // textaccountno
            // 
            this.textaccountno.BackColor = System.Drawing.Color.LightGray;
            this.textaccountno.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textaccountno.Location = new System.Drawing.Point(234, 197);
            this.textaccountno.Multiline = true;
            this.textaccountno.Name = "textaccountno";
            this.textaccountno.Size = new System.Drawing.Size(363, 57);
            this.textaccountno.TabIndex = 9;
            this.textaccountno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textaccountno.TextChanged += new System.EventHandler(this.textpin_TextChanged);
            this.textaccountno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textaccountno_KeyPress);
            // 
            // lblmsg5
            // 
            this.lblmsg5.AutoSize = true;
            this.lblmsg5.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg5.Location = new System.Drawing.Point(603, 216);
            this.lblmsg5.Name = "lblmsg5";
            this.lblmsg5.Size = new System.Drawing.Size(20, 24);
            this.lblmsg5.TabIndex = 20;
            this.lblmsg5.Text = "  ";
            // 
            // btncorrect
            // 
            this.btncorrect.BackColor = System.Drawing.Color.Transparent;
            this.btncorrect.BorderColor = System.Drawing.Color.White;
            this.btncorrect.BorderRadius = 35;
            this.btncorrect.BorderThickness = 2;
            this.btncorrect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncorrect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncorrect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncorrect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncorrect.FillColor = System.Drawing.Color.Black;
            this.btncorrect.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btncorrect.ForeColor = System.Drawing.Color.White;
            this.btncorrect.Location = new System.Drawing.Point(577, 346);
            this.btncorrect.Name = "btncorrect";
            this.btncorrect.Size = new System.Drawing.Size(240, 73);
            this.btncorrect.TabIndex = 21;
            this.btncorrect.Text = "Account number is correct";
            this.btncorrect.Click += new System.EventHandler(this.btncorrect_Click);
            // 
            // btnincorrect
            // 
            this.btnincorrect.BackColor = System.Drawing.Color.Transparent;
            this.btnincorrect.BorderColor = System.Drawing.Color.White;
            this.btnincorrect.BorderRadius = 35;
            this.btnincorrect.BorderThickness = 2;
            this.btnincorrect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnincorrect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnincorrect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnincorrect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnincorrect.FillColor = System.Drawing.Color.Black;
            this.btnincorrect.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnincorrect.ForeColor = System.Drawing.Color.White;
            this.btnincorrect.Location = new System.Drawing.Point(577, 455);
            this.btnincorrect.Name = "btnincorrect";
            this.btnincorrect.Size = new System.Drawing.Size(240, 73);
            this.btnincorrect.TabIndex = 22;
            this.btnincorrect.Text = "Account number is incorrect";
            this.btnincorrect.Click += new System.EventHandler(this.btnincorrect_Click);
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
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(45, 480);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(129, 48);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "Back";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.guna2Button2.Location = new System.Drawing.Point(312, 480);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(129, 48);
            this.guna2Button2.TabIndex = 24;
            this.guna2Button2.Text = "Cancel";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnincorrect);
            this.Controls.Add(this.btncorrect);
            this.Controls.Add(this.lblmsg5);
            this.Controls.Add(this.textaccountno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textaccountno;
        private System.Windows.Forms.Label lblmsg5;
        private Guna.UI2.WinForms.Guna2Button btncorrect;
        private Guna.UI2.WinForms.Guna2Button btnincorrect;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}