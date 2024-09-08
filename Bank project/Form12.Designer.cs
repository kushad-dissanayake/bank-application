namespace Bank_project
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.label2 = new System.Windows.Forms.Label();
            this.textamount2 = new System.Windows.Forms.TextBox();
            this.btnenter2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.lblmsg2 = new System.Windows.Forms.Label();
            this.balancelbl = new System.Windows.Forms.Label();
            this.backbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(768, 55);
            this.label2.TabIndex = 30;
            this.label2.Text = "Enter the amount you are depositing";
            // 
            // textamount2
            // 
            this.textamount2.BackColor = System.Drawing.Color.LightGray;
            this.textamount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textamount2.Location = new System.Drawing.Point(268, 197);
            this.textamount2.Multiline = true;
            this.textamount2.Name = "textamount2";
            this.textamount2.Size = new System.Drawing.Size(278, 69);
            this.textamount2.TabIndex = 31;
            this.textamount2.Text = " ";
            this.textamount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textamount2.TextChanged += new System.EventHandler(this.textamount2_TextChanged);
            this.textamount2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textamount2_KeyPress);
            // 
            // btnenter2
            // 
            this.btnenter2.BackColor = System.Drawing.Color.Transparent;
            this.btnenter2.BorderColor = System.Drawing.Color.White;
            this.btnenter2.BorderRadius = 22;
            this.btnenter2.BorderThickness = 2;
            this.btnenter2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnenter2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnenter2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnenter2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnenter2.FillColor = System.Drawing.Color.Black;
            this.btnenter2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnenter2.ForeColor = System.Drawing.Color.White;
            this.btnenter2.Location = new System.Drawing.Point(671, 457);
            this.btnenter2.Name = "btnenter2";
            this.btnenter2.Size = new System.Drawing.Size(136, 46);
            this.btnenter2.TabIndex = 32;
            this.btnenter2.Text = "Enter";
            this.btnenter2.Click += new System.EventHandler(this.btnenter2_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.BorderColor = System.Drawing.Color.White;
            this.btnclear.BorderRadius = 22;
            this.btnclear.BorderThickness = 2;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.Black;
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(340, 305);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(136, 46);
            this.btnclear.TabIndex = 33;
            this.btnclear.Text = "Clear";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblmsg2
            // 
            this.lblmsg2.AutoSize = true;
            this.lblmsg2.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg2.Location = new System.Drawing.Point(552, 227);
            this.lblmsg2.Name = "lblmsg2";
            this.lblmsg2.Size = new System.Drawing.Size(20, 22);
            this.lblmsg2.TabIndex = 34;
            this.lblmsg2.Text = "  ";
            // 
            // balancelbl
            // 
            this.balancelbl.AutoSize = true;
            this.balancelbl.BackColor = System.Drawing.Color.Transparent;
            this.balancelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancelbl.Location = new System.Drawing.Point(240, 457);
            this.balancelbl.Name = "balancelbl";
            this.balancelbl.Size = new System.Drawing.Size(19, 25);
            this.balancelbl.TabIndex = 37;
            this.balancelbl.Text = " ";
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
            this.backbtn.Location = new System.Drawing.Point(49, 455);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(129, 48);
            this.backbtn.TabIndex = 38;
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
            this.guna2Button1.Location = new System.Drawing.Point(340, 455);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(129, 48);
            this.guna2Button1.TabIndex = 39;
            this.guna2Button1.Text = "Cancel";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.balancelbl);
            this.Controls.Add(this.lblmsg2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnenter2);
            this.Controls.Add(this.textamount2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textamount2;
        private Guna.UI2.WinForms.Guna2Button btnenter2;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private System.Windows.Forms.Label lblmsg2;
        private System.Windows.Forms.Label balancelbl;
        private Guna.UI2.WinForms.Guna2Button backbtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}