using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lütfen bir sayi giriniz");
            string deger=Console.ReadLine();

            if (deger=="1")
            {
                //Doğru ise buradaki kodu işle
                Console.WriteLine("Bir");

            }
            else if(deger=="2")
            {
                Console.WriteLine("iki");

            
            }
            else
            {

                //yanlış ise buradaki kodu işle
                Console.WriteLine("Birden farklı bir sayı");
            }

            Console.ReadKey();//kLAVYEDEN BİR TUŞA BASMAMI BEKLE

        }
    }
}
