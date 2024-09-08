using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
 
using System.Drawing.Text;
using Timer = System.Windows.Forms.Timer;

namespace Bank_project
{
    
    public partial class Form1 : Form
    {
        Thread th;

        SoundPlayer player = new SoundPlayer();

        SoundPlayer _soundPlayer = new SoundPlayer(@"E:\Banking System (CW)\ES_ATM Beep - SFX Producer.wav");

        public Form1()
        {
            player.SoundLocation = "My Video.wav";
            player.PlayLooping();
            InitializeComponent();
            this.BackgroundImage = Properties.Resources._012;
            Timer tm = new Timer();
            tm.Tick += new EventHandler(changeImage);
            tm.Interval = 1000;
            tm.Start();
        }
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources._012);
            b1.Add(Properties.Resources._011);
            b1.Add(Properties.Resources._010);
            b1.Add(Properties.Resources._009);
            b1.Add(Properties.Resources._008);
            b1.Add(Properties.Resources._007);
            int index = DateTime.Now.Second % b1.Count;
            this.BackgroundImage=b1[index];
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            
         
        }

        private void opennewform(object obj)
        {
            Application.Run(new Form3());

        }
        
        private void btnenter_Click_1(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform1(object obj)
        {
            Application.Run(new Form35());

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            this.Close();
            th = new Thread(opennewform4);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform4(object obj)
        {
            Application.Run(new Form37());

        }
    }
}
 