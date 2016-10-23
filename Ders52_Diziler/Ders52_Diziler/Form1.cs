using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders52_Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiziMetin_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//listboxın içindekileri temizle.

            string[] metinDizisi = new string[3];
            metinDizisi[0] = "Murat";
            metinDizisi[1] = "Ramazan";
            metinDizisi[2] = "Ahmet";

            foreach (string metin in metinDizisi)
            {
                listBox1.Items.Add(metin);
            }
            //MessageBox.Show(listBox1.Items[1].ToString());//listbox1.Items objectCollection olduğu için içindeki değeri bu şekildede okuyabiliriz.
        }

        private void btnDiziSayi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] sayiDizisi = new int[4];

            Random rnd = new Random();
            rnd.Next(10, 20);//10 ile 20 arası değer üretir

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                sayiDizisi[i] = rnd.Next(10, 20);//diziye değerleri attık.
            }

            foreach (int sayi in sayiDizisi)//dizi elemanlarını okuduk.ve listboxa attık
            {
                listBox1.Items.Add(sayi.ToString());
            }



        }

        private void btnKisiDizisi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Kisi[] kisiler = new Kisi[3];

            //Kisi k = new Kisi();
            //k.Ad = "Murat";
            //k.Soyad = "Başeren";
            //kisiler[0] = k;
            kisiler[0] = new Kisi() {Ad="Murat",Soyad="Başeren" };//nesne üretip değeri atadık.(yukarıdakinin aynısı aslında)
            kisiler[1] = new Kisi() { Ad = "Ramazan", Soyad = "Aras" };
            kisiler[2] = new Kisi() { Ad = "Ahmet", Soyad = "Korkmaz" };

            foreach (Kisi kisi in kisiler)
            {
                listBox1.Items.Add(kisi.Ad+" "+kisi.Soyad);
            }
        }

        private void btnCokBoyutlu_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[,] adSoyadDizisi = new string[2,3];//iki boyutlu dizi

            adSoyadDizisi[0, 0] = "Murat";
            adSoyadDizisi[1, 0] = "Başeren";
            adSoyadDizisi[0, 1] = "Şükran";
            adSoyadDizisi[1, 1] = "Başeren";
            adSoyadDizisi[0, 2] = "Belinay";
            adSoyadDizisi[1, 2] = "Başeren";

            //Bütün satırlarda dön(y ekseni)
            for (int y = 0; y < 3; y++)
            {
                string adSoyad = string.Empty;//ilk değeri  boş.

                //bütün kolonlarda dön(x ekseni)
                for (int x = 0; x < 2; x++)
                {
                    adSoyad += adSoyadDizisi[x, y]+ " ";
                }

                adSoyad = adSoyad.TrimEnd();//sondaki boşluğu temizle

                listBox1.Items.Add(adSoyad);
            }

           

        }
    }
}
