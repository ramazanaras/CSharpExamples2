using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders77_DataTableileXmlOkumaveYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string path = Application.StartupPath + @"\veriler.xml";//path:debug klasörünün içerisindeki ayarlar.xml dosyasının yolu olmuş oluyor
        private void btnOrnekVeriileDoldur_Click(object sender, EventArgs e)
        {
            //DataTable oluşturulur.Tablo adı olmalı
            DataTable dt = new DataTable("Veriler");


            //Tablo kolonları oluşturulur
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");

            //Satır 1 oluşturulur
            DataRow dr1 = dt.NewRow();//yeni bir satır oluşturduk.
            dr1["Ad"] = "Murat";//Ad kolonuna değeri verdik
            dr1["Soyad"] = "Başeren";//soyad kolonuna değeri verdik.
            dt.Rows.Add(dr1);//Tabloya eklenir.

            //Satır 2 oluşturulur
            DataRow dr2 = dt.NewRow();//yeni bir satır oluşturduk.
            dr2["Ad"] = "Şükran";//Ad kolonuna değeri verdik
            dr2["Soyad"] = "Başeren";//soyad kolonuna değeri verdik.
            dt.Rows.Add(dr2);//Tabloya eklenir.

            //Satır 2 oluşturulur
            DataRow dr3 = dt.NewRow();//yeni bir satır oluşturduk.
            dr3["Ad"] = "Ramazan";//Ad kolonuna değeri verdik
            dr3["Soyad"] = "Aras";//soyad kolonuna değeri verdik.
            dt.Rows.Add(dr3);//Tabloya eklenir.

            dataGridView1.DataSource = dt;//datagridview'e datatable'ı verdik.
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dataGridView1.DataSource as DataTable; //datatable'ı elde ettik.//cast ettik.

            dt.WriteXml(path,XmlWriteMode.WriteSchema,true);//datatable'ı verdiğimiz path'deki(yani yoldaki) xml dosyasına yazdı.

            MessageBox.Show("Dosya oluşturuldu.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(path))//verdiğimiz path'de dosya varsa işlemleri yap dedik.
            {
                DataTable dt = new DataTable("Veriler");

                dt.ReadXml(path);//verdiğimiz konumdaki xml'i oku datatable'a aktar.

                dataGridView1.DataSource = dt; //datagridview'de gösterdik.
            }
        }
    }
}
