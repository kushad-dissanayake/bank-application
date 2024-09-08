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
   
    public partial class Form33 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");
        public Form33()
        {
            InitializeComponent();
        }

        private void btnno_Click(object sender, EventArgs e)
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

        private void btnyes_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform2(object obj)
        {
            Application.Run(new Form34());

        }

    }
}
