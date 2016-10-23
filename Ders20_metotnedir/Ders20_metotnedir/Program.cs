using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders20_metotnedir
{
    class Program
    {
        static void Main(string[] args)//static metotların içinde static metotlar olmak zorunda yada içinde static bir eleman bulunmalı
        {


            EkranaYaziYaz();
          string ad=  BanaAdSoyadVer();

          Console.WriteLine(ad);
            Console.ReadKey();


        }

       static void EkranaYaziYaz()
        {

            Console.WriteLine("Adım: Ramazan");
            Console.Write(" Soyadım:Başeren");
            Console.WriteLine("");
        }

       static string BanaAdSoyadVer()
        {
            return "Murat"+ " " + "Başeren";   
        
        }
    }
}
