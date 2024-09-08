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
    public partial class Form8 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");
        public Form8()
        {
            InitializeComponent();
        }
        public static string AccNumber;
        public static string Balance;
        public static string Fname;

        private void textpin_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }
        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void textaccountno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 10)

                e.Handled = true;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form10());


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
                        AccNumber = textaccountno.Text;
                        SqlConnection con2 = new SqlConnection(connectionString);
                        con2.Open();

                        SqlCommand command = new SqlCommand("SELECT Full_Name FROM Bank WHERE Account_No=" + Form8.AccNumber, con2);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            string name = result.ToString();

                            con2.Close();


                            Fname = name;
                            this.Close();
                            th = new Thread(opennewform);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
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

        private void guna2Button1_Click(object sender, EventArgs e)
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
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
