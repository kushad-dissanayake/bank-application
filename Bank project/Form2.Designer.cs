namespace Bank_project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btnyes = new Guna.UI2.WinForms.Guna2Button();
            this.btnno = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you need a  receipt for this transaction?";
            // 
            // btnyes
            // 
            this.btnyes.BackColor = System.Drawing.Color.Transparent;
            this.btnyes.BorderColor = System.Drawing.Color.White;
            this.btnyes.BorderRadius = 25;
            this.btnyes.BorderThickness = 2;
            this.btnyes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnyes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnyes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnyes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnyes.FillColor = System.Drawing.Color.Black;
            this.btnyes.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btnyes.ForeColor = System.Drawing.Color.White;
            this.btnyes.Location = new System.Drawing.Point(600, 334);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(171, 53);
            this.btnyes.TabIndex = 5;
            this.btnyes.Text = "Yes";
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click_1);
            // 
            // btnno
            // 
            this.btnno.BackColor = System.Drawing.Color.Transparent;
            this.btnno.BorderColor = System.Drawing.Color.White;
            this.btnno.BorderRadius = 25;
            this.btnno.BorderThickness = 2;
            this.btnno.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnno.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnno.FillColor = System.Drawing.Color.Black;
            this.btnno.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.btnno.ForeColor = System.Drawing.Color.White;
            this.btnno.Location = new System.Drawing.Point(600, 459);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(171, 53);
            this.btnno.TabIndex = 6;
            this.btnno.Text = "No";
            this.btnno.Click += new System.EventHandler(this.btnno_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnyes;
        private Guna.UI2.WinForms.Guna2Button btnno;
    }
}