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
    public partial class Form30 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");

        public Form30()
        {
            InitializeComponent();
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            sendrlabl.Text = "Credit sender account number  :  " + Form29.AccountNumber;
            recvrlabl.Text = "Credit receiver account number  :  " + Form29.AccountNumber2;
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
            Application.Run(new Form31());
 
        }

        private void btncorrect_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form29());

        }
    }
}
