using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Data.SqlClient;
using System.Media;

namespace Bank_project
{
    public partial class Form37 : Form
    {
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");
        Thread th;
        public static string passward;
        public Form37()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";

        private void btnmanager_Click(object sender, EventArgs e)
        {
  
        }

        private void Form37_Load(object sender, EventArgs e)
        {

        }

        private void btncustmr_Click(object sender, EventArgs e)
        {

        }
        private void btnacontnt_Click(object sender, EventArgs e)
        {
    

        }

        private void textstatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 4)

                e.Handled = true;
        }

        private void textstatus_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            textstatus.Text = textInfo.ToTitleCase(textstatus.Text);
            textstatus.SelectionStart = textstatus.Text.Length;
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            lblmsg1.Text = "";
            lblmsg2.Text = "";
            lblmsg3.Text = "";
            SqlConnection con = new SqlConnection(connectionString);

            string value = textpin.Text;

            string query = "SELECT COUNT(*) FROM Bank WHERE Passward = @Value";
            string query1 = "SELECT COUNT(*) FROM Manager WHERE Passward = @Value";
            string query2 = "SELECT COUNT(*) FROM Accountent WHERE Pin_no = @Value";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);

            cmd.Parameters.AddWithValue("@Value", value);
            con.Open();
            int result = (int)cmd.ExecuteScalar();
            con.Close();

            cmd1.Parameters.AddWithValue("@Value", value);
            con.Open();
            int result1 =(int)cmd1.ExecuteScalar();
            con.Close() ;

            cmd2.Parameters.AddWithValue("@Value", value);
            con.Open();
            int result2 = (int)cmd2.ExecuteScalar();
            con.Close();

            if(textstatus.Text == "" && textpin.Text == "")
            {
                lblmsg1.ForeColor = System.Drawing.Color.Red;
                lblmsg1.Text = "Empty";
                lblmsg2.ForeColor = System.Drawing.Color.Red;
                lblmsg2.Text = "Empty";
                textstatus.Clear();
                textpin.Clear();
                _soundPlayer2.Play();



            }
            if (textstatus.Text == "" && textpin.Text != "")
            {
                lblmsg1.ForeColor = System.Drawing.Color.Red;
                lblmsg1.Text = "Empty";
                textstatus.Clear();
                _soundPlayer2.Play();

            }
            if (textstatus.Text != "" && textpin.Text == "")
            {
                lblmsg2.ForeColor = System.Drawing.Color.Red;
                lblmsg2.Text = "Empty";
                textpin.Clear();
                _soundPlayer2.Play();


            }
            else
            {
                try
                {
                    if (textstatus.Text == "Customer" && result > 0)
                    {
                        passward = textpin.Text;
                        this.Hide();
                        Form38 fm = new Form38(textstatus.Text);
                        fm.Show();

                    }

                    else if (textstatus.Text == "Manager" && result1 > 0)
                    {
                        passward = textpin.Text;
                        this.Hide();
                        Form38 fm = new Form38(textstatus.Text);
                        fm.Show();
                    }

                    else if (textstatus.Text == "Accountent" && result2 > 0)
                    {
                        passward = textpin.Text;
                        this.Hide();
                        Form38 fm = new Form38(textstatus.Text);
                        fm.Show();
                    }
                    else
                    {
                        lblmsg3.ForeColor = System.Drawing.Color.Red;
                        lblmsg3.Text = "Invalid status or password";
                        textstatus.Clear();
                        textpin.Clear();
                        _soundPlayer2.Play();

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform1(object obj)
        {
            Application.Run(new Form1());

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            textstatus.Clear();
            textpin.Clear();
        }

        private void textpin_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }
    }
}
