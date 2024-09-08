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
    public partial class Form28 : Form
    {
        Thread th;
        SoundPlayer _soundPlayer2 = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Remove Cash 1 - SFX Producer.wav");
        public Form28()
        {
            InitializeComponent();
            _soundPlayer2.Play();
        }

        private void tmrexit_Tick(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form27());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
