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
    public partial class Form38 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");
        String username;
        public Form38(String s)
        {
            InitializeComponent();
            username = s;
        }
        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Form38_Load(object sender, EventArgs e)
        {
            if(username == "Customer")
            {
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
            }
            else if(username == "Manager")
            {
                btn1.Enabled = false;
                
            }
            else if (username == "Accountent")
            {
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn4.Enabled = false;
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            lblmsg5.Text = "";
            Console.WriteLine(Form37.passward.GetType());
            long z = Int64.Parse(Form37.passward);
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
                Console.WriteLine(Form37.passward.GetType());
                int y = Int32.Parse(Form37.passward);
                Console.WriteLine(y);
                con.Close();


                try
                {
                    var user = (from s in db.Banks where s.Account_No == x && s.Passward == y select s).First();

                    if (user.Account_No == x && user.Passward == y)
                    {
                        _soundPlayer.Play();
                        SqlConnection con2 = new SqlConnection(connectionString);
                        con2.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Bank Where Account_No ='" + textaccountno.Text +"'", con2);
                        DataTable dtb1 = new DataTable();
                        sqlDa.Fill(dtb1);

                        dgv1.DataSource = dtb1;
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

        private void btn2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Account_No,Crd_NO,Full_Name,Account_Balance,Phone_No  FROM Bank", con);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            dgv1.DataSource = dtb1;
            con.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Account_No, Full_Name,Account_Balance  FROM Bank", con);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            dgv1.DataSource = dtb1;
            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
           
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
            Application.Run(new Form37());

        }

        private void textaccountno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 10)

                e.Handled = true;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textaccountno_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT Accountent_ID, Full_Name,Phone_No  FROM Accountent", con);
            DataTable dtb1 = new DataTable();
            sqlDa.Fill(dtb1);

            dgv1.DataSource = dtb1;
            con.Close();
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            textaccountno.Clear();
        }
    }
}
