﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders61_throw_anahtar_sozcugu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bolunen = double.Parse(textBox1.Text);
            double bolen = double.Parse(textBox2.Text);

            double bolum = 0;

            bolum = bolunen / bolen;
         


            if (bolen == 0)
            {
                this.textBox3.Text = "";
                throw new Exception("Bölen sıfır olamaz");//hata fırlattık
            }
            else
            {
                this.textBox3.Text = bolum.ToString("N2");//virgülden sonraki 2 basamak göster(N3 deseydeki virgülden sonraki 3 basamak göstermiş olurduk.)N4 deseydik 4 basamak gösterilirdi
            }
        
        }
    }
}
