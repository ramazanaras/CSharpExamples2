using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders63_Temsilciler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //TEMSİLCİLER
        //metotları temsil eden değişken tipi diyebiliriz
        /*
       Bir sayıyı taşımak için değişken kullanabiliyoruz. Peki ya metotu taşımak istersek?
      İnşatteki Kum çimento tuğla elemanları taşıyan Field ise 
       Kepçe Vinç Dozer taşıyan ve çalıştıran Delegate dir.
         
       */
     

        //delegate yazıyoruz  daha sonra geriye dönüş tipini yazıyoruz ve bir isim veriyoruz
        private delegate void MetotTemsilcimHandler(string s);//genelde isimlendirmede sonuna Handler konur//koymasakta olur ama genelde bu şekilde kullanılıyor.


        private void Metodum(string text)
        {

            MessageBox.Show(text);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MetotTemsilcimHandler temsilci = Metodum;//temsilciye Metodum metodunu atadık.

            temsilci("Metodum metodu çalıştı.");//bunu çağırınca aslında Metodum() metodunu çalıştırır.yani temsilci aslında Metodum metodunu temsil ediyor.
            



        }
        //================================================

        //delegate tanımlıyoruz//delegate 'de bir tiptir.
        private delegate void MetinYazHandler(string s);

        private MetinYazHandler MetinYazTemsilcisi;



        private void MetniYaz(string text)
        {
  
                this.label1.Text =text;
        }
        private void MetniYaz2(string text)
        {

            this.label1.Text ="nocheck-"+ text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MetinYazTemsilcisi = MetniYaz;

            //if (checkBox1.Checked==true)
            //{
            //    MetinYazTemsilcisi(this.textBox1.Text);
            //}
            //else
            //{
            //    MetinYazTemsilcisi("nocheck-"+this.textBox1.Text);
            //}


            //--------------------yukarıdaki işlemleri yapmak yerine checkBox1_CheckedChanged 'da işlemleri daha düzenli bir şekilde yaptık.

            MetinYazTemsilcisi(this.textBox1.Text);

          
        }

        //checkbox değiştiğinde
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked==true)//check edilmişsse
            {
                MetinYazTemsilcisi = MetniYaz;//metodu atadık
            }
            else//check edilmemişse
            {
                MetinYazTemsilcisi = MetniYaz2;//metodu atadık
            }
        }

    }
}
