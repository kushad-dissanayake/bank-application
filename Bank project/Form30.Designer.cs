namespace Bank_project
{
    partial class Form30
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form30));
            this.label1 = new System.Windows.Forms.Label();
            this.sendrlabl = new System.Windows.Forms.Label();
            this.recvrlabl = new System.Windows.Forms.Label();
            this.btncorrect = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Transaction details";
            // 
            // sendrlabl
            // 
            this.sendrlabl.AutoSize = true;
            this.sendrlabl.BackColor = System.Drawing.Color.Transparent;
            this.sendrlabl.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendrlabl.Location = new System.Drawing.Point(46, 182);
            this.sendrlabl.Name = "sendrlabl";
            this.sendrlabl.Size = new System.Drawing.Size(27, 42);
            this.sendrlabl.TabIndex = 4;
            this.sendrlabl.Text = " ";
            // 
            // recvrlabl
            // 
            this.recvrlabl.AutoSize = true;
            this.recvrlabl.BackColor = System.Drawing.Color.Transparent;
            this.recvrlabl.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recvrlabl.Location = new System.Drawing.Point(46, 293);
            this.recvrlabl.Name = "recvrlabl";
            this.recvrlabl.Size = new System.Drawing.Size(36, 42);
            this.recvrlabl.TabIndex = 5;
            this.recvrlabl.Text = "  ";
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
            this.btncorrect.Location = new System.Drawing.Point(567, 506);
            this.btncorrect.Name = "btncorrect";
            this.btncorrect.Size = new System.Drawing.Size(240, 73);
            this.btncorrect.TabIndex = 27;
            this.btncorrect.Text = "Accounts details incorrect";
            this.btncorrect.Click += new System.EventHandler(this.btncorrect_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 35;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(567, 397);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(240, 73);
            this.guna2Button1.TabIndex = 28;
            this.guna2Button1.Text = "Confirm accounts details";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form30
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 605);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btncorrect);
            this.Controls.Add(this.recvrlabl);
            this.Controls.Add(this.sendrlabl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form30";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form30";
            this.Load += new System.EventHandler(this.Form30_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sendrlabl;
        private System.Windows.Forms.Label recvrlabl;
        private Guna.UI2.WinForms.Guna2Button btncorrect;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}