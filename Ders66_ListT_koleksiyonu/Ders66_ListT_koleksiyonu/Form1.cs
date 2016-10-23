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

namespace Ders66_ListT_koleksiyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string[] metinDizisi = new string[5];
            metinDizisi[0] = "murat";
            metinDizisi[1] = "murat";
            metinDizisi[2] = "murat";
            metinDizisi[3] = "murat";
            metinDizisi[4] = "murat";


            ArrayList metinArrayList = new ArrayList();
            metinArrayList.Add("murat"); //ArrayList içerisine object tipinde değer alır yani içerisine her türlü değer yazabiliriz.
            metinArrayList.Add("başeren");
            metinArrayList.Add(5);


            List<string> metinListesi = new List<string>();//tip neyse o tipte değer verebiliriz sadece
            metinListesi.Add("ramazan");


            List<int> sayiListesi = new List<int>();//sadece sayı verebiliriz.
            sayiListesi.Add(5);



            //List<DataTable> tabloListesi = new List<DataTable>();
            //tabloListesi.Add();
        }



    }
}
