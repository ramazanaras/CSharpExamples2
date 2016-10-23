using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders25_SinifNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            Kisi k = new Kisi();
            k.Ad = "Ramazan";
            k.Soyad = "Aras";
            k.Yas = 99;


            k.AdSoyadYaz();
            //sınıf içindeki sınıftaki değerlere atama yaptık.
            k.t.AlanKod = "234234";
            k.t.No = "4324";
              


            Console.ReadKey();




        }
    }


    class Kisi
    {
        //defaultları private'dir
        public string Ad;
        public string Soyad;
        public int Yas;
        public Tel t = new Tel();//alttaki sınıfı burda değişken olarak tanımladık.

        public void AdSoyadYaz()
        {

            Console.WriteLine(Ad + " " + Soyad);


        }

      public  int YasGetir()
        {

            return Yas;

        }

    }



    class Tel
    {
      public  string No;
      public string AlanKod;



    }


}
