using System;
using System.Collections;//ArrayList sınıfı için ekledik.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders55_Koleksiyonlar_ArrayList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
           // ArrayList list = new ArrayList(5);//5 item alabilen versiyonu

            //sınırsız item alabilen versiyonu
            ArrayList list = new ArrayList(); //içine her türlü şeyi atabiliriz(obje dizisidir.)obje tipine her türlü değer atabiliyoruz çünkü.

            list.Add(25);
            list.Add("Murat");
            list.Add("Ramazan");
            list.Add(10);

            //foreach (object item in list)  //list'in içinde dolaştık.
            //{
            //    this.listBox1.Items.Add(item.ToString());
            //}


            foreach (object item in list)
            {
                if (item is string)//item string mi diye bakıyoruz yani tip karşılaştırmalarında is kullanıyoruz.
                {
                    listBox1.Items.Add(item);
                }
                else if(item is int )//item int tipinde mi diye bakıyoruz.
                {
                    listBox1.Items.Add("Sayi: "+item.ToString());
                }
                else
                {
                    listBox1.Items.Add(item.ToString());
                }
            }
        }
    }
}
