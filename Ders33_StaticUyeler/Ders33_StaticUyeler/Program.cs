using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders33_StaticUyeler
{
    class Program
    {
        static Kisi kk;

        static void Main(string[] args)
        {
            //static:sabit ,kalıcı öğeler
            //static değişkenler program kapanana kadar hazır bir şekilde bekler.program kapanana kadar içindeki veriyi tutar.başka yerlerden bu değişkene ulaşabiliriz.heryerden bu değişkenlere ulaşabiliriz.sanal veritabanı gibi birşey.


            //mavi renkliler value type (değer tipi) olarak adlandırılır.Kullanıldıkça kopyalanırlar
            //value typelar static olmuyor
            int sayi = 0;
            string yazi = "Murat";
            
            sayi=sayi+2;


            EkranaYaz(sayi);

            ////turquaz renkli olanlar (reference type 'lidir.)
            //Kisi k = new Kisi();
            //k.Ad = "ramazan";
            //k.Soyad = "aras";


            //EkranaYazalim(k);


            //k = new Kisi();
            //k.Ad = "kadir";
            //k.Soyad = "başeren";

            //EkranaYazalim(k);


            //Kisi.Ad="ramazan"; //sınıfınadı. diyerek erişebiliriz static üyelere.new'lemeye gerek yoktur.

        }
        static void EkranaYaz(int s)
        {



        }

        static void EkranaYazalim(Kisi k)
        {



        }
    }


   static class Kisi
    {


        public static string Ad { get; set; }
        public static string Soyad { get; set; }


    }

}
