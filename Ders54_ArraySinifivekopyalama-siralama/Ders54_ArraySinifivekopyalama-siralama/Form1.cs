using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders54_ArraySinifivekopyalama_siralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //globalde tanımladık
        private string[] dizi = null;  //diziyi globalde tanımladım ki heryerde erişebilelim diye.
        private Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            int elemanSayisi = rnd.Next(6, 15);
            dizi = new string[elemanSayisi];
            for (int i = 0; i < elemanSayisi; i++)
            {
                dizi[i] = "item-" + rnd.Next(100, 999).ToString();
            }
        }

        private void btnDiziKopyala_Click(object sender, EventArgs e)
        {
         

            foreach (string item in dizi)
            {
                listBox1.Items.Add(item);
            }


            string[] dizi2 = (string[])dizi.Clone();//diziyi kopyaladık dizi2 de diziolmuş oldu

           //yukarıdaki ile aşağıdaki aynı şey
            //string[] dizi2 = new string[elemanSayisi];
            //dizi.CopyTo(dizi2, 0); //dizi2 'ye 0.elemandan itibaren dizi1'i kopyaladık.

            listBox2.Items.Clear();

            foreach (string item in dizi2)
            {
                listBox2.Items.Add(item);   
            }

        }

        private void btnSiralamaAZ_Click(object sender, EventArgs e)
        {

            

            Array.Sort(dizi);//diziyi sıralar.

            listBox2.Items.Clear();

            foreach (string item in dizi)
            {
                listBox2.Items.Add(item);
            }
        }

        private void btnSiralaZA_Click(object sender, EventArgs e)
        {
            Array.Sort(dizi);//diziyi sıralar Adan zye 

            Array.Reverse(dizi);//diziyi ters çevirir.yani yukarıda A'dan Z'ye sıralanmış diziyi ters çevirir.bu şekilde z'den a'ya sıralanmış olur.


            listBox2.Items.Clear();

            foreach (string item in dizi)
            {
                listBox2.Items.Add(item);
            }
        }

        private void btnBulma_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (string item in dizi)
            {
                if (item.Contains(textBox1.Text))//textbox1.text içeriyorsa o elemanı listboxa ekle.
                {
                    listBox2.Items.Add(item);
                }
            }
        }
    }
}
