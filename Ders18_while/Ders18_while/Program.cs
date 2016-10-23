using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders18_while
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;


            //while (a < 8)//a 8den küçük oldukça
            //{

            //    Console.WriteLine(a);

            //    a++;
            //}


            //önce 1 defa çalışır(koşulsuz)
            do
            {

                Console.WriteLine(a);
                a++;
            } while (a < 8);


            Console.Read();




        }








    }
}
