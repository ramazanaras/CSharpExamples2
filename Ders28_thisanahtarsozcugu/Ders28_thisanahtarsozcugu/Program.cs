using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders28_thisanahtarsozcugu
{
    class Program
    {
        public string Metin1="Metin 1";
        private string Metin2 = "Metin 2";

        public string Metin3 { get; set; }//auto property 


        private string _Metin4 = "Metin 4";

        //classic property
        public string Metin4
        {
            get
            {
                return _Metin4;

            }

            set
            {

                _Metin4 = value;

            }



        }


 
        

        
        
        static void Main(string[] args)
        {

            //this içinde bulunulan classı temsil eder.
        //this yazarak classın üyelerine ulaşıyoruz
        
        
        
        
        }



        private void EkranaYaz()
        {
            this.Metin3 = "Metin 3";

            Console.WriteLine(this.Metin1);
            Console.WriteLine(this.Metin2);

            Console.WriteLine(this.Metin3);
            Console.WriteLine(this.Metin4);

            this.EkranaYaz2(this.Metin4);

        }

        private void EkranaYaz2(string metin)
        {

            Console.WriteLine(metin);


        }
    }
}
