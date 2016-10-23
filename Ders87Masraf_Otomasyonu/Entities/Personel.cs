using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Personel
    {

        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Eposta { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }//Sqlde bit c#ta bool oluyor.

        //Tabloda SorumlusuId alanı boş geçilebilir demiştik.aşağıdada nullable yani boş geçilebilir yaptık.
        // public Nullable<int> SorumlusuId { get; set; } //null geçilebilir.
        public int? SorumlusuId { get; set; } //null geçilebilir.yani boş geçilebilir int dedik. .buda diğer yöntem .SorumlusuId değerine null değer atayabiliriz.SorumlusuId=null şeklinde değer atanabilir.


       

        public byte PersonelTurId { get; set; }//Sqlde tinyint c# ta byte 'a denk geliyor.




    }
}
