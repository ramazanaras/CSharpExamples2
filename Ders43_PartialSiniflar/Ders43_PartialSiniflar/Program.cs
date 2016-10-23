using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders43_PartialSiniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Toplayici t1 = new Toplayici();
            t1.Sayi1 = 5;
            t1.Sayi2 = 15;
           t1.Topla(t1.Sayi1,t1.Sayi2);

           t1.Sayi3 = 25;
           t1.Topla(t1.Sayi1, t1.Sayi2, t1.Sayi3);


            Console.ReadKey();

        }
    }

  partial  class Toplayici //parçalı sınıf (sınıfın bir kısmı burda diğer kısmı aşağıda yer alıyor.)
    {
        public int Sayi1 { get; set; }
        public int Sayi2 { get; set; }

        public int Topla(int s1, int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine(toplam.ToString());

            return toplam;
        }

    }

    partial  class Toplayici
    {
        public int Sayi3 { get; set; }

        public int Topla(int sayi1,int sayi2,int sayi3) 
        {

            int toplam = sayi1 + sayi2 + sayi3;
            Console.WriteLine(toplam.ToString());
            return toplam;
        }


    }

}
