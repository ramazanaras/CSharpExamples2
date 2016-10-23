using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders14_BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            string s="ramazan";
            float f=12.5f;
            object obj=null; //obje değişkeni kutu gibidir içine her tipten veri alır

            //Boxing
            //obj = a;
            //obj=s;
            //obj = f;


            //Unboxing(kutudan değişkeni çıkarmak)
            obj=a;//kutuladım(kutunun içine a'yı atadım)
            a = (int)obj;//kutudan çıkardım


            obj = s;//kutuladım
            s = (string)obj;//kutudan çıkardım
            s = obj.ToString();//bu şekildede yapabiliriz



            Console.WriteLine(s);
            Console.ReadKey();


        }
    }
}
