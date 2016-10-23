using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Ders82MySqlBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //SqlHelper helper = new SqlHelper(this.connectionString);
            //helper.Connection = new SqlConnection("32sdfsdf");//değer atayamayız çünkü SqlHelper classında Connection ve Commanda private set yaptık yani dışardan değer atayamayız.
            //helper.Command = new SqlCommand("qweasdad");
        }




        //global değişken
        private string connectionString = string.Empty; // ""   //boş string

        private void CreateConnectionString(string dbName) 
        {


            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))//boş değilse
            {
                //Sql Authenticationla  bağlancaz
                connectionString = string.Format("Server={0};Database={1};User Id={2};Password={3};", txtServerName.Text, dbName, txtUserName.Text, txtPassword.Text);//Master databasene bağlanıyoruz
            }
            else
            {
                //Windows Authenticationla bağlancaz
                connectionString = string.Format("Server={0};Database={1};Integrated Security=true", txtServerName.Text, dbName);
            }
        
        
        
        
        }



        private void btnConnect_Click(object sender, EventArgs e)
        {

            this.CreateConnectionString("Master");//Master databesini verdik.

            try
            {
                this.cmbDatabases.Items.Clear();


                SqlHelper helper = new SqlHelper(connectionString);//conn SqlHelper classında newlendi oluşturuldu.vede SqlHelper newlendiğinde commanda connection bağlandı.
                helper.Command.CommandText = "select name from sys.databases ";

              List<string> databases=  helper.GetDataList();
              foreach  (string dbName in databases)
              {
                   this.cmbDatabases.Items.Add(dbName);
              }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtServerName.Text = "TOSHIBA";
        }

        private void cmbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbName = cmbDatabases.Text;//databasein adını alıyoruz vede aşağıdada o databese bağlanıyoruz

            this.CreateConnectionString(dbName);



            try
            {
                cmbTables.Items.Clear();

                SqlHelper helper = new SqlHelper(connectionString);
                helper.Command.CommandText = "select name from sys.tables";//databasein tablo isimlerini  alıyoruz


                List<string> tables = helper.GetDataList();
                foreach (string tableName in tables)
                {
                    cmbTables.Items.Add(tableName);//tabloları comboboxa doldurduk
                }


               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbName = cmbDatabases.Text;//databasein adını alıyoruz vede aşağıdada o databese bağlanıyoruz



            try
            {
                //seçilen tablonun kolon listesi checkedlistboxa eklenir.
                clbColumns.Items.Clear();

                string tableName = cmbTables.Text;

                SqlHelper helper = new SqlHelper(connectionString);
                helper.Command.CommandText = string.Format("select COLUMN_NAME from {0}.INFORMATION_SCHEMA.COLUMNS where TABLE_NAME=@TableName", dbName);
                 helper.Command.Parameters.AddWithValue("@TableName", tableName);



                 List<string> columns = helper.GetDataList();
                 foreach (string columnName in columns)
                 {
                      clbColumns.Items.Add(columnName);//kolonları checklistboxa  doldurduk
                 }



                 //Seçili tabloya select atılarak verileri elde edilir.

                //yeni bir helper nesnesi yaratıyoruz.
                 helper = new SqlHelper(connectionString);
                 helper.Command.CommandText = string.Format("Select*from {0}", tableName);
                 txtQuery.Text = helper.Command.CommandText;

                 DataTable dt = helper.GetDataTable();
             
                dgvResults.DataSource = dt;//select sorgusunu çalıştırıp datagridde gösterdik.





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            string dbName = cmbDatabases.Text;//databasein adını alıyoruz vede aşağıdada o databese bağlanıyoruz



            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                helper.Command.CommandText = txtQuery.Text;

                DataTable dt = helper.GetDataTable();


                dgvResults.DataSource = dt;//datagridde verieri gösterdik.


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        //item check edildiğinde
        private void clbColumns_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void clbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            




            string dbName = cmbDatabases.Text;//databasein adını alıyoruz vede aşağıdada o databese bağlanıyoruz


            string tableName = cmbTables.Text;


            try
            {
               

                string sorgu = string.Empty; // ""

                string kolonlar = string.Empty; //""


                if (clbColumns.CheckedItems.Count > 0)//eğer checkli kolon varsa aşağıdaki işlemi yap.
                {

                    foreach (object item in clbColumns.CheckedItems)//clbColumns.CheckedItems içerisnde CheckedItem barındıran bir koleksiyondur.clbColumns.CheckedItems[] yazınca içerisine object  aldığını görebiliriz.yani clbColumns.CheckedItems içerisinde object tuttuğunu görüyoruz.foreachtetede zaten object olduğunu belirttik.
                    {
                        kolonlar += string.Format("[{0}],", item.ToString());//checklistboxtaki checkli olan itemi string olarak alırız
                    }

                    kolonlar = kolonlar.TrimEnd(',');//sondaki virgülü sileriz.çünkü yukarıda yaptığımız stringte bir tane virgül sonda kalıyordu.onu sildik.//TrimEnd bizden char tipinde değer istiyordu bizde tek tırnak vererek char tipinde değeri verdik.




                }
                else//eğer checkli kolonlar yoksa * yap.yani select*from Categories gibi
                {
                    kolonlar = "*";
                }


                SqlHelper helper = new SqlHelper(connectionString);
                helper.Command.CommandText = string.Format("Select {0} from {1}", kolonlar, tableName);//Select CategoryID,CategoryName from Categories gibi sorgu cümleciği oluşturur bize
                txtQuery.Text = helper.Command.CommandText;//txtQuerydede sorgumuzu göstersin.


                DataTable dt = helper.GetDataTable();
          


                dgvResults.DataSource = dt;//datagridde verileri gösterdik.


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
