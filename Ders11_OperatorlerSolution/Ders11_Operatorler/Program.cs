using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            //+= ve -= operatorleri ,*= ve /=

            int a = 10;
            int b = 11;

            //a = a + 3;
            //// a += 5;

            //a = a - 3;
            //// a -= 5;


            //Console.WriteLine(a);



            ////&& :ve, || : yada 
            //if (a>5 && b>12)//koşulların ikisininde doğru olması gerekir.
            //{
            //    Console.WriteLine("a ve b büyüktür");
            //}
            //else if(a>5 && b<12)
            //{
            //    Console.WriteLine("sadece a dogru");
            //}



            //if (a>5 || b>12 )
            //{
            //   //koşullardan birinin doğru olması yeterlidir.                     
            //}




            //  koşul  ?   (doğru ise) : (yanlış ise)
            b=(a > 15) ? b += a : b -= a; //ternary if 

            Console.WriteLine(b);

            Console.ReadKey();





        }
    }
}
