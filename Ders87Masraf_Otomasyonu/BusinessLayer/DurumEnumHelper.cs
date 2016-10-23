using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
  public   class DurumEnumHelper
    {
      public static string GetDurumText(byte durumId) 
      {

          switch (durumId)
          {
              case 1:
                //  DurumEnum.OnayBekliyor
                  return "Onay Bekliyor";//return kullanılıyorsa break'e gerek yok.

                
              case 2:
                // DurumEnum.Reddedildi
                  return "Reddedildi";

              case 3:
                  // DurumEnum.Duzeltilecek
                  return "Duzeltilecek";

              case 4:
                 // DurumEnum.Odendi
                  return "Ödendi";

              case 5:
                  // DurumEnum.Odendi
                  return "Onaylandı";

              default:
                  return string.Empty;
                
          }
      }


      //---------
      //ikinci bir versiyon yazabiliriz bu şekilde
      public static string GetDurumText(DurumEnum durum)
      {

          switch (durum)
          {
              case DurumEnum.OnayBekliyor:
                       return "Onay Bekliyor";

              case DurumEnum.Reddedildi:
                   return "Reddedildi";

              case DurumEnum.Duzeltilecek:
                 return "Duzeltilecek";

              case DurumEnum.Odendi:
                  return "Ödendi";

              default:
                  return string.Empty;
          }
      }



    }
}
