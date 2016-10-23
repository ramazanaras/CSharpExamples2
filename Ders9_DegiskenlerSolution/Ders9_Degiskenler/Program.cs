using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Birinci Sayiyi giriniz");
            string sayi1=Console.ReadLine();//sayıyı oku



            Console.WriteLine(sayi1);



            Console.ReadKey();// bir tuş basılana kadar programı beklet
            
            
           
           //   Metin değişkeni tanımlama
              string metin_degiskeni="ramazan aras";

              
              //sayı değişkeni
              int sayi_degisken=10; 
              
              //Ondalık basamaklı(virgüllü)
              float ondalik_basamakli_degisken_kucuk = 1.5f;  //veya   (float)1.5  //float değişkenlerde değişkenin sonuna f yazmak gerekir.double'da yazmaya gerek yok

              double ondalik_basamakli_degisken_buyuk = 100.5;//100.5d 'de yazabiliriz.
              
              //Not:float  küçük virgüllü  sayılardır
            //double daha büyük virgüllü  sayılardır
            //decimal en büyük  virgüllü  sayılardır


            //Var- yok değişken tanımlama
            //bool tipi true ,false

              bool var_yok_degiskeni_var = true;
              bool var_yok_degiskeni_yok = false;












        }
    }

}
