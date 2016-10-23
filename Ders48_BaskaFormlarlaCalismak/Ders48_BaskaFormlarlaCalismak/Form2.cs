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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Metin { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label2.Text = Metin;
        }
    }
}
