using System;
using System.Collections; //Hashtable için 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders56_Koleksiyonlar_HashTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Hashtable mylist = new Hashtable();

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            mylist.Add(1, "Ramazan");
            mylist.Add(2, "Aras");
            mylist.Add(3, "Belinay");
            mylist.Add("Yok", "Belirsiz");


            foreach (DictionaryEntry item in mylist)
            {
                listBox1.Items.Add(item.Key.ToString()+"-"+item.Value.ToString());//item.Key keyi döndürür(1 gibi), item.value değeri(Ramazan gibi) döndürür
            }
        


        }

        private void btn1KeyToValue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mylist[1].ToString());

        }

        private void btnYokKeyToValue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mylist["Yok"].ToString());
        }
    }
}
