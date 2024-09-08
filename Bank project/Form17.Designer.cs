namespace Bank_project
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            this.btnincorrect = new Guna.UI2.WinForms.Guna2Button();
            this.btncorrect = new Guna.UI2.WinForms.Guna2Button();
            this.lblmsg5 = new System.Windows.Forms.Label();
            this.textaccountno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
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
            this.btnincorrect.Location = new System.Drawing.Point(569, 449);
            this.btnincorrect.Name = "btnincorrect";
            this.btnincorrect.Size = new System.Drawing.Size(240, 73);
            this.btnincorrect.TabIndex = 32;
            this.btnincorrect.Text = "Account number is incorrect";
            this.btnincorrect.Click += new System.EventHandler(this.btnincorrect_Click);
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
            this.btncorrect.Location = new System.Drawing.Point(569, 340);
            this.btncorrect.Name = "btncorrect";
            this.btncorrect.Size = new System.Drawing.Size(240, 73);
            this.btncorrect.TabIndex = 31;
            this.btncorrect.Text = "Account number is correct";
            this.btncorrect.Click += new System.EventHandler(this.btncorrect_Click);
            // 
            // lblmsg5
            // 
            this.lblmsg5.AutoSize = true;
            this.lblmsg5.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg5.Location = new System.Drawing.Point(606, 198);
            this.lblmsg5.Name = "lblmsg5";
            this.lblmsg5.Size = new System.Drawing.Size(20, 24);
            this.lblmsg5.TabIndex = 30;
            this.lblmsg5.Text = "  ";
            // 
            // textaccountno
            // 
            this.textaccountno.BackColor = System.Drawing.Color.LightGray;
            this.textaccountno.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textaccountno.Location = new System.Drawing.Point(228, 178);
            this.textaccountno.Multiline = true;
            this.textaccountno.Name = "textaccountno";
            this.textaccountno.Size = new System.Drawing.Size(363, 57);
            this.textaccountno.TabIndex = 29;
            this.textaccountno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textaccountno.TextChanged += new System.EventHandler(this.textaccountno_TextChanged);
            this.textaccountno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textaccountno_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 55);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter your account number";
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
            this.backbtn.Location = new System.Drawing.Point(33, 474);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(129, 48);
            this.backbtn.TabIndex = 39;
            this.backbtn.Text = "Back";
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
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
            this.guna2Button1.Location = new System.Drawing.Point(303, 474);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(129, 48);
            this.guna2Button1.TabIndex = 40;
            this.guna2Button1.Text = "Cancel";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.btnincorrect);
            this.Controls.Add(this.btncorrect);
            this.Controls.Add(this.lblmsg5);
            this.Controls.Add(this.textaccountno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form17";
            this.Load += new System.EventHandler(this.Form17_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnincorrect;
        private Guna.UI2.WinForms.Guna2Button btncorrect;
        private System.Windows.Forms.Label lblmsg5;
        private System.Windows.Forms.TextBox textaccountno;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button backbtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}