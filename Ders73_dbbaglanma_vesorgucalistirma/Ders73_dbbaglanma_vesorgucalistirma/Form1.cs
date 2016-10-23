using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders73_dbbaglanma_vesorgucalistirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=localhost;database=TestVeritabani;Integrated Security=true");

            conn.Open();
            MessageBox.Show("bağlantı açıldı");


            conn.Close();
            MessageBox.Show("bağlantı kapatıldı");
        }

        private void btnKisileriGetir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=localhost;database=TestVeritabani;Integrated Security=true");

            SqlCommand cmd = new SqlCommand("Select Ad,Soyad from Kisiler", conn);


            //=============================================
            //SqlDataAdapter nesnesi ile bir kerede tüm veriyi okuma
            //=============================================
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//verileri adp'ye aktardık//data adapter nesnesi kendi içinde bağlantıyı açar ve kapatır.bağlantıyı açmaya kapamaya gerek yoktur.
            DataTable dt = new DataTable(); //sanal tablo 

            adapter.Fill(dt);//tabloyu verilerle doldurduk

            listBox1.Items.Clear();

            //dt.Rows DataRowCollection'ı dır yani bir koleksiyondur ve içinde DataRow tipinde bir satırlar bulunur bizde foreach ile dönerek bunları aldık.
            foreach (DataRow satir in dt.Rows)//satır satır okuma
            {
                listBox1.Items.Add(satir["Ad"].ToString() + " " + satir["Soyad"].ToString());
            }




            //=======================================
          //  SqlDataReader nesnesi ile satır satır okuma
         //   =======================================
            //conn.Open();
            //SqlDataReader reader = cmd.ExecuteReader();//verileri sdr'a doldurduk.

            //listBox1.Items.Clear();

            //while (reader.Read())//veri oldukça döngüde dön
            //{
            //    listBox1.Items.Add(reader["Ad"].ToString() + " " + reader["Soyad"].ToString());
            //}

            //conn.Close();




        }
    }
}
