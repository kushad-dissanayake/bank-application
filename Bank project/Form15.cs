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
using System.Xml.Linq;

namespace Bank_project
{
    public partial class Form15 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");
        public Form15()
        {
            InitializeComponent();
        }
        public static string F2name;
        public static string AccountNumber;
        public static string Balance2;


        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form16());


        }

        private void Form15_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void textaccountno_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        private void textaccountno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 10)

                e.Handled = true;
        }

        private void btncorrect_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            lblmsg5.Text = "";
            Console.WriteLine(Form4.passward.GetType());
            long z = Int64.Parse(Form4.passward);
            Console.WriteLine(z);


          

            var user3 = (from s in db.Banks where s.Passward == z select s).First();

            if (textaccountno.Text == "")
            {
                _soundPlayer2.Play();
                lblmsg5.ForeColor = System.Drawing.Color.Red;
                lblmsg5.Text = "Please enter account no";
            }
            else if (user3.Account_No == z)
            {
                lblmsg5.ForeColor = System.Drawing.Color.Red;
                lblmsg5.Text = "Invalid account no";
                textaccountno.Clear();
                _soundPlayer2.Play();

            }
            else
            {

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                Console.WriteLine(textaccountno.GetType());
                long x = Int64.Parse(textaccountno.Text);
                Console.WriteLine(x);
                Console.WriteLine(Form4.passward.GetType());
                int y = Int32.Parse(Form4.passward);
                Console.WriteLine(y);
                con.Close();


                try
                {
                    var user = (from s in db.Banks where s.Account_No == x && s.Passward == y select s).First();

                    if (user.Account_No == x && user.Passward == y)
                    {
                        AccountNumber = textaccountno.Text;
                        SqlConnection con2 = new SqlConnection(connectionString);
                        con2.Open();


                        SqlConnection con3 = new SqlConnection(connectionString);
                        con3.Open();

                        SqlCommand command = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form15.AccountNumber, con3);
                        object result1 = command.ExecuteScalar();
                        if (result1 != null)
                        {
                            string oldbalance = result1.ToString();

                            con3.Close();


                            Balance2 =(oldbalance);

                            SqlCommand command1 = new SqlCommand("SELECT Full_Name FROM Bank WHERE Account_No=" + Form15.AccountNumber, con2);
                            object result = command1.ExecuteScalar();
                            if (result != null)
                            {
                                string name = result.ToString();

                                con2.Close();


                                F2name = name;
                                this.Close();
                                th = new Thread(opennewform);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                        }
                    }
                }





                catch


                {
                    lblmsg5.ForeColor = System.Drawing.Color.Red;
                    lblmsg5.Text = "Invalid account no";
                    textaccountno.Clear();
                    _soundPlayer2.Play();


                }

            }

        }

        private void btnincorrect_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            textaccountno.Clear();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform5(object obj)
        {
            Application.Run(new Form5());


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform6);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform6(object obj)
        {
            Application.Run(new Form1());


        }
    }
}
