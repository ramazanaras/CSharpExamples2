using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders51_OrnekUygulama_TelefonDefteri_
{
   public  class Kisi
    {
        public Guid Id { get; set; }//benzersiz sayı gibi birşey 
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelefonNo { get; set; }

    }
}
