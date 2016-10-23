using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders37_Overloading_AsiriYukleme
{
    class Program
    {
        static void Main(string[] args)
        {

            Kisi k1=new Kisi();
            k1.Ad = "Murat";
            k1.Soyad = "Başeren";


            Kisi k2 = new Kisi();
            k2.Ad = "Kadir";
            k2.Soyad = "başeren";


            k1.EkranaYaz();//Murat Başeren
            k2.EkranaYaz();//Kadir başeren


            k1.EkranaYaz("Onekli");

            k1.EkranaYaz("SonEkli", true);
            Console.Read();
        
        }
    
   
    }


    class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }


        public void EkranaYaz() 
        {
            Console.WriteLine(Ad+" "+Soyad);
        
        }
        
        public void EkranaYaz(string on_ek)//overloading etttik metodu(aynı metottdan imzaları farklı metotlar inşa ettik.)
        {
            Console.WriteLine(on_ek+ " "+ Ad + " " + Soyad);

        }
        public void EkranaYaz(string son_ek,bool onemsiz)//overloading etttik metodu(aynı metottdan imzaları farklı metotlar inşa ettik.)
        {
            Console.WriteLine(  Ad + " " + Soyad+" "+son_ek);

        }

    }

}
