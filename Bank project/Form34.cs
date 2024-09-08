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
    public partial class Form34 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        public Form34()
        {
            InitializeComponent();
        }

        private void Form34_Load(object sender, EventArgs e)
        {
            acclbl1.Text = "CREDIT SENDER ACCOUNT NO :    " + Form29.AccountNumber;
            acclbl2.Text = "CREDIT RECEIVER ACCOUNT NO :    " + Form29.AccountNumber2;
            accballbl.Text = "TRANSFER AMOUNT :    " + Form31.Amount5;
            datelbl.Text = DateTime.Now.ToShortDateString();
            string currentTimeLabel = DateTime.Now.ToString("t");
            timelbl.Text = currentTimeLabel;
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start(); 
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form1());

        }
    }
}
