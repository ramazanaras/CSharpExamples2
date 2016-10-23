using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders67_Dictionary_koleksiyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //anahtar ve değer(anahtarı int tipinde ,değeride string tipinde yaptık)
            Dictionary<int, string> sayilarinAdlari = new Dictionary<int, string>();
            sayilarinAdlari.Add(0, "sıfır");
            sayilarinAdlari.Add(1, "bir");
            sayilarinAdlari.Add(2, "iki");

            string deger = (string)sayilarinAdlari[2];//değeri okumak için //objeyi stringe cast ettik.
            MessageBox.Show(deger);//iki değerini dönderir.

        }
    }
}
