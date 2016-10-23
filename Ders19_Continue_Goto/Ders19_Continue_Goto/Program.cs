using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders19_Continue_Goto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool giris_islendimi = false;//hayır

            Giris:
            for (int sayac = 0; sayac < 5; sayac++)
            {
               
                //if (sayac==3)
                //{
                //    //break;//fordan çıkar
                //    continue;//3'ü atlar diğerine geçer
                //}



                Console.WriteLine(sayac);
            }
            if (giris_islendimi==false)
            {
                giris_islendimi = true;//evet
                goto Giris;
            }
          

            Console.ReadKey();


        }
    }
}
