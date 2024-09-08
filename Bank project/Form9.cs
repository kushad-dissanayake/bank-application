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
    public partial class Form9 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");

        public Form9()
           
        {
            InitializeComponent();
        }
       

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Form9_Load(object sender, EventArgs e)
        {
            accnolabel.Text = "Account No : " + Form8.AccNumber;
            namelbl.Text = "Full Name : " +Form8.Fname;



        }
        private void btncorrect_Click(object sender, EventArgs e)
        {
           
        }
        private void btncorrect_Click_1(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform2(object obj)
        {
            Application.Run(new Form12());
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form8());
        }

        private void backbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
