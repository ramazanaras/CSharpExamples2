using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SqlDataProvider
    {
        

        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }


        //constructor metot.(sınıf new lendiğinde çalışır)SqlDataProvider sınıfını new lediğimizde connection vede command hazır hale gelmiş olucak
        public SqlDataProvider(string connStr)
        {
            this.Connection = new SqlConnection(connStr);//connectiona connectionStringi verdik.
            this.Command = this.Connection.CreateCommand();//commanda connectionu bağladık.
        }


        public DataTable GetDataTable(string query)//çok satırlı veri alacaksak
        {
            DataTable dt = new DataTable();
          
            SqlDataAdapter adapter = new SqlDataAdapter(this.Command); //SqlDataAdapter bağlantıyı kendi açıp kapatır.
            this.Command.CommandText = query;//sorguyu commanda verdik.
            
            adapter.Fill(dt);//verileri datatable'a doldururuz.


            return dt;
        }


        public object GetSingleData(string query) //tek hücreli veri alacaksak 
        {
            object result = null;


            this.Connection.Open();


            this.Command.CommandText = query;//sorguyu commanda verdik.
            result = this.Command.ExecuteScalar();//ExecuteScalar ilk satırın ilk kolonunu dönderir.


            this.Connection.Close();



            return result;
     


        }

        public int RunQuery(string sorgu)
        {
            int result = 0;


            this.Connection.Open();


            this.Command.CommandText = sorgu;//sorguyu commanda verdik.

            result = this.Command.ExecuteNonQuery();//commandı çalıştır dedik.//geriye int dönderir.etkilenen satır sayısını dönderir.//ExecuteNonQuery insert,update,delete gibi sorguları çalıştırmaya yarar.


            this.Connection.Close();



            return result;
     
        }
    }
}
