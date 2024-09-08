using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace Bank_project
{
    public partial class Form12 : Form
    {

        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");
        public Form12()

        {
            InitializeComponent();
        }
        public static string Amount5;

        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";

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
        private void opennewform(object obj)
        {
            Application.Run(new Form11());


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            textamount2.Clear();
        }



        public static int newbalance;

        private void btnenter2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            lblmsg2.Text = "";

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
          
            else

            {
                SqlConnection con2 = new SqlConnection(connectionString);
                con2.Open();

                SqlCommand command = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form8.AccNumber, con2);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    string oldbalance = result.ToString();

                    con2.Close();


                    newbalance = Convert.ToInt32(oldbalance) + Convert.ToInt32(textamount2.Text);

                    try
                    {
                        Amount5 = textamount2.Text;
                        SqlConnection con = new SqlConnection(connectionString);
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update Bank set Account_Balance= '" + newbalance + "' where Account_No= " + Form8.AccNumber;
                        cmd.ExecuteNonQuery();
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



        private void Form12_Load(object sender, EventArgs e)

        {
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform9);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform9(object obj)
        {
            Application.Run(new Form8());


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform5(object obj)
        {
            Application.Run(new Form1());


        }

    }

}
