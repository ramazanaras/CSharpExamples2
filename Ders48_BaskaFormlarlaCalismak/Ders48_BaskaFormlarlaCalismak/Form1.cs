using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders48_BaskaFormlarlaCalismak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = this.textBox1.Text;

            Form2 frm2 = new Form2();
            frm2.label1.Text = metin;
            frm2.Metin = metin;//form2deki Metin değişkenine değeri yolladık. 
            frm2.Show();
        }
    }
}
