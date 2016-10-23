using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders34_Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {

            EkranaYaz(komut.kadir);//üç değerden birini vermek zorundayız.enumeration bize bunu zorlar.//başeren2 yazar ekranda



        }
        static void EkranaYaz(komut k)
        {
            switch (k)
            {
                case komut.murat:
                    Console.WriteLine("başeren");
                    break;

                case komut.kadir:
                    Console.WriteLine("başeren2");
                    break;
                case komut.kadirmurat:
                    Console.WriteLine("başeren3");
                    break;
                default:
                    //hiçbiri değilse
                    Console.WriteLine("hiçbiri değil");
                    break;
            }




            if (k==komut.kadir)
            {
                //işlemler yap
            }
        }
    }


    //seçenek listesi
    enum komut
    {
        murat,
        kadir,
        kadirmurat


    }
}
