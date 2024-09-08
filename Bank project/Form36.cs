using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_project
{
    public partial class Form36 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        public Form36()
        {
            InitializeComponent();
        }

        private void Form36_Load(object sender, EventArgs e)
        {
            lblaccno.Text = "Account No : " + Form35.accno;
            lblcrdno.Text = "Card No : " + Form35.cardno;
            lblfname.Text = "Full Name :  " + Form35.Fname;
            lblbalance.Text = "Account Balance : " + Form35.balance;
            lblpassword.Text = "Password : " + Form35.passward;
            lbltelno.Text = "Telephone No : " + Form35.phoneno;


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
            Application.Run(new Form35());


        }
    }
}
