using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Media;


namespace Bank_project
{
    public partial class Form4 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");
        public Form4()
        {
            InitializeComponent();
        }
        int Count;
        public static string passward;

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btnenter2_Click(object sender, EventArgs e)

             
        {
        
  
        }
        private void opennewform2(object obj)
        {
            Application.Run(new Form1());


        }

        private void opennewform(object obj)
        {
            Application.Run(new Form5());
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
             e.Handled = !char.IsNumber(e.KeyChar);

            if ((sender as TextBox).Text.Count(Char.IsDigit) >=4)

                    e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
             
        }

        private void btnenter2_Click_1(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            Count = Count + 1;
            lblmsg.Text = "";
            if (Count > 3)
            { 
                lblmsg.Text = "";
                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Text = "System has benn block";
                this.Close();
                th = new Thread(opennewform2);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            if (textpin.Text == "")
            {
                _soundPlayer2.Play();
                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Text = "Please enter pin";
            }
            else
            {

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                Console.WriteLine(textpin.GetType());
                int r = Int32.Parse(textpin.Text);
                Console.WriteLine(r);
                con.Close();


                try
                {
                    var user = (from s in db.Banks where s.Passward == r select s).First();

                    if (user.Passward == r)
                    {
                        passward = textpin.Text;
                        this.Close();
                        th = new Thread(opennewform);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                }





                catch


                {
                    
                    lblmsg.ForeColor = System.Drawing.Color.Red;
                    lblmsg.Text = "Invalid pin";
                    textpin.Clear();
                    _soundPlayer2.Play();


                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            textpin.Clear();
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
            Application.Run(new Form1());


        }

        private void lblmsg_Click(object sender, EventArgs e)
        {
            
        }
    }
}
