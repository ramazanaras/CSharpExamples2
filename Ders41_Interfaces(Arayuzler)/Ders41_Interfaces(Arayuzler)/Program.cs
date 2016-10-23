using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders41_Interfaces_Arayuzler_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             sınıfa yetenek ve özellik kazandırır.bu sınıf yapabilir edebilir gibi özellikler kazandırır.
             * örneğin bir sınıfa sipariş edebilir,yemek yapabilir ,hesap alabilir interfacelerini verirsek bu sınıf bu özellikleri kazanır.
             * başka sınıflara rehber olmak için üretiriz interfaceleri.
             */
            /*İnterfaceler abstract classlara çok benziyor.
       * interfaceler başka sınıflar için yazılır.
       * Interface:
       * -interface içerisinde property,metot indexleyici ve event haricinde birşey bulunmaz.
       * -interface içerisindeki elemanların abstract sınıflarda olduğu gibi gövdesi bulunmaz.
       * Abstract sınıftan 1.farkı;gövdesi olan  bir metot veya propertyi yazamayız.
       * Abstract sınıftan 2.farkı:interface içerisindeki elemanların access modifers'ları bulunmaz.Ve varsayılan access modifiersları public'dir.(metotlara ve porpertylerin başına public yazmaya gerek yoktur.)
       * interface sınıfardan instance üretilemez.
       * Bir sınıf birden fazla interface 'i implemente edebilir.Yani barındırabilir.Ama bir sınıf bir sınıftan miras alır.
       * 
       */

            //Araba aa = new Parca();//bu şekilde olmaz

            //bu şekilde atama yapabiliriz hata vermez çünkü implemente edilmişler.
            IOrtakFonksiyonlar parca1 = new Parca();
            IOrtakFonksiyonlar araba1 = new Araba();

            parca1.Sifirla();
            araba1.Sifirla();
          //  araba1.AraBilgisiKaydet(); //bu gelmez 



            //bu şekilde olabilir.iki tipte bu interface'den türedikleri için ortak bir tip olmuş oluyor.
            //iki farklı tipi aynı tipe eşitleme sağlar
            //metot tanımları ile yazılacak metotları bizim için ilgili class'a ekler.
            //Miras almadan farklı olarak interface implement edilir(uygulanır) dolayısı ile birden çok interface'i bir class 'a virgül ile ekleyebilirsiniz.
            IOrtakFonksiyonlar nesne = new Parca();
            nesne = new Araba();


        }
    }


    interface IOrtakFonksiyonlar
    {
        //gövdeleri yok vede başına public falan yazılmaz.
        void Sifirla();
        string MetinVer();

    }

    class Araba : IOrtakFonksiyonlar//interface'i implemente etmemiz gerekiyor.
    {
        public int Yili { get; set; }
        public string Modeli { get; set; }
        public string Marka { get; set; }

        public void ArabaBilgisiKaydet() 
        {
        
            //veritabanı  yada bilgisayarda bir dosyaya verileri kaydetsin.
        
        }

        public void Sifirla()
        {
            Yili = -1;
            Modeli = string.Empty;//boş yaptık
            Marka = string.Empty;//boş yaptık

        }

        public string MetinVer()
        {
            return Yili.ToString() + " " + Modeli + " " + Marka;

        }

       
    }

    class Parca:IOrtakFonksiyonlar
    {
        public int ParcaKodu { get; set; }
        public string Adi { get; set; }


        public void ParcaBilgisiKaydet()
        {
            //veritabanı  yada bilgisayarda bir dosyaya verileri kaydetsin.
        }



        public void Sifirla()
        {
            ParcaKodu = -1;
            Adi = string.Empty;//boş yaptık


        }
        public string MetinVer()
        {
            return ParcaKodu.ToString() + " " + Adi;
        }

      
    }


}
