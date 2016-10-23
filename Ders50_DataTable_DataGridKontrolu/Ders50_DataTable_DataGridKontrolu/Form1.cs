using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders50_DataTable_DataGridKontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerileriDoldur_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            DataColumn dc1 = new DataColumn("Ad");//1.kolon
            DataColumn dc2 = new DataColumn("Soyad");//2.kolon

            dt.Columns.Add(dc1);//dt.Columns içinde DataColumn barındıran bir koleksiyondur(DataColumnCollection) bizde içerisine DataColumn tipinde bir değer verdik.
            dt.Columns.Add(dc2);


            DataRow dr1 = dt.NewRow();//yeni bir satır oluşturuyor.
            dr1[0] = "Murat";//1.kolon ait veri 
            dr1[1] = "başeren";//2.kolona ait veri

            dt.Rows.Add(dr1);//artık tabloya satırıda ekledik.//dt.Rows DataRow barındıran bir koleksiyondur(DataRowCollection) bizde içine DataRow tipinde bir değer verdik.

            DataRow dr2 = dt.NewRow();//ikinci satırıda oluşturduk
            dr2[0] = "Ramazan";
            dr2[1] = "Aras";

            dt.Rows.Add(dr2);//ikinci satırıda tabloya ekledik.

            dt.AcceptChanges();//verileri onayladık

            this.dataGridView1.DataSource = dt;//datagridview'de datatable görüntülenecek
        }

        private void btnVerileriOku_Click(object sender, EventArgs e)
        {
            //current row seçili satır demek 
            if (this.dataGridView1.CurrentRow != null)//satır seçilmişse işlem yapar
            {
                MessageBox.Show(this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + " " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString()); //CurrentRow.Cells bir koleksiyondur(hücre koleksiyonu) ve bizde ilk hücreyi okuduk//objeyi birde tostringle dönüştürdük.

                if (dataGridView1.CurrentCell != null)//bir hücre seçilmişse
                {
                    //CurrentCell seçili hücre demek
                    MessageBox.Show(this.dataGridView1.CurrentCell.Value.ToString());//seçili hücreyi okuduk
                }
            }

        }

        private void btnYeniVerileriGetir_Click(object sender, EventArgs e)
        {
            //tekrar datatableyi getirdik.
            DataTable dt = this.dataGridView1.DataSource as DataTable; //cast ettik// DataTable dt =(DataTable)this.dataGridView1.DataSource ; bu şekildede cast edebilirdik.//unboxing


            //yeni eklenmiş satırları aldık(GetChanges ile)
            DataTable dtYeniSatirlar = dt.GetChanges(DataRowState.Added);//DataRowState(sarı renkli)bir enumdur //GetChanges bir datatable döner geriye

            if (dtYeniSatirlar != null)//yani yeni satır varsa aşağıdaki işlemleri yap
            {
                foreach (DataRow dr in dtYeniSatirlar.Rows)//koleksiyonda(dtYeniSatirlar.Rows) dolaş içinde DataRow' tipinde değerler var
                {
                    MessageBox.Show(dr[0].ToString() + " " + dr[1].ToString());
                }

                dt.AcceptChanges();//verileri(tabloyu) onayladık(yani yeni verileri onayladık yeni gelecek verilere bakıcaz artık)
            }

        }

        private void btnGuncellenenSatirlar_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dataGridView1.DataSource as DataTable;//cast ettik.//unboxing

            //değişiklik yapılmış satırları aldık(GetChanges)
            DataTable dtGuncellenenSatirlar = dt.GetChanges(DataRowState.Modified);

            if (dtGuncellenenSatirlar!=null)//güncellenen satır varsa işlemleri yap
            {
                foreach (DataRow dr in dtGuncellenenSatirlar.Rows)
                {
                    //MessageBox.Show(dr[0].ToString()+" "+dr[1].ToString());/değişiklik yapılmış veriler

                    MessageBox.Show("Orjinal hali(eski hali) "+
                        dr[0,DataRowVersion.Original].ToString() + " " + dr[1,DataRowVersion.Original].ToString()+ "\n"+
                        "Şuanki değer "+
                        dr[0].ToString() + " " + dr[1].ToString()
                        
                        
                        );
                }
            
            dt.AcceptChanges();//verileri onayladık.
            }


        }

        private void btnSilinenVerileriGetir_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dataGridView1.DataSource as DataTable;//cast ettik.//unboxing

            //silinmiş  satırları aldık(GetChanges)
            DataTable dtSilinenSatirlar = dt.GetChanges(DataRowState.Deleted);

            if (dtSilinenSatirlar != null)//güncellenen satır varsa işlemleri yap
            {
                foreach (DataRow dr in dtSilinenSatirlar.Rows)
                {
                  

                    MessageBox.Show("Silinen Satır " +
                        dr[0, DataRowVersion.Original].ToString() + " " + dr[1, DataRowVersion.Original].ToString());
                }

                dt.AcceptChanges();//verileri onayladık.

               
            }
        }
    }
}