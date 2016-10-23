using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ders35_Kapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi k1 = new Kisi();
            
        }
    }

    class Kisi
    {
        //private string _Ad;//ctrl+r+e yapınca aşağıda kendi otomatik oluşturuyor

        //public string Ad
        //{
        //    get { return _Ad; }
        //    set { _Ad = value; }
        //}

        public string Ad { get; set; }//yukarıdakinin aynısı

    }
}
