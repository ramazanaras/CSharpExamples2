using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders58_Dosya_Klasörİslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnKlasorOlustur_Click(object sender, EventArgs e)
        {
            //başına System.IO yazmak yerine yukarıda using  System.IO;'da yazabilirdik.
            System.IO.Directory.CreateDirectory(Application.StartupPath + @"\yeni_klasor");//uygulamanın yoluna(Application.StartupPath bu yol debug klasörü oluyor ) bu klasörü oluştur diyoruz.(Debug klasörünün içine oluşturur.)

            if (System.IO.Directory.Exists(Application.StartupPath + @"\yeni_klasor"))//bu konumda bir klasör var mı 
            {
                MessageBox.Show("Klasörünüz oluşturuldu");
            }
            else
            {
                MessageBox.Show("Klasörünüz oluşturulamadı");
            }

        }

        private void btnDosyaOlustur_Click(object sender, EventArgs e)
        {

         System.IO.FileStream fs = System.IO.File.Create(Application.StartupPath + @"\yeni_klasor\deneme.txt");//yeni klasörün altına deneme.txt oluşturur.
          fs.Dispose();  //bu işlemi bıraktık yani dosyayı oluştursun ama dosya üzerinde artık bir işlem yapmasın yani biz dosyayı program çalışırken de silebilelim .(bize Dosya.vshtos açık olduğunda bu işlem(silme işlemimiz )gerçekleşemiyor hatası vermesin diye yapıyoruz.yani nesneyi(fs'yi) serbest bıraktık.)artık program çalışırkende deneme.txt'yi silebiliriz.yani sadece yukarıdaki işlemi yapsın daha sonra başka işlem yapmasın diye.nesneyi(fsyi bıraktık.)



           //System.IO.File.Create(Application.StartupPath + @"\yeni_klasor\deneme.txt");//yeni klasörün altına deneme.txt oluşturur.

            if (System.IO.File.Exists(Application.StartupPath + @"\yeni_klasor\deneme.txt"))//bu konumda bir dosya varmı
            {
                MessageBox.Show("Dosya oluşturuldu");
            }
            else
            {
                MessageBox.Show("Dosya oluşturulamadı");
            }
        }
    }
}
