using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_project
{
    public partial class Form6 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");
        public Form6(object textpin = null)
        {
            InitializeComponent();
            
        }
        public static string Amount1;

        private void textamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsNumber(e.KeyChar);
            if ((sender as System.Windows.Forms.TextBox).Text.Count(Char.IsDigit) >= 6)

                e.Handled = true;
        }

        private void btnclear2_Click(object sender, EventArgs e)
        {
            
        }
        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btnenter3_Click_2(object sender, EventArgs e)
        {
         

        }

        

        private void Form6_Load(object sender, EventArgs e)
        {
            

         
        }

        private void lblmsg4_Click(object sender, EventArgs e)
        {

        }

        private void textamount_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        public static int newbalance;
        int newbalance2;
        private void btnenter_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            lblmsg3.Text = "";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command2 = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form7.AccountNumber, con);
            object result2 = command2.ExecuteScalar();
            if (result2 != null)
            {
                string oldbalance2 = result2.ToString();
                newbalance2 = Convert.ToInt32(oldbalance2);

                con.Close();

                if (textamount.Text == "")
                {
                    _soundPlayer2.Play();
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Please enter amount";
                }
                else if (Convert.ToInt32(textamount.Text) < 100)
                {                   
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Please enter above 100";
                    textamount.Clear();
                    _soundPlayer2.Play();

                }

                else if ((Convert.ToInt32(textamount.Text) % 100) != 0)
                {                   
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Please enter valid amount";
                    textamount.Clear();
                    _soundPlayer2.Play();
                }
                else if (Convert.ToInt32(textamount.Text) > newbalance2)
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Account balance is insufficient";
                    textamount.Clear();
                    _soundPlayer2.Play();
                }
                else if (Convert.ToInt32(textamount.Text) > (newbalance2 - 50))
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Cant withdrawal this amount";
                    textamount.Clear();
                    _soundPlayer2.Play();
                }
                else

                {
                    SqlConnection con2 = new SqlConnection(connectionString);
                    con2.Open();

                    SqlCommand command = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form7.AccountNumber, con2);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string oldbalance = result.ToString();

                        con2.Close();


                        newbalance = Convert.ToInt32(oldbalance) - Convert.ToInt32(textamount.Text);

                        try
                        {
                           
                            SqlConnection con3 = new SqlConnection(connectionString);
                            con3.Open();
                            SqlCommand cmd = con3.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Bank set Account_Balance= '" + newbalance + "' where Account_No= " + Form7.AccountNumber;
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Amount1 = textamount.Text;
                        this.Close();
                        th = new Thread(opennewform1);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                }
            }
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form20());


        }
        private void opennewform1(object obj)
        {
            Application.Run(new Form28());


        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            textamount.Clear();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform7);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void opennewform7(object obj)
        {
            Application.Run(new Form7());


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform8);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform8(object obj)
        {
            Application.Run(new Form1());


        }
    }
}
