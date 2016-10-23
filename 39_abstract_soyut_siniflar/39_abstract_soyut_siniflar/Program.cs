using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_abstract_soyut_siniflar
{
    class Program
    {
        static void Main(string[] args)
        {


            Insan i1 = new Insan();
            i1.Ad = "Ramazan";
            i1.Soyad = "Aras";
            i1.Cinsiyet = "Erkek";
            i1.EkranaYaz();



            InsanUnvani i2 = new InsanUnvani();
            i2.Ad = "ahmet";
            i2.Soyad = "korkmaz";
            i2.Unvan = "MBA";
            i2.Cinsiyet = "Bayan";
            i2.EkranaYaz();

            Console.ReadKey();

        }
    }


   abstract class Kisi
    {

        /*
         Abstract(soyut):
         * -Abstract sınıflar sadece miras verilmek için tasarlanan sınıflardır
         * -Abstract lar sınıfa özel değil bir property bir method veya herhangi bir eleman abstract olabilir.
         * Bir metodun abstract olması o metod miras verilen sınıflarda ezilmek zorundadır anlamına gelir.
         * Abstract metotların gövdesi olmaz.(içeriği yoktur.MuzikAletleri sınıfında)
         * Abstract metotlar abstract olmayan bir sınıfta bulunamaz.Sınıfta abstract olmalı
         * abstract sınıflar içerisindeki abstract olan property veya metotların gövdesi olmadığı için bu metotlara erişilmesin diye abstract sınıflardan instance üretilemez
         *Sınıf abstrackt olsada içerisinde abstract olmayan metot ve property bulunabilir.
         *-Ancak abstract bir metot veya bir property abstract olmayan sınıfta bulunamaz.
         *Abstrackt sınıfların genel amacı diğer sınıflara miras vermek içindir.Bu sınıftan instance alınıp kullanmayız.
         */
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public abstract string Cinsiyet { get; set; }//miras alınan sınıflarda ezdik.

       public abstract void EkranaYaz();//gövdesi yok (abstackt olduğu için miras alınan sınıfta ezilmek zorundadır.)//virtual(sanal) metotlarda ezilmek zorunda değildi.ezilebilir demiştik.)


    }


    class Insan : Kisi
    {

       
        public override void EkranaYaz()
        {
            Console.WriteLine(Ad+" "+Soyad+" "+Cinsiyet);
        }


        private string _cinsiyet;
        public override string Cinsiyet
        {
            get
            {
                return _cinsiyet;
            }
            set
            {
                _cinsiyet = value;
            }
        }
    }

    class InsanUnvani:Kisi
    {
        public string Unvan { get; set; }

      

        public override void EkranaYaz()
        {
            Console.WriteLine(Ad + " " + Soyad+" "+Unvan+" "+Cinsiyet);
        }

        private string _cinsiyet;
        public override string Cinsiyet
        {
            get
            {
                return _cinsiyet;
            }
            set
            {
                _cinsiyet = "--" + value;
            }
        }
    }

}
