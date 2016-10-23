using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders38_SanalMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k1 = new Kisi();
            k1.Ad = "Murat";
            k1.Soyad = "başeren";
            k1.EkranaYaz();//Murat başeren yazar


            KisiUnvanli k2 = new KisiUnvanli();
            k2.Ad = "Murat";
            k2.Soyad = "başeren";
            k2.Unvan = "MBA";

            k2.EkranaYaz(); //MBA Murat başeren yazar.

            Console.ReadKey();
        }
    }


    class  Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }


        public  virtual void EkranaYaz() //ezilebilmesini farklı çalışabilmesini sağladık.
        {

            Console.WriteLine(Ad+" "+Soyad);
        
        }

    }


    class KisiUnvanli:Kisi
    {
        public string Unvan { get; set; }
        //override deyip boşluk yazarak metotlar karşımıza çıkar.
        public override void EkranaYaz()//artık bu metot farklı çalışıyor.(ezmiş olduk.)
        {
           Console.WriteLine( Unvan+" "+Ad + " " + Soyad);
            
        }
    }
}
