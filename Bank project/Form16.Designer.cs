namespace Bank_project
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.accnolabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btncorrect = new Guna.UI2.WinForms.Guna2Button();
            this.namelbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.accountballbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // accnolabel1
            // 
            this.accnolabel1.BackColor = System.Drawing.Color.Transparent;
            this.accnolabel1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accnolabel1.Location = new System.Drawing.Point(56, 34);
            this.accnolabel1.Name = "accnolabel1";
            this.accnolabel1.Size = new System.Drawing.Size(3, 2);
            this.accnolabel1.TabIndex = 2;
            this.accnolabel1.Text = null;
            this.accnolabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncorrect
            // 
            this.btncorrect.BackColor = System.Drawing.Color.Transparent;
            this.btncorrect.BorderColor = System.Drawing.Color.White;
            this.btncorrect.BorderRadius = 25;
            this.btncorrect.BorderThickness = 2;
            this.btncorrect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncorrect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncorrect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncorrect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncorrect.FillColor = System.Drawing.Color.Black;
            this.btncorrect.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btncorrect.ForeColor = System.Drawing.Color.White;
            this.btncorrect.Location = new System.Drawing.Point(620, 451);
            this.btncorrect.Name = "btncorrect";
            this.btncorrect.Size = new System.Drawing.Size(173, 54);
            this.btncorrect.TabIndex = 23;
            this.btncorrect.Text = "Back";
            this.btncorrect.Click += new System.EventHandler(this.btncorrect_Click);
            // 
            // namelbl
            // 
            this.namelbl.BackColor = System.Drawing.Color.Transparent;
            this.namelbl.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(56, 168);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(3, 2);
            this.namelbl.TabIndex = 26;
            this.namelbl.Text = null;
            this.namelbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountballbl
            // 
            this.accountballbl.BackColor = System.Drawing.Color.Transparent;
            this.accountballbl.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountballbl.Location = new System.Drawing.Point(56, 288);
            this.accountballbl.Name = "accountballbl";
            this.accountballbl.Size = new System.Drawing.Size(3, 2);
            this.accountballbl.TabIndex = 27;
            this.accountballbl.Text = null;
            this.accountballbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.accountballbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.btncorrect);
            this.Controls.Add(this.accnolabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel accnolabel1;
        private Guna.UI2.WinForms.Guna2Button btncorrect;
        private Guna.UI2.WinForms.Guna2HtmlLabel namelbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel accountballbl;
    }
}