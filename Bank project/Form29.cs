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
    public partial class Form29 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");

        public Form29()
        {
            InitializeComponent();
        }
        public static string AccountNumber;
        public static string AccountNumber2;

        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";
        DataClasses1DataContext db = new DataClasses1DataContext();


        private void btncorrect_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            lblmsg.Text = "";
            lblmsg2.Text = "";

            if (textaccountno.Text == "" && textaccountno2.Text == "")
            {
                _soundPlayer2.Play();
                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Text = "Empty";
                lblmsg2.ForeColor = System.Drawing.Color.Red;
                lblmsg2.Text = "Empty";

            }
            else if (textaccountno.Text == "" && textaccountno2.Text != "")
            {
                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Text = "Empty";
                textaccountno2.Clear();
                _soundPlayer2.Play();
            }
            else if (textaccountno.Text != "" && textaccountno2.Text == "")
            {
                lblmsg2.ForeColor = System.Drawing.Color.Red;
                lblmsg2.Text = "Empty";
                textaccountno.Clear();
                _soundPlayer2.Play();

            }
            else if (textaccountno.Text == textaccountno2.Text)
            {
                lblmsg3.ForeColor = System.Drawing.Color.Red;
                lblmsg3.Text = "Cant procede this transaction";
                textaccountno.Clear();
                textaccountno2.Clear();
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
                Console.WriteLine(textaccountno2.GetType());
                long z = Int64.Parse(textaccountno2.Text);
                Console.WriteLine(z);


                try
                {
                    var user = (from s in db.Banks where s.Account_No == x && s.Passward == y select s ).First();

                    if (user.Account_No == x && user.Passward == y)
                    {
                        try
                        {
                            var user2 =(from s in db.Banks where s.Account_No == z select s).First();
                            if (user2.Account_No == z)
                            {


                                AccountNumber = textaccountno.Text;
                                AccountNumber2 = textaccountno2.Text;
                                SqlConnection con2 = new SqlConnection(connectionString);
                                con2.Open();


                                this.Close();
                                th = new Thread(opennewform);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                            }
                        }
                        catch
                        {
                            lblmsg2.ForeColor = System.Drawing.Color.Red;
                            lblmsg2.Text = "Invalid account";
                            textaccountno2.Clear();
                            _soundPlayer2.Play();
                        }
                        
                    }


                }

                catch


                {
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                    lblmsg.Text = "Invalid account";
                    textaccountno.Clear();
                    _soundPlayer2.Play();


                }

            }
        }

        private void Form29_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void textaccountno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 10)

                e.Handled = true;
        }

        private void textaccountno2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 10)

                e.Handled = true;
        }

        private void btnincorrect_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            textaccountno.Clear();
            textaccountno2.Clear();
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
        private void opennewform(object obj)
        {
            Application.Run(new Form30());


        }

        private void textaccountno_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        private void textaccountno2_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform7);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform7(object obj)
        {
            Application.Run(new Form1());


        }
    }
}
