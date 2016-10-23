using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders27_UyeErisimBelirleyicileri
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac a = new Arac();
           







        }
    }


    class Arac
    {
        private string Model;//bu classın dışında kullanılamaz
        public string Plaka;//her yerden erişilebilir.




        private int Yili { get; set; }
        public int Durumu { get; set; }



    }
}
