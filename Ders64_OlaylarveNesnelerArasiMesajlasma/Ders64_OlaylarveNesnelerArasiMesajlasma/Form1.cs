using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders64_OlaylarveNesnelerArasiMesajlasma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //temsilci tanımladık.
        private delegate void MetinYazHandler();

        //olay tanımlıyoruz//önce event yazıyoruz daha sonra bu olayın gideceği  delegate'i(MetinYazHandlerı) yazıyoruz daha sonra olayın adını(MetinYazildi) yazıyoruz
        private event MetinYazHandler MetinYazildi;


        private void Form1_Load(object sender, EventArgs e)
        {
            MetinYazildi += Form1_MetinYazildi; //olayımızı yakalama satırı //MetinYazildi olayının hangi metoda(Form1_MetinYazildi)  gideceğini yazdık.
        }

        void Form1_MetinYazildi()
        {
            MessageBox.Show("Metin yazıldı");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MetinYazildi(); //kendi yazdığımız olayı çağırdık//MetinYazildi olayını fırlat dedik.
        }





        //aslında checheckedchanged olayı bir temsilciye bağlı ve o temsilci çağırılıyor
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //çalışacak kodlar
        }

        

      


    }
}
