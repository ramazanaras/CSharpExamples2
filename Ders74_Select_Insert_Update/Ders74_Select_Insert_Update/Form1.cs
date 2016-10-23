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

namespace Ders74_Select_Insert_Update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private SqlConnection conn = new SqlConnection("server=localhost;database=TestVeritabani;Integrated Security=true");

        private Random rnd = new Random();//rastgele sayı üretmek için

        private void SelectSorgusu()
        {
            SqlCommand cmd = new SqlCommand("Select ID,Ad,Soyad,Yas from Kisiler", conn);
            conn.Open();//bağlantıyı açtık

            listBox1.Items.Clear();

            SqlDataReader reader = cmd.ExecuteReader();//verileri reader'a doldurduk

            while (reader.Read())//satır satır okuyoruz şimdide
            {
                listBox1.Items.Add(reader["ID"]+"-"+reader["Ad"]+"-"+reader["Soyad"]);
            }


            conn.Close();//bağlantıyı kapattık.

        }
        private void SorguyuCalistir(SqlCommand cmd)
        {
            conn.Open();//bağlantıyı açtık.//bağlantıyı açmadan aşağıdaki cmd yi çalıştıramayız hata verir.

            int sonuc = cmd.ExecuteNonQuery();//komutu çalıştırdık
            MessageBox.Show("Etkilenen Satır sayısı: "+sonuc.ToString());

            conn.Close();//bağlantıyı kapadık

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectSorgusu();
        }
       


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Kisiler(Ad,Soyad,Yas) values(@ad,@soyad,@yas)",conn);
            cmd.Parameters.AddWithValue("@ad", this.txtInserAd.Text);
            cmd.Parameters.AddWithValue("@soyad", this.txtInsertSoyad.Text);
            cmd.Parameters.AddWithValue("@yas", rnd.Next(0, 100));//yaşı rastgele atıyor.

            SorguyuCalistir(cmd);

            SelectSorgusu();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string seciliKayit = this.listBox1.SelectedItem.ToString();
            int seciliKayitId = int.Parse(seciliKayit.Split('-')[0]);//- işaretine göre ayır ve ilk kelimeyi al .zaten o da id değeri oluyor.

            SqlCommand cmd = new SqlCommand("update Kisiler set Ad=@ad,Soyad=@soyad where ID=@id", conn);
            cmd.Parameters.AddWithValue("@ad", this.txtUpdateAd.Text);
            cmd.Parameters.AddWithValue("@soyad", this.txtUpdateSoyad.Text);
            cmd.Parameters.AddWithValue("@id", seciliKayitId);

            SorguyuCalistir(cmd);

            SelectSorgusu();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string seciliKayit = this.listBox1.SelectedItem.ToString();
            int seciliKayitId = int.Parse(seciliKayit.Split('-')[0]);//- işaretine göre ayır ve ilk kelimeyi al .zaten o da id değeri oluyor.

            SqlCommand cmd = new SqlCommand("DELETE FROM Kisiler where id=@id", conn);//idye göre sildik.
            cmd.Parameters.AddWithValue("@id", seciliKayitId);

            SorguyuCalistir(cmd);

            SelectSorgusu();
        }

       

        
    }
}
