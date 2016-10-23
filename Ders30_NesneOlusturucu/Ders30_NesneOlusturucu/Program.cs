using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_NesneOlusturucu
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi();//constructor metotu çağırmış oluyoruz.
            kisi1.Ad += "Kisi 1";//constructordaki atadığımız Ad ile birleştirdik.
            kisi1.Soyad += "Kisi1miş";


            Console.WriteLine(kisi1.Ad);
            
            Kisi kisi2 = new Kisi();
            kisi2.Ad = "Kisi 2";



            Kisi kisi3 = new Kisi("ramazan","aras");//constructor metot çağrıldı.ve constructor metodun içinde değerler atandı.


            Console.WriteLine(kisi3.Ad);//ramazan yazar


            Console.ReadKey();



        }
    }
}
