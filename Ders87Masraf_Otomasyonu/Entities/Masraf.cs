using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Masraf
    {

        public Guid Id { get; set; }// Sql de uniqueidentifier c# ta Guid'e karşılık gelir.yani benzersiz bir sayı
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }  //sql de decimal c# tata decimal dir.
        public string Aciklama { get; set; }
        public int PersonelId { get; set; }
        public byte DurumId { get; set; } //sql de tinyint c# ta byte 'a karşılık gelir.
    }
}
