using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_switch
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 14;
            int b = 3;



            switch (a)
            {
                case 1:
                    Console.WriteLine("a 1'e eşittir");
                    break;
                case 2:
                    Console.WriteLine("a 2'e eşittir.");
                    break;


                default://hiçbiri değilse
                    Console.WriteLine("Hiçbiri değil");
                    break;
            }

            //Metin ifadesinin switch ile işlenişi
            //string ad = "ramazan";
            //switch (ad)
            //{
            //    case "ramazan":
            //        console.writeline("doğru");
            //        break;

            //    default:
            //Console.WriteLine("Hiçbiri değil");
            //        break;
            //}

            Console.Read();
        }
    }
}
