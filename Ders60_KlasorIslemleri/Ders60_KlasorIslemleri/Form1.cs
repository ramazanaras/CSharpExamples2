using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders60_KlasorIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDosyalariOKu_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //klasör aç dediğimizde başlangıçta neresi açılsın dedik
           // fbd.RootFolder = Environment.SpecialFolder.Desktop;//fbd.RootFolder bizden Environment.SpecialFolder tipinde bir değer istiyor bizde bu şekilde Environment.SpecialFolder.Desktop verdik.(Not:sari renkli şey yani SpecialFolder bir enumdur.)

            fbd.SelectedPath=@"C:\Users\RAMAZAN\Desktop\murat başeren ornekler"; //bu şekilde ilkte açılan yolu bizde verebiliriz.

            if (fbd.ShowDialog()==DialogResult.OK)
            {

                this.listBox1.Items.Clear();



             //   string[] dosyalar = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.jpg");//sadece sonu .jpg ile biten dosyaların konumunu getir diyoruz. //C:\deneme\abc.jpg şeklinde 


                string[] dosyalar = System.IO.Directory.GetFiles(fbd.SelectedPath);//seçilen klasörün yolunu(fbd.selectedPath) ile verdik.GetFiles ile klasör içindeki dosyaların konumu aldık.dosyalar dizisinde dosyaların konumları var.aşağıdada FileInfo ile dosyanın sadece adını alabiliriz.

                //GetFiles ile aşağıdaki gibi
                //C:\deneme\abc.txt
                //D:\windows\files\test.docx gibi dosyaların tam konumlarını almış oluyoruz
                foreach (string dosyaKonumu in dosyalar)
                {
                    // MessageBox.Show(dosyaKonumu.ToString()); dosyanın tam konumunu okuyoruz.

                    System.IO.FileInfo fi = new System.IO.FileInfo(dosyaKonumu);//FileInfo   dosya bilgilerini bize verir.(sadece ismini alabiliriz dosyanın)
                    listBox1.Items.Add(fi.Name);//dosyanın adını ekler sadece .
                    fi = null;//ramden silme işlemi yapıyoruz.sistem kaynaklarını kurtarmak adına //yapamasakta olurdu.yapınca ramde boş yer açıyoruz.
                }

            }
            else
            {
                MessageBox.Show("Klasör seçmediniz..");
            }


        }
    }
}
