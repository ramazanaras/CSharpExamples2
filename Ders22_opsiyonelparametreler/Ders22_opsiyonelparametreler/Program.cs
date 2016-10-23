using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders22_opsiyonelparametreler
{
    class Program
    {
        static void Main(string[] args)
        {

            EkranaYaz("ramazan","aras");//opsiyonel parametre (3.parametre -- çıkar)
            EkranaYaz(metin3:"ramazan");//isimlendirilmiş parametre(ilk ikisi boşluk olarak gelir.)

            Console.ReadKey();
        }

        static void EkranaYaz(string metin1 = "", string metin2 = "", string metin3 = "---")
        {
            Console.WriteLine(metin1);
            Console.WriteLine(metin2);
            Console.WriteLine(metin3);
        }








    }
}
