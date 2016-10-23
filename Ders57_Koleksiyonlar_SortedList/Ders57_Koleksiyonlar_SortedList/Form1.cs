using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders57_Koleksiyonlar_SortedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            SortedList list = new SortedList();//keye göre sıralayarak ekler listeye.

            list.Add(2, "Ahmet");  //ilki key diğeri değer(value)
            list.Add(1, "Ramazan");
            list.Add(4, "Mahmut");
            list.Add(3, "Mehmet");

            foreach (DictionaryEntry item in list)  //DictionaryEntry tipinde saklıyor değerleri
            {
                listBox1.Items.Add(item.Key.ToString() + "," + item.Value.ToString());  
            }

        }
    }
}
