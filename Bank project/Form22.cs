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
    public partial class Form22 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Machine Beep - SFX Producer.wav");
        public Form22()
        {
            InitializeComponent();
        }
        public static int Amount;




        string connectionString = "Data Source=DESKTOP-D1TJNIU;Initial Catalog=USERS;Integrated Security=True";
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void guna2Button6_Click(object sender, EventArgs e)
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
        private void opennewform1(object obj)
        {
            Application.Run(new Form20());


        }


        public static int newbalance;
        int newbalance2;
  
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            lblmsg3.Text = "";

            SqlCommand command2 = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con);
            object result2 = command2.ExecuteScalar();

            if (result2 != null)
            {
                string oldbalance2 = result2.ToString();
                newbalance2 = Convert.ToInt32(oldbalance2);

                con.Close();

                if (100 > newbalance2)
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Account balance is insufficient";
                    _soundPlayer2.Play();
                }
                else if (100 > (newbalance2 - 50))
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Cant withdrawal this amount";
                    _soundPlayer2.Play();
                }

                else
                {
                    SqlConnection con2 = new SqlConnection(connectionString);
                    con2.Open();

                    SqlCommand command = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con2);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string oldbalance = result.ToString();

                        con2.Close();


                        newbalance = Convert.ToInt32(oldbalance) - Convert.ToInt32(100);

                        try
                        {

                            SqlConnection con3 = new SqlConnection(connectionString);
                            con3.Open();
                            SqlCommand cmd = con3.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Bank set Account_Balance= '" + newbalance + "' where Account_No= " + Form21.AccNumber;
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Amount = Convert.ToInt32(100);
                        this.Close();
                        th = new Thread(opennewform1);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                }
            }
        }
         
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            lblmsg3.Text = "";

            SqlCommand command2 = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con);
            object result2 = command2.ExecuteScalar();

            if (result2 != null)
            {
                string oldbalance2 = result2.ToString();
                newbalance2 = Convert.ToInt32(oldbalance2);

                con.Close();

                if (500 > newbalance2)
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Account balance is insufficient";
                    _soundPlayer2.Play();
                }
                else if (500 > (newbalance2 - 50))
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Cant withdrawal this amount";
                    _soundPlayer2.Play();
                }

                else
                {
                    SqlConnection con2 = new SqlConnection(connectionString);
                    con2.Open();

                    SqlCommand command = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con2);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string oldbalance = result.ToString();

                        con2.Close();


                        newbalance = Convert.ToInt32(oldbalance) - Convert.ToInt32(500);

                        try
                        {

                            SqlConnection con3 = new SqlConnection(connectionString);
                            con3.Open();
                            SqlCommand cmd = con3.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Bank set Account_Balance= '" + newbalance + "' where Account_No= " + Form21.AccNumber;
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Amount = Convert.ToInt32(500);
                        this.Close();
                        th = new Thread(opennewform4);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                }
            }
           
        }
        private void opennewform4(object obj)
        {
            Application.Run(new Form20());


        }
         

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            lblmsg3.Text = "";

            SqlCommand command2 = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con);
            object result2 = command2.ExecuteScalar();

            if (result2 != null)
            {
                string oldbalance2 = result2.ToString();
                newbalance2 = Convert.ToInt32(oldbalance2);

                con.Close();

                if (1000 > newbalance2)
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Account balance is insufficient";
                    _soundPlayer2.Play();
                }
                else if (1000 > (newbalance2 - 50))
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Cant withdrawal this amount";
                    _soundPlayer2.Play();
                }

                else
                {
                    SqlConnection con2 = new SqlConnection(connectionString);
                    con2.Open();

                    SqlCommand command = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con2);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string oldbalance = result.ToString();

                        con2.Close();


                        newbalance = Convert.ToInt32(oldbalance) - Convert.ToInt32(1000);

                        try
                        {

                            SqlConnection con3 = new SqlConnection(connectionString);
                            con3.Open();
                            SqlCommand cmd = con3.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Bank set Account_Balance= '" + newbalance + "' where Account_No= " + Form21.AccNumber;
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Amount = Convert.ToInt32(1000);
                        this.Close();
                        th = new Thread(opennewform4);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                }
            }
        }
         
        private void btndiposit_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            lblmsg3.Text = "";

            SqlCommand command2 = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con);
            object result2 = command2.ExecuteScalar();

            if (result2 != null)
            {
                string oldbalance2 = result2.ToString();
                newbalance2 = Convert.ToInt32(oldbalance2);

                con.Close();

                if (2000 > newbalance2)
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Account balance is insufficient";
                    _soundPlayer2.Play();
                }
                else if (2000 > (newbalance2 - 50))
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Cant withdrawal this amount";
                    _soundPlayer2.Play();
                }

                else
                {
                    SqlConnection con2 = new SqlConnection(connectionString);
                    con2.Open();

                    SqlCommand command = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con2);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string oldbalance = result.ToString();

                        con2.Close();


                        newbalance = Convert.ToInt32(oldbalance) - Convert.ToInt32(2000);

                        try
                        {

                            SqlConnection con3 = new SqlConnection(connectionString);
                            con3.Open();
                            SqlCommand cmd = con3.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Bank set Account_Balance= '" + newbalance + "' where Account_No= " + Form21.AccNumber;
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Amount = Convert.ToInt32(2000);
                        this.Close();
                        th = new Thread(opennewform4);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                }
            }
        }
        
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            lblmsg3.Text = "";

            SqlCommand command2 = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con);
            object result2 = command2.ExecuteScalar();

            if (result2 != null)
            {
                string oldbalance2 = result2.ToString();
                newbalance2 = Convert.ToInt32(oldbalance2);

                con.Close();

                if (5000 > newbalance2)
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Account balance is insufficient";
                    _soundPlayer2.Play();
                }
                else if (5000 > (newbalance2 - 50))
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Cant withdrawal this amount";
                    _soundPlayer2.Play();
                }

                else
                {
                    SqlConnection con2 = new SqlConnection(connectionString);
                    con2.Open();

                    SqlCommand command = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con2);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string oldbalance = result.ToString();

                        con2.Close();


                        newbalance = Convert.ToInt32(oldbalance) - Convert.ToInt32(5000);

                        try
                        {

                            SqlConnection con3 = new SqlConnection(connectionString);
                            con3.Open();
                            SqlCommand cmd = con3.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Bank set Account_Balance= '" + newbalance + "' where Account_No= " + Form21.AccNumber;
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Amount = Convert.ToInt32(5000);
                        this.Close();
                        th = new Thread(opennewform4);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                }
            }
        }
       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            lblmsg3.Text = "";

            SqlCommand command2 = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con);
            object result2 = command2.ExecuteScalar();

            if (result2 != null)
            {
                string oldbalance2 = result2.ToString();
                newbalance2 = Convert.ToInt32(oldbalance2);

                con.Close();

                if (10000 > newbalance2)
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Account balance is insufficient";
                    _soundPlayer2.Play();
                }
                else if (10000 > (newbalance2 - 50))
                {
                    lblmsg3.ForeColor = System.Drawing.Color.Red;
                    lblmsg3.Text = "Cant withdrawal this amount";
                    _soundPlayer2.Play();
                }

                else
                {
                    SqlConnection con2 = new SqlConnection(connectionString);
                    con2.Open();

                    SqlCommand command = new SqlCommand("SELECT Account_Balance FROM Bank WHERE Account_No=" + Form21.AccNumber, con2);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string oldbalance = result.ToString();

                        con2.Close();


                        newbalance = Convert.ToInt32(oldbalance) - Convert.ToInt32(10000);

                        try
                        {

                            SqlConnection con3 = new SqlConnection(connectionString);
                            con3.Open();
                            SqlCommand cmd = con3.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "update Bank set Account_Balance= '" + newbalance + "' where Account_No= " + Form21.AccNumber;
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        Amount = Convert.ToInt32(10000);
                        this.Close();
                        th = new Thread(opennewform4);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();

                    }
                }
            }
        }
    }
   
}
