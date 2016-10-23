using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders79_ToDoList_Uygulamasi
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string GorevMetni { get; set; }
        public DateTime TamamlanmaTarihi { get; set; }
        public bool Tamamlandi { get; set; }


        public override string ToString()
        {
            if (Tamamlandi==false)
            {
                return GorevMetni;
            }
            else//tamamnlananlara tarihi ile birlikte görüntüledik.
            {
                return "( "+TamamlanmaTarihi.ToShortDateString() + " ) " + GorevMetni;
            }
        }

    }
}
