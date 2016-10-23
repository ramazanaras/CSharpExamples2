using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders68_KeyvaluePair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //key ve value (int yazdığımız key kısmı ,string yazdığımız value kısmı(değer kısmı))
            KeyValuePair<int, string> kullaniciBilgi = new KeyValuePair<int, string>(1, "murat başeren");
            KeyValuePair<int, string> kullaniciBilgi2 = new KeyValuePair<int, string>(2, "şükran başeren");

            //kendi yazdığımız sınıfıda kullanabiliriz
            MyKeyValueObj kullaniciBilgi3 = new MyKeyValueObj(3, "ramazan aras");


            MessageBox.Show(kullaniciBilgi.Key.ToString()+" "+kullaniciBilgi.Value);
            MessageBox.Show(kullaniciBilgi2.Key.ToString() + " " + kullaniciBilgi2.Value);

            MessageBox.Show(kullaniciBilgi3.Key+" "+kullaniciBilgi3.Value);


            //liste şeklinde
            List<KeyValuePair<decimal, int>> listem = new List<KeyValuePair<decimal, int>>();

            //KeyValuePair<decimal, int> koordinat = new KeyValuePair<decimal, int>(12.3m, 45);
            //listem.Add(koordinat);

            //yukarıdaki gibide ekleyebilirdik ama bu daha kısa yöntem
            listem.Add(new KeyValuePair<decimal, int>(12.3m, 45));//12.3m  m dediğimiz decimal olduğunu gösterir.


            //liste içindede dönebiliriz.
            foreach (KeyValuePair<decimal,int> item in listem)
            {
                MessageBox.Show(item.Key.ToString()+" "+item.Value.ToString());
            }






            //ADONETTE combobaxla ilgili işlemlerde kullanmıştık.
            /*
              BookOperations bo = new BookOperations();
            

            cmbBook.DataSource = bo.GetAll();
            cmbBook.DisplayMember = "BookName";
            cmbBook.ValueMember = "BookID";

            List<KeyValuePair<string, int>> rs = new List<KeyValuePair<string, int>>();
            cmbCategory.DataSource = rs;

             
            
             //KeyValuePair<string, int> deneme = new KeyValuePair<string, int>("Roman", 1);
             // rs.Add(deneme); //içine KeyValuePair nesnesi ekledik.
              
            //yukarıdaki gibide ekleme yapabilrdik.ama  aşağıdaki daha kolay yöntemi
            rs.Add(new KeyValuePair<string, int>("Roman", 1)); //içine KeyValuePair nesnesi ekledik.
            
             * 
             * 
            rs.Add(new KeyValuePair<string, int>("Bilim Kurgu", 2));

            cmbCategory.DisplayMember = "Key";//önde görünen değer
            cmbCategory.ValueMember = "Value"; //arkada görünen değer.

             
             */
        }
    }

    //kendimiz yazdık.
    public class MyKeyValueObj
    {

        public int Key { get; set; }
        public string Value { get; set; }

        public MyKeyValueObj()
        {

        }

        public MyKeyValueObj(int key,string value)
        {
            this.Key = key;
            this.Value=value;
            
        }
    }

}
