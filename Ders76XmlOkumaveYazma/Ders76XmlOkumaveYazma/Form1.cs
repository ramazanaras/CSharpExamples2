using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;//Xml için bu namespace'i kullanıyoruz
namespace Ders76XmlOkumaveYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //XML İLE BASİT BİR AYAR DOSYASI YAPIMI YAPTIK 

        //Application.StartupPath(debug klasörünün yoludur)
        private string path = Application.StartupPath + @"\ayarlar.xml";//path:debug klasörünün içerisindeki ayarlar.xml dosyasının yolu olmuş oluyor
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string baslik = this.txtProgramBasligi.Text;
            int width = (int)this.nudWidth.Value;
            int height =(int)this.nudHeight.Value;

            /*
             
             <ayarlar>
             <baslik>baslik</baslik> 
             <width>100</width>
             <heighht>120</height>
             </ayarlar>
             
             
             */


            //temel sınıfımızı oluşturduk 
            XmlDocument xdoc = new XmlDocument();

            XmlElement xAyarlar = xdoc.CreateElement("ayarlar");//ayarlar elementi oluşturduk

            XmlElement xBaslik = xdoc.CreateElement("baslik");//baslik elementi oluşturduk
            xBaslik.InnerText = baslik;//elementin içine değeri yazdık

            XmlElement xWidth = xdoc.CreateElement("width");//width elementi oluşturduk
            xWidth.InnerText = width.ToString();//elementin içine değeri yazdık


            XmlElement xHeight = xdoc.CreateElement("height");//height elementi oluşturduk
            xHeight.InnerText = height.ToString();//elementin içine değeri yazdık

            //ayarlar(ana element)  elementin içine diğer elementleri ekliyoruz.(AppendChild=cocuk eklemek gibi birrşey.)
            xAyarlar.AppendChild(xBaslik);
            xAyarlar.AppendChild(xWidth);
            xAyarlar.AppendChild(xHeight);



            xdoc.AppendChild(xAyarlar);//ayarlarıda(ana elementide) doc'a ekleme yaptık.
            xdoc.Save(path);//verdiğimiz dosya yoluna xml dosyasını oluşturacak.

            Application.Restart();//programın yeniden başlamasını sağlıyoruz.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();

            xdoc.Load(path);//xdoc nesnesine verdiğimiz path'deki xml dosyasını okuyor ve xdoc nesnesine bilgileri aktarıyor.


            //XmlNode xBaslik = xdoc.GetElementsByTagName("baslik")[0];//GetElementsByTagName geriye  XmlNodeList' dönderir.yani içinde XmlNode'lar bulunan liste dönderir.bizde ilk baslik elementini almak için sonuna [0] yazdıkki ilk baslik elementini alalım diye.

            //string baslik = xBaslik.InnerText;//elementin içindeki yazıyı okuduk ve baslik değerine aktardık.


            //yukarıdaki gibide yapabilirdik ama aşağıdaki daha kısa hali.
            string baslik = xdoc.GetElementsByTagName("baslik")[0].InnerText;


            XmlNode xWidth = xdoc.GetElementsByTagName("width")[0];
            int width = int.Parse(xWidth.InnerText);


            XmlNode xHeight = xdoc.GetElementsByTagName("height")[0];
            int height = int.Parse(xHeight.InnerText);



            this.Text = baslik;//formun başlığını değiştirdik
            this.Width = width;
            this.Height = height;

            
        }
    }
}
