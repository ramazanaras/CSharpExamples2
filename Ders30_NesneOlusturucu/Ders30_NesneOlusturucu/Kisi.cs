using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders30_NesneOlusturucu
{
    public class Kisi
    {
        public string Ad;
        public string Soyad;
        public int Yas;
        public string Eposta { get; set; }


        //constructor metot
        //nesne olusturucu
        public Kisi()//nesne oluşturulduğunda çalışan metot.
        {
            this.Ad = "Ad";
            this.Soyad = "Soyad";
        }

        public Kisi(string _ad,string _soyad)
        {
            this.Ad = _ad;
            this.Soyad = _soyad;
        }

        public Kisi(string _ad, string _soyad,int _yas)
        {
            this.Ad = _ad;
            this.Soyad = _soyad;
            this.Yas = _yas;

        }

        public Kisi(string _ad, string _soyad, int _yas,string _eposta)
        {
            this.Ad = _ad;
            this.Soyad = _soyad;
            this.Yas = _yas;
            this.Eposta = _eposta;
        }


       

       





    }
}
