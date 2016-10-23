using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders40_Kapali_Sealed_Siniflar_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sealed classlar
            //abstract classların tam tersi gibi
            //bu classtan inherite(miras verilmez) edilemez

            KisiKarti kk = new KisiKarti();
            kk.Ad = "murat";
            kk.Soyad = "başeren";

            kk.TelNo = "04654465";

            string adSoyad = Fonksiyonlar.İkiMetinBirlestir("Ramazan", "Aras");//static olduuğu için . ile çağırabiliriz.
            int toplam = Fonksiyonlar.SayilariTopla(3, 4, 5);


            Console.WriteLine(adSoyad);
            Console.WriteLine(toplam);


            Console.ReadKey();
        }
    }

    //class Kisi:KisiKarti//miras verilmez hata verir.
    //{


    //}

    sealed class KisiKarti
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelNo { get; set; }


    }

    //içinde static olan elemanlar bulunan metotlarıda sealed olarak işaretleyebiliz.
    sealed class Fonksiyonlar
    {

        public static string İkiMetinBirlestir(string p1, string p2)
        {
            return p1 + p2;

        }

        public static int SayilariTopla(int p1, int p2, int p3)
        {

            return p1 + p2 + p3;

        }

    }
}
