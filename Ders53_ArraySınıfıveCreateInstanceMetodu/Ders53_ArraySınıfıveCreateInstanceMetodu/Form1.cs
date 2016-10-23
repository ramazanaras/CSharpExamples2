using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders53_ArraySınıfıveCreateInstanceMetodu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


         

            //string[] metinler = new string[3];
         //   Array.CreateInstance(typeof(string), 3);//3 elemanlı dizi (yukarıdakinin aynısı)


            int[] sayilar = (int[])Array.CreateInstance(typeof(int), 6);//cast ettik.(CreateInstance Array tipinde değer dönderir bizde onu int[] 'e cast ettik.)

            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(100, 999);
            }

            foreach (int sayi in sayilar)
            {
                listBox1.Items.Add(sayi.ToString());
            }


        }

        private void btnRuntime_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //Dışardan tip alarak oluşturduğumuz dizi mantığı 
            Type tip = Type.GetType("System.String");//string tipi oluşturduk(biz dışardan girerekte bir tip oluşturabilirdik.(çalışma zamanında))

            Array dizi = Array.CreateInstance(tip, 6);//6 boyutlu dizi(string dizisi)

            Random rnd=new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi.SetValue("item-" + rnd.Next(100, 999).ToString(), i);//diziye değerleri atamış oluyoruz.(sırayla)
                
            }

            foreach (object item in dizi)//dizi çalışma anında oluşacağı için tipini bilmediğimizden içinde object var diye düşünüyoruz 
            {
                listBox1.Items.Add(item.ToString());
            }
          
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] sayilar = (int[])Array.CreateInstance(typeof(int), 6);//cast ettik.(CreateInstance Array tipinde değer dönderir bizde onu int[] 'e cast ettik.)

            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(100, 999);
            }

            int[] sayilar2 = (int[])sayilar.Clone();//sayilar.Clone object döndüğü için bizde int[]'e  cast ettik.//diziyi klonladı.

            foreach (int sayi in sayilar)
            {
                listBox1.Items.Add(sayi.ToString());
            }

            foreach (int sayi in sayilar2)
            {
                listBox2.Items.Add(sayi.ToString());
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] sayilar = (int[])Array.CreateInstance(typeof(int), 6);//cast ettik.(CreateInstance Array tipinde değer dönderir bizde onu int[] 'e cast ettik.)

            Random rnd = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(100, 999);
            }

            int[] sayilar2 = new int[6];
            sayilar.CopyTo(sayilar2, 0);//0.index'ten itibaren kopyalar.

            foreach (int sayi in sayilar)
            {
                listBox1.Items.Add(sayi.ToString());
            }

            foreach (int sayi in sayilar2)
            {
                listBox2.Items.Add(sayi.ToString());
            }
        }
    }
}
