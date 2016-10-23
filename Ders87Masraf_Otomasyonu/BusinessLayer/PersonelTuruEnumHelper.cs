using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PersonelTuruEnumHelper
    {
        public static string GetText(byte id)
        {

            switch (id)
            {
                case 1:
                   
                    return "Çalışan";//return kullanılıyorsa break'e gerek yok.


                case 2:
                
                    return "Birim Yöneticisi";

                case 3:

                    return "Yönetici";

                case 4:

                    return "Muhasebe";

           

                default:
                    return string.Empty;

            }
        }


        //---------
        //ikinci bir versiyon yazabiliriz bu şekilde
        public static string GetText(PersonelTuruEnum e)
        {

            switch (e)
            {
                case PersonelTuruEnum.Calisan:
                    return "Çalışan";
                case PersonelTuruEnum.BirimYoneticisi:
                    return "Birim Yöneticisi";
                case PersonelTuruEnum.Yonetici:
                    return "Yönetici";
                case PersonelTuruEnum.Muhasebe:
                    return "Muhasebe";
                default:
                    return string.Empty;
            }
        }


    }
}
