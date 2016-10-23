using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders23_StructParametreler
{
    class Program
    {
        static void Main(string[] args)
        {


        //    ToplamaYap();//değer girmedik varsayılan değerler kullaılacak(opsiyonel)

            //ToplamaYap(c:5,sonucMetni: "Sonuc :");//isimlendirilmiş parametre yolladık.



            ToplamaElemanlari parametreler=new ToplamaElemanlari();//instance
            parametreler.a = 5;
            parametreler.b = 3;
            parametreler.c = 4;
            parametreler.d = 2;
            parametreler.sonucMetni = "Sonuc: ";


            ToplamaYap(parametreler);

           

            Console.ReadKey();

        }

        //static void ToplamaYap(int a = 0, int b = 0, int c = 0, int d = 0, string sonucMetni = "Toplam :")//varsayılan değer atıyoruz parametrelere
        //{

        //    int sonuc = a + b + c + d;

        //    Console.WriteLine(sonucMetni + sonuc);
        //}




        //struct parametresi
        static void ToplamaYap(ToplamaElemanlari elemanlar)//parametreleri yukarıdaki gibi uzun uzadıya tanımlamadık.
        {

            int sonuc = elemanlar.a + elemanlar.b + elemanlar.c + elemanlar.d;

            Console.WriteLine(elemanlar.sonucMetni + sonuc.ToString());
        }


       
    }


    struct ToplamaElemanlari//classların ufak hali(struct)
    {
        //struct içerisinde varsayılan değer atayamıyoruz int a=5 yapamayız
      public  int a;
      public int b;
      public int c ;
      public int d;
      public string sonucMetni;
    }


}
