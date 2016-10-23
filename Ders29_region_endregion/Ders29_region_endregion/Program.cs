using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders29_region_endregion
{
    class Program
    {
        //Ctrl+m,ctrl+l bütün regionları açar
        //ctrl+m,ctrl+o bütün regionları kapar
        //gruplama yapıyor
        #region "Field(değişken) Alanları"
        public string Metin1 = "Metin 1";
        private string Metin2 = "Metin 2";
        #endregion





        #region "Properties"
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
        #endregion




       

  




        #region "Main metodu"
        static void Main(string[] args)
        {

            //this içinde bulunulan classı temsil eder.
            //this yazarak classın üyelerine ulaşıyoruz




        } 
        #endregion



        #region "Metodlar"
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
        #endregion

       
    }
    
}
