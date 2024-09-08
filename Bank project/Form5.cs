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
    public partial class Form5 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        public Form5()
        {
            InitializeComponent();
        }
       
        private void btnwithdrawal_Click(object sender, EventArgs e)
        {
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form7());


        }

        private void btndiposit_Click(object sender, EventArgs e)
        {
           
        }
        private void opennewform1(object obj)
        {
            Application.Run(new Form8());


        }

        private void btndiposit_Click_1(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnwithdrawal_Click_1(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform3(object obj)
        {
            Application.Run(new Form15());


        }

        private void pinchng_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform4);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform4(object obj)
        {
            Application.Run(new Form17());


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
            Application.Run(new Form21());


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform6);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform6(object obj)
        {
            Application.Run(new Form29());


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform7);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform7(object obj)
        {
            Application.Run(new Form4());


        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
