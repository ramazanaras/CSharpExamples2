using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders15_ConvertileTurDonusumu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 12;
            string metin = "Murat"; ;
            string sayi_metin = "10";

            string yeni_metin = a.ToString();// a="5" oldu 

            string yeni_metin2 = Convert.ToString(a);//bu şekildede çevirebiliriz a yine "5" olur metin şeklinde


            int yenisayi = Convert.ToInt32(sayi_metin);
            int yenisayi2 = int.Parse(sayi_metin);//bu şekildede yapabiliriz.

          //short yepyenisayi=  Convert.ToInt16(sayi)//shorta dönüştürür.
          




        }

    }
}
