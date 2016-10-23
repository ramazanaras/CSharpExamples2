using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders47_TimerKontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)//her saniye çalışan kod.
        {
            //interval=1000 milisaniye =1 sn 

            label1.Text = DateTime.Now.TimeOfDay.Hours.ToString() + ":" + DateTime.Now.TimeOfDay.Minutes.ToString() + ":" + DateTime.Now.TimeOfDay.Seconds.ToString();

        }
    }
}
