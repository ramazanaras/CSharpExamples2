using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Ders82MySqlBrowser
{
   public class SqlHelper
    {
       
        public SqlConnection Connection { get; private set; }//dışarıdan set edilemezler(değer verilemez) yani dışardan set edilmeye kapattık. ama içerden set edilebiliyor aşağıda set işlemlerini gerçekleştirdik.constructorda.

        public SqlCommand Command { get; private set; }


        public SqlHelper(string connStr)//SqlHelper sınıfı new lendiği anda aşağıdaki işlemler gerçekleşir
        {
            this.Connection = new SqlConnection(connStr);
            this.Command = this.Connection.CreateCommand();//commanda connectionı bağlıyoruz.
        }




        public List<string> GetDataList()//string listesi yaptık//ilk kolonun satırlarını liste olarak dönecek.
        {

            List<string> sonuclar = new List<string>();
            //SqlConnection conn = new SqlConnection(connectionString);

            //SqlCommand cmd = conn.CreateCommand();//commanda connectionu bağlıyor.//SqlCommand cmd=new SqlCommand("select name from sys.databases,conn) bu şekilde dede yapılabilirdi. 

            //cmd.CommandText = "select name from sys.databases ";

            this.Connection.Open();
            //MessageBox.Show("Bağlantı başarılı şekilde açıldı");

            SqlDataReader reader = this.Command.ExecuteReader();

            while (reader.Read())//okuma yaptıkça dön
            {
                string deger = reader.GetString(0);//ilk kolonu alıyoruz.//satır satır okuyoruz.
                sonuclar.Add(deger);
            }

            reader.Close();//readerı kapattık
            reader.Dispose();//bu nesneyi ramden temizleyebiliriz.

            this.Connection.Close();
            //MessageBox.Show("Bağlantı başarılı şekilde kapatıldı");

            return sonuclar;
        }


        public DataTable GetDataTable()//srogu sonucunu tablo olarak dönderiyor.
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(this.Command);

            adapter.Fill(dt);

            return dt;
        }


    }
}
