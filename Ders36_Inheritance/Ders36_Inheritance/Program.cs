using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders36_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {




        }
    }

    class Canli
    {
    public string KanGrubu { get; set; }
    
    }

    class Insan:Canli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal Maas { get; set; }

        public void MaasAl() 
        {
        //maaş hesaba gönderilir.
       // this.KanGrubu; //Canlidan gelen özellik.
        }
    }

    class Calisan : Insan  //miras aldı
    {
       
        
        
        public Calisan()//constructor metot(sınıf new'lendiğinde çalışan metot)
        {
            Maas = 100;
        }


        public void Gorev1()
        {
            //this.Ad  // bu class içindeki demek miras aldığı için burdada kullandık


            this.MaasAl();
            
        }
        
        

       
    }

    class Yonetici : Insan //miras aldı
    {
      
        public Yonetici()//constructor metot
        {
            Maas = 200;
        }
        public void Gorev2()
        {
            //this.Ad

        }

    }

    class Patron : Insan  //miras aldı
    {
          
        public Patron()//constructor metot
        {
            Maas = 300;
        }

        public void Gorev3()
        {
           // this.Soyad
            
        }

    }

}
