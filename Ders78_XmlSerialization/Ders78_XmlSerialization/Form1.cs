using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ders78_XmlSerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Serialize nesneyi xml 'e veya farklı formata dönüştürmedir.
            //deserialize xml'den veya başka bir formattan nesneye dönmedir.
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            System.Xml.Serialization.XmlSerializer serialize = new System.Xml.Serialization.XmlSerializer(typeof(Kisi));//tipi verdik.//Kisi sınıfının tipini verdik o da sınıf tipinde 

            //Kisi nesnesi oluşturduk
            Kisi k = new Kisi
            {
                Id = 1,
                Ad = "Ramazan",
                Soyad = "Aras",
                TcNo = 1231,
                DogumTarihi = DateTime.Now


            };

            //xmlwriter verdiğimiz konuma(debug klasörünün içine) data.xml dosyayasını oluşturacak
            XmlWriter writer = XmlWriter.Create(Application.StartupPath + @"\data.xml");//


            //k nesnesini xml'e çevirdik.
            serialize.Serialize(writer, k);//ilk parametre Xwriter nesnesi istiyordu verdik,//2.parametrede bizden nesne istiyordu bizde k nesnesini verdik.

            writer.Close();//writer'ı kapatmamız lazım.
            writer.Dispose();//nesneyi ramden kaldırdık.ramde yer açtık.
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Kisi));//tipi verdik.//Kisi sınıfının tipini verdik o da sınıf tipinde //aşağıdaki deserialize işleminde hangi nesneye çevireceğini söylemiş oluyoruz  aslında

            XmlReader reader = XmlReader.Create(Application.StartupPath + @"\data.xml");


            //xml'den Kisi nesnesini elde etmiş olduk
            object obj = serializer.Deserialize(reader);//vermiş olduğumuz dosya yolundaki xml'i oku ve deserialize et yani nesneye çevir.//Deserialize geriye obje dönderir Kisi sınıfı tipinde bir nesne dönderir aşağıdada cast ettik zaten.

            reader.Close();//reader'ı kapatmamız lazım.
            reader.Dispose();//nesneyi ramden kaldırdık.ramde yer açtık.

            Kisi k = (Kisi)obj;//cast ettik.

            MessageBox.Show(string.Format("Id: {0},Ad: {1},Soyad:{2},TcNo:{3},DogumTarihi:{4}", k.Id, k.Ad, k.Soyad, k.TcNo, k.DogumTarihi.ToShortDateString()));
        }

        private void btnSerialize2_Click(object sender, EventArgs e)
        {
            //Kisi nesnesi oluşturduk
            Kisi k = new Kisi
            {
                Id = 2,
                Ad = "Ahmet",
                Soyad = "Korkmaz",
                TcNo = 22111,
                DogumTarihi = DateTime.Now.AddDays(1)


            };

            //kendi sınıfımızı kullanarak uzun kodlardan kurtulduk
            MyXmlSerializer serializer = new MyXmlSerializer();
            serializer.Serialize(Application.StartupPath + @"\data2.xml", k);//verdiğimiz nesneyi xml 'e dönüştürdük




        }

        private void btnDeserialize2_Click(object sender, EventArgs e)
        {
            //kendi sınıfımızı kullanarak uzun kodlardan kurtulduk
            MyXmlSerializer serializer = new MyXmlSerializer();
            //xml'i tekrar nesneye çeviriyoruz
            object obj = serializer.Deserialize(Application.StartupPath + @"\data2.xml", typeof(Kisi));//hangi tipte nesne alacağını belirtmek içinde typeof(Kisi) dedik typeof(Kisi) Type tipindedir.

            Kisi k = (Kisi)obj;
            MessageBox.Show(k.Id.ToString()+" "+k.Ad+" "+k.Soyad+" "+k.TcNo.ToString());
        }


        //kendi sınıfımızdaki overload metotlarını kullanarak yaptığımız işlemler
        private void btnSerialize3_Click(object sender, EventArgs e)
        {
            //kendi sınıfımızı kullanarak uzun kodlardan kurtulduk
            MyXmlSerializer serializer = new MyXmlSerializer();


            //Kisi nesnesi oluşturduk
            Kisi k = new Kisi
            {
                Id = 3,
                Ad = "Mehmet",
                Soyad = "yılmaz",
                TcNo = 551,
                DogumTarihi = DateTime.Now.AddDays(1)


            };
            //Kisi nesnesini  xml 'e çevirir.
            serializer.Serialize<Kisi>(Application.StartupPath + @"\data3.xml", k);

        }

        private void btnDeserialize3_Click(object sender, EventArgs e)
        {
            //kendi sınıfımızı kullanarak uzun kodlardan kurtulduk
            MyXmlSerializer serializer = new MyXmlSerializer();

            Kisi k = serializer.Deserialize<Kisi>(Application.StartupPath + @"\data3.xml");//verilen path'deki xml dosyasını Kisi nesnesine dönüştürdük.

            MessageBox.Show(k.Id.ToString() + " " + k.Ad + " " + k.Soyad + " " + k.TcNo.ToString());

        }
    }
}
