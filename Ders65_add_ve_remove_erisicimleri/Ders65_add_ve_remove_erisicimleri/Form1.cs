using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders65_add_ve_remove_erisicimleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.Load bir evensts dir(olaydır)
            this.Load += Form1_Load;//Form1.Load olayı gerçekleştiğinde aşağıdaki Form1_Load metotunu çalışır.(o metoda git)

            // this.checkBox1.CheckedChanged  bir olaydır.
            this.checkBox1.CheckedChanged += checkBox1_CheckedChanged;//checkbox1.checkedchanged olayı gerçekleştiğinde checkBox1_CheckedChanged metodunu çalıştır.(o metoda git)
        }

        void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Add remove handlers";
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked==true)//check işaretli ise click olayını bağla
            {
                //this.button1.Click bir olaydır ve tıklandığında  eşitliğin sağ tarafındaki metodu çağır dedik.
                this.button1.Click += button1_Click;//.button1 tıklandığında aşağıdaki button1_Click metodunu çalıştır

                this.button1.Click += button1_Click2;//click olayında ikinci metoduda çağırabiliriz.
            }
            else//check işaretli değilse click olayını kaldır.yani o metoda (void button1_Click) gitmemesini söyledik.
            {
                this.button1.Click -= button1_Click;
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buton click olayı gerçekleşti");
        }

        void button1_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("Buton click olayı  2 gerçekleşti");
        }
    }
}
