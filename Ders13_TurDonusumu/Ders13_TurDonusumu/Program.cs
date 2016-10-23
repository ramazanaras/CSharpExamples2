using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_TurDonusumu
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int a = 10;//tamsayı değişkeni
            float ondalik = 11.5f;//ondalıklı sayı değişkeni
            string metin = "25";//metin değişkeni

            //Bilinçli tür dönüşümü
            ondalik = (float)a;


            //Bilinçsiz tür dönüşümü
            ondalik = a;//çünkü ondalıklı sayı tamsayıyı kaplar hata vermez


            //Parse işlemi 
            a = int.Parse(metin); //a int tipinde 25 olur. a=25 olur 



            //ToString()
            metin = ondalik.ToString();//ondalik değişkenini stringe dönüştürdük. metin "11.5" olur






            



        }
    }
}
