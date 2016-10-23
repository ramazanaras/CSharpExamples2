using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ders78_XmlSerialization
{
    //KENDİ SINIFIMIZI YAZDIK
    public class MyXmlSerializer
    {
        public void Serialize(string path,object obj) 
        {
            System.Xml.Serialization.XmlSerializer serialize = new System.Xml.Serialization.XmlSerializer(obj.GetType());//obj'nin GetType ile hangi sınıf tipinde olduğu alabiliyoruz.

          

            //xmlwriter verdiğimiz konuma xml dosyayasını oluşturacak
            XmlWriter writer = XmlWriter.Create(path);//


            //obj nesnesini xml'e çevirdik.
            serialize.Serialize(writer, obj);//ilk parametre Xwriter nesnesi istiyordu verdik,//2.parametrede bizden nesne istiyordu bizde obj nesnesini verdik.

            writer.Close();//writer'ı kapatmamız lazım.
            writer.Dispose();//nesneyi ramden kaldırdık.ramde yer açtık.
        
        }




        public object Deserialize(string path,Type type) //nesne dönderen metot
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(type);//tipi verdik.aşağıdaki deserialize işleminde hangi nesneye çevireceğini söylemiş oluyoruz  aslında//XmlSerializer bizden type istiyordu bizden bir tip verdik ona 

            XmlReader reader = XmlReader.Create(path);


            //xml'den gelen tipteki  nesneye dönüşüm işlemi yapıyoruz
            object obj = serializer.Deserialize(reader);//vermiş olduğumuz dosya yolundaki xml'i oku ve deserialize et yani nesneye çevir.//Deserialize geriye obje dönderir gelen tipteki sınıfın tipinde bir nesne dönderir aşağıdada cast ettik zaten.

            reader.Close();//reader'ı kapatmamız lazım.
            reader.Dispose();//nesneyi ramden kaldırdık.ramde yer açtık.

            return obj;//objeyi geri dönderdik.
        }
      
        
        //=============================================================
        //===================OVERLOAD METOTLARINI YAPTIK (generic metot yazdık)

        public void Serialize<T>(string path,T obj)//generic metot yaptık
        {
            System.Xml.Serialization.XmlSerializer serialize = new System.Xml.Serialization.XmlSerializer(typeof(T));//gelen T'nin yani tipin hangi tipte olduğunu söylüyoruz.mesela sınıf tipinde



            //xmlwriter verdiğimiz konuma xml dosyayasını oluşturacak
            XmlWriter writer = XmlWriter.Create(path);//


            //obj nesnesini xml'e çevirdik.
            serialize.Serialize(writer, obj);//ilk parametre Xwriter nesnesi istiyordu verdik,//2.parametrede bizden nesne istiyordu bizde obj nesnesini verdik.

            writer.Close();//writer'ı kapatmamız lazım.
            writer.Dispose();//nesneyi ramden kaldırdık.ramde yer açtık.

        }

        public T Deserialize<T>(string path) //generic metot
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));//tipi verdik.aşağıdaki deserialize işleminde hangi nesneye çevireceğini söylemiş oluyoruz  aslında//XmlSerializer bizden type istiyordu bizden bir tip verdik ona 

            XmlReader reader = XmlReader.Create(path);


            //xml'den gelen tipteki  nesneye dönüşüm işlemi yapıyoruz
            object obj = serializer.Deserialize(reader);//vermiş olduğumuz dosya yolundaki xml'i oku ve deserialize et yani nesneye çevir.//Deserialize geriye obje dönderir gelen tipteki sınıfın tipinde bir nesne dönderir aşağıdada cast ettik zaten.

            reader.Close();//reader'ı kapatmamız lazım.
            reader.Dispose();//nesneyi ramden kaldırdık.ramde yer açtık.

            return (T)obj;//objeyi T tipine dönüştürdük metot T tipinde değer dönderiyordu.
        }
    }
}
