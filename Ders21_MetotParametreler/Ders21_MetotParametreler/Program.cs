using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders21_MetotParametreler
{
    class Program
    {
        static void Main(string[] args)
        {


            EkranaYaziYaz("Ramazan");


            string adSoyad = AdSoyadVer("ramazan", "aras");
            Console.WriteLine(adSoyad);


            int toplam = Topla(5,8);
            Console.WriteLine(toplam);
            Console.ReadKey();









        }



        static void EkranaYaziYaz(string yazilacakYazi)
        {
            Console.WriteLine(yazilacakYazi);


        }


        static string AdSoyadVer(string ad,string soyad)
        {
            return ad + " " + soyad;


        }
        static int Topla(int deger1,int deger2) 
        {


            return deger1 + deger2;
        
        
        }
    }
}
