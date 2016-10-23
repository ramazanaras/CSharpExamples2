using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders42_Polymorphism_Cok_Bicimlilik
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir yapıdaki üyelerin farklı biçimde tekrardan kullanılabilmesidir.(Polymorphism)


            Personel p1 = new Personel();
            p1.KullaniciAdi = "m.baseeren";
            p1.KullaniciUnvani = "kıdemli yazılım geliştirici";
            p1.GorevYap("işlem1");
            p1.LogAl();

            Console.WriteLine("");


            Isci isci1 = new Isci();
            isci1.KullaniciAdi = "s.baseeren";
            isci1.KullaniciUnvani = "akademisyen";
            isci1.GorevYap("işlem2");
            isci1.LogAl();


            Console.WriteLine("");

            Yonetici y1 = new Yonetici();
            y1.KullaniciAdi = "b.baseeren";
            y1.KullaniciUnvani = "Proje Muduru";
            y1.GorevYap("işlem3");
            y1.LogAl();


            Console.ReadKey();
        }
    }

    class Personel
    {
        public string KullaniciAdi { get; set; }
        public string KullaniciUnvani { get; set; }


        public void GorevYap(string gorevAdi)
        {

            Console.WriteLine(string.Format("{0}({1}) isimli kullanıcı {2} gorevini gerçekleştirdi", KullaniciAdi, KullaniciUnvani, gorevAdi));


        }

        //yapılan işlemlerin kayıt altına alınması
        public virtual void LogAl()//miras alınan sınıflarda bu metodu ezebilir ve işleyişini değiştirebiliriz.
        {
            Console.WriteLine(string.Format("{0} isimli çalışan işlem yaptı.", KullaniciAdi));

        }


    }
    class Isci:Personel
    {
        public int Seviye { get; set; }

        public override void LogAl()
        {
            Console.WriteLine(string.Format("{0} isimli personel işlem yaptı.", KullaniciAdi));
        }

    }

    class Yonetici:Personel
    {
        public override void LogAl()
        {
            Console.WriteLine(string.Format("{0} isimli Yonetici işlem yaptı.", KullaniciAdi));
        }

    }


}
