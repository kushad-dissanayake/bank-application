using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_project
{
    public partial class Form31 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");

        public Form31()
        {
            InitializeComponent();
        }
        public static string Amount5;
        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";

        public static int newbalance;
        public static int newbalance2;
        public static int newbalance3;
        private void btnenter2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            lblmsg2.Text = "";
            SqlConnection con4 = new SqlConnection(connectionString);
            con4.Open();

            SqlCommand command3 = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form29.AccountNumber, con4);
            object result3 = command3.ExecuteScalar();
            if (result3 != null)
            {
                string oldbalance3 = result3.ToString();
                newbalance3 = Convert.ToInt32(oldbalance3);
                con4.Close();

                if (textamount2.Text == "")
                {
                    _soundPlayer2.Play();
                    lblmsg2.ForeColor = System.Drawing.Color.Red;
                    lblmsg2.Text = "Please enter amount";

                }
                else if (Convert.ToInt32(textamount2.Text) < 100)
                {
                    lblmsg2.ForeColor = System.Drawing.Color.Red;
                    lblmsg2.Text = "Please enter above 100";
                    textamount2.Clear();
                    _soundPlayer2.Play();

                }

                else if ((Convert.ToInt32(textamount2.Text) % 100) != 0)
                {
                    lblmsg2.ForeColor = System.Drawing.Color.Red;
                    lblmsg2.Text = "Please enter valid amount";
                    textamount2.Clear();
                    _soundPlayer2.Play();
                }
                else if (Convert.ToInt32(textamount2.Text) > newbalance3)
                {
                    lblmsg2.ForeColor = System.Drawing.Color.Red;
                    lblmsg2.Text = "Account balance is insufficient";
                    textamount2.Clear();
                    _soundPlayer2.Play();
                }
                else if (Convert.ToInt32(textamount2.Text) > (newbalance3 - 50))
                {
                    lblmsg2.ForeColor = System.Drawing.Color.Red;
                    lblmsg2.Text = "Cant withdrawal this amount";
                    textamount2.Clear();
                    _soundPlayer2.Play();
                }

                else

                {
                    SqlConnection con2 = new SqlConnection(connectionString);
                    con2.Open();

                    SqlCommand command = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form29.AccountNumber, con2);
                    SqlCommand command2 = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form29.AccountNumber2, con2);
                    object result = command.ExecuteScalar();
                    object result2 = command2.ExecuteScalar();
                    if (result != null && result2 != null)
                    {
                        string oldbalance = result.ToString();
                        string oldbalance2 = result2.ToString();

                        con2.Close();

                        newbalance = Convert.ToInt32(oldbalance) - Convert.ToInt32(textamount2.Text);
                        newbalance2 = Convert.ToInt32(oldbalance2) + Convert.ToInt32(textamount2.Text);

                        try
                        {
                            Amount5 = textamount2.Text;
                            SqlConnection con = new SqlConnection(connectionString);
                            con.Open();
                            SqlCommand cmd = con.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Bank set Account_Balance= '" + newbalance + "' where Account_No= " + Form29.AccountNumber;
                            cmd.ExecuteNonQuery();

                            SqlCommand cmd2 = con.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "update Bank set Account_Balance= '" + newbalance2 + "' where Account_No= " + Form29.AccountNumber2;
                            cmd2.ExecuteNonQuery();



                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        this.Close();
                        th = new Thread(opennewform);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                }

            }
        
        }

        private void textamount2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar);
            if ((sender as System.Windows.Forms.TextBox).Text.Count(Char.IsDigit) >= 6)

                e.Handled = true;
        }

        private void textamount2_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            textamount2.Clear();
        }
         private void opennewform(object obj)
        {
            Application.Run(new Form32());


        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform1(object obj)
        {
            Application.Run(new Form29());


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform3(object obj)
        {
            Application.Run(new Form1());


        }
    }
}
