using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_project
{
   
    public partial class Form19 : Form
    {
        Thread th;
        public Form19()
        {
            InitializeComponent();
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
            Application.Run(new Form1());


        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }
    }
}
