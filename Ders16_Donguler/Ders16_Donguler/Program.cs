using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders16_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 5 adet sayı girin");

            int[] dizi = new int[5];
            //dizi[0] = 1;
            //dizi[1] = 20;
            //dizi[2] = 30;
            //dizi[3] = 45;
            //dizi[4] = 56;



         
            for (int sayac = 0; sayac < 5; sayac++)
            {
                dizi[sayac] = Convert.ToInt32(Console.ReadLine());//sayıları kullanıcıdan aldık.
                
            }


            //boşluk eklemek 
            //Console.WriteLine("");
            //Console.WriteLine(" ");
            Console.WriteLine(string.Empty);


            for (int sayac = 0; sayac < 5; sayac++)
            {
                Console.WriteLine(dizi[sayac]);
            }


            Console.ReadKey();


            

        }
    }
}
