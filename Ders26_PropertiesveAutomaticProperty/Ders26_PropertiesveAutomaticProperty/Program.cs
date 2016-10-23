using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders26_PropertiesveAutomaticProperty
{
    class Program
    {
        static void Main(string[] args)
        {

            Kisi k = new Kisi(); ;
            k.Ad = "ramazan";
            k.Soyad = "Başeren";
            k.Yas = 65;


            Tel t = new Tel();
            t.TelNo = "312313";//set işlemi çalışır

            t.AlanKodu = "22221";

            Console.WriteLine(t.TelNo);//get işlemi çalışır

            Console.ReadKey();

        }
    }

    class Kisi
    {


        private string _Ad;

        public string Ad
        {
            get { return _Ad; }
            set { _Ad = value; }
        }
        private string _Soyad;

        public string Soyad
        {
            get { return _Soyad; }
            set { _Soyad = value; }
        }
        private int _Yas;

        public int Yas
        {
            get { return _Yas; }
            set { _Yas = value; }
        }

    }
    class Tel
    {
        //Classic property
        private string _TelNo;//ctrl+r+e yapınca kendi aşağıda otomatik oluşturuyor.

        public string TelNo
        {
            get { return _TelNo; }
            set { _TelNo = value; }
        }




        //private string _AlanKodu;

        //public string AlanKodu
        //{
        //    get { return _AlanKodu; }
        //    set { _AlanKodu = value; }
        //}

      

        //auto property
       public string AlanKodu { get; set; }//yukarıdakinin aynısı aslında 
    }
}
