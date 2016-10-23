using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders59_DosyaIslemleriOkumaYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosyaYaz_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(Application.StartupPath + @"\deneme.txt", txtYazilacakMetin.Text, Encoding.GetEncoding("iso-8859-9"));//Application.StartupPath(debug klasörü)(bu klasörün içine deneme.txt diye bir dosya oluşturur ve  içine txtYazilacak metindeki değerleri yazar.)


        }

        private void btnDosyadanOku_Click(object sender, EventArgs e)
        {

            string metin = System.IO.File.ReadAllText(Application.StartupPath + @"\deneme.txt", Encoding.GetEncoding("iso-8859-9"));//verdiğimiz konumdaki dosyadan tüm yazıyı  okur. ve lblOkunanMetinde gösterir.

            this.lblOkunanMetin.Text = metin;
        }

        private void btnSatirSatirOku_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] satirlar = System.IO.File.ReadAllLines(Application.StartupPath + @"\deneme.txt", Encoding.GetEncoding("iso-8859-9"));//satır satır okuduk string dizisi dönderiyordu bizde string dizisine attık.

            foreach (string satir in satirlar)
            {
                listBox1.Items.Add(satir);
            }
        }
    }
}
