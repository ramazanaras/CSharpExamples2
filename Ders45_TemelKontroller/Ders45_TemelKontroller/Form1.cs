using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders45_TemelKontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = ımageList1.Images[0];//Images koleksiyon olduğu için [] kullandık
        }

       

        
    }
}
