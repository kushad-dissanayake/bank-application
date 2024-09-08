using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Media;
using System.Xml.Linq;

namespace Bank_project
{
    public partial class Form35 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");
        public Form35()
        {
            InitializeComponent();
            textbalance.Text = "0";
        }
        public static string accno;
        public static string cardno;
        public static string Fname;
        public static string balance;
        public static string passward;
        public static string phoneno;
        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";
        DataClasses1DataContext db = new DataClasses1DataContext();

        public void GetAccountno()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string accno;
            string query = "select Account_No from Bank order by Account_No Desc";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                int i = int.Parse(reader[0].ToString())+1;
                accno = i.ToString("0000000000");
            }
            else if(Convert.IsDBNull(reader))
            {
                accno = ("9999999999");
            }
            else
            {
                accno = ("9999999999");
            }
           textaccno.Text = accno.ToString();
            con.Close();
        }
        public void GetCardno()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string cardno;
            string query = "select Crd_No from Bank order by Crd_No Desc";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int i = int.Parse(reader[0].ToString()) + 1;
                cardno = i.ToString("000000000");
            }
            else if (Convert.IsDBNull(reader))
            {
                cardno = ("999999999");
            }
            else
            {
                cardno = ("999999999");
            }
            textcrdno.Text = cardno.ToString();
            con.Close();
        }

        public void GetPassward()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string passward;
            string query = "select Passward from Bank order by Passward Desc";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int i = int.Parse(reader[0].ToString()) + 4;
                passward = i.ToString("0000");
            }
            else if (Convert.IsDBNull(reader))
            {
                passward = ("9999");
            }
            else
            {
                passward = ("9999");
            }
            textpaswrd.Text = passward.ToString();
            con.Close ();
        }
        private void Form35_Load(object sender, EventArgs e)
        {
            GetAccountno();
            GetCardno();
            GetPassward();
            textaccno.ReadOnly = true;
            textcrdno.ReadOnly = true;
            textpaswrd.ReadOnly = true;
            textbalance.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            textname.Text = textInfo.ToTitleCase(textname.Text);
            textname.SelectionStart = textname.Text.Length;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && ! char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textphoneno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 10)

                e.Handled = true;
        }

        private void textpaswrd_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            int bal = 0;
            lblmsg.Text = "";
            lblmsg2.Text = "";
            lblmsg3.Text = "";
            if(textname.Text == "" && textphoneno == null)
            {
                _soundPlayer2.Play();
                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Text = "Empty";
                lblmsg2.ForeColor = System.Drawing.Color.Red;
                lblmsg2.Text = "Empty";
            }
            else if (textname.Text == "")
            {
               
                lblmsg2.ForeColor = System.Drawing.Color.Red;
                lblmsg2.Text = "Empty";
                _soundPlayer2.Play();
            }
            else if(textphoneno.Text == "")
            {
                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Text = "Empty";
                _soundPlayer2.Play();
            }
            else if(Convert.ToInt64(textphoneno.Text) <= 999999999)
            {
                lblmsg3.ForeColor = System.Drawing.Color.Red;
                lblmsg3.Text = "Less than 10 digit";
                textphoneno.Clear();
                _soundPlayer2.Play();
            }
            else 
            {
                try
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    string query = "insert into Bank values('" + textaccno.Text + "','" + textcrdno.Text + "','" + textname.Text + "','" + bal + "','" + textpaswrd.Text + "','" + Convert.ToInt64(textphoneno.Text) + "')";
                    SqlCommand cmd =new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    accno = textaccno.Text;
                    cardno = textcrdno.Text;
                    Fname = textname.Text;
                    balance = textbalance.Text;
                    passward = textpaswrd.Text;
                    phoneno = textphoneno.Text;
  
                    con.Close();
                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();


                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form36());


        }

        private void textname_Leave(object sender, EventArgs e)
        {

            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            lblmsg2.Text = "";
            lblmsg3.Text = "";
            _soundPlayer.Play();
            textname.Clear();
            textphoneno.Clear();
        }

        private void textphoneno_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
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
    }
}
