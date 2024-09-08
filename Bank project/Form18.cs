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
    public partial class Form18 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");
        public Form18()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";

        private void enterpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 4)

                e.Handled = true;
        }

        private void cnfrmpin_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

            if ((sender as TextBox).Text.Count(Char.IsDigit) >= 4)

                e.Handled = true;
        }

        private void Form18_Load(object sender, EventArgs e)
        {

            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form5());


        }

        private void btnenter2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            lblmsg.Text = "";
            lblmsg2.Text = "";
            lblmsg3.Text = "";

            if (enterpin.Text == "" && cnfrmpin.Text == "")
            {
                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Text = "Empty";
                lblmsg2.ForeColor = System.Drawing.Color.Red;
                lblmsg2.Text = "Empty";
                _soundPlayer2.Play();



            }
             
            else if (enterpin.Text == "" && cnfrmpin.Text != "")
            {
                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Text = "Empty";
                cnfrmpin.Clear();
                _soundPlayer2.Play();



            }
            else if (enterpin.Text != "" && cnfrmpin.Text == "")
            {
                lblmsg2.ForeColor = System.Drawing.Color.Red;
                lblmsg2.Text = "Empty";
                enterpin.Clear();
                _soundPlayer2.Play();

            }
            else if (enterpin.Text != cnfrmpin.Text)
            {
                lblmsg3.ForeColor = System.Drawing.Color.Red;
                lblmsg3.Text = "Pin Number not match";
                enterpin.Clear();
                cnfrmpin.Clear();
                _soundPlayer2.Play();


            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Bank set Passward= '" + enterpin.Text + "' where Account_No= " + Form17.AccountNumber2;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    this.Close();
                    th = new Thread(opennewform1);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();



                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



        }
        private void opennewform1(object obj)
        {
            Application.Run(new Form19());


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            enterpin.Clear();
            cnfrmpin.Clear();
        }

        private void enterpin_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        private void cnfrmpin_TextChanged(object sender, EventArgs e)
        {
            _soundPlayer.Play();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
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
