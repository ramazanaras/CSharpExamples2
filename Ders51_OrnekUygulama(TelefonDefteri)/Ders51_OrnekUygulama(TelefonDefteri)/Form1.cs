using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders51_OrnekUygulama_TelefonDefteri_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable("Kisiler");//isim verdik

            //DataColumn dcId = new DataColumn("ID");//kolon oluşturduk ve adını verdik
            //DataColumn dcAd = new DataColumn("Ad");//kolon adı verdik
            //DataColumn dcSoyad = new DataColumn("Soyad");//kolon oluşturduk ve adını verdik
            //DataColumn dcTelNo = new DataColumn("TelefonNo");//kolon oluşturduk ve adını verdik

            //dt.Columns.Add(dcId);
            //dt.Columns.Add(dcAd);
            //dt.Columns.Add(dcSoyad);
            //dt.Columns.Add(dcTelNo);

            //ds.Tables.Add(dt);//datatable'ı datasete aktardık
                
            //this.dataGridView1.DataSource = dt;//datagridview'e datatableyı ekledik.


            //Daha önce Eklemiş olduğumuz tabloyu okuduk yani  xml'i okuduk
            ds.Tables.Clear();
            ds.ReadXml(Application.StartupPath + "\\" + "data.xml", XmlReadMode.ReadSchema);//ds'nin tables'larında bir tane tablo var artık

            if (ds.Tables.Count>0)//yani bir tablo oluşmussa
            {
                this.dataGridView1.DataSource = ds.Tables[0];
                KayitSayisiniHesaplama();
                this.lblSonIslemBilgi.Text = "Veriler Yüklendi";
            }

        }

        private DataSet ds = new DataSet();//veritabanının nesnelendirilmiş hali gibi birşey.Dataset içinde birden fazla datatable tutar.DataSet içinde bir sürü tablo tutar.

        private void btnKaydet_Click(object sender, EventArgs e)//tabloları xml'e kaydetme işlemi.
        {
            //uygulamanın yoluna data.xml adında bir dosya oluşturup tabloyu oraya kaydeder.
            ds.WriteXml(Application.StartupPath + "\\" + "data.xml", XmlWriteMode.WriteSchema);//data.xml dosyasının içine ds'nin içindeki tabloyu kaydediyor.
        }

        private void KayitSayisiniHesaplama() 
        {
            //kaç kayıt var buluyoruz.
            this.lblKayitSayisi.Text="Kayıt Sayısı: "+this.dataGridView1.RowCount.ToString();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            frmYeniKayit frm = new frmYeniKayit();  
           DialogResult sonuc= frm.ShowDialog();//frmYenikayit formundan buraya DialogResult'lardan OK yada cancel gönderdik duruma göre aşağıda kullanıyoruz.

           if (sonuc==DialogResult.OK)
           {
               Kisi yeniKisi = frm.YeniKisi;//frmYeniKayit formundaki Kisi sınıfı tipindeki değeri(YeniKisi)yi aldık.

               DataTable dt = this.dataGridView1.DataSource as DataTable;//dataGridView1'deki formun loadında eklediğimiz datatable'ı tekrar çıkardık(unboxing ettik.)//cast ettik.

               DataRow dr = dt.NewRow();//yeni bir saatır oluşturduk
               //değerleri atadık(YeniKisi nesnesindeki(diğer formda girdiğimiz değerler) değerleri burda satırlara aktardık)
               dr[0] = yeniKisi.Id;//1.kolona ait veri
               dr[1] = yeniKisi.Ad;//2.kolona ait veri
               dr[2] = yeniKisi.Soyad;//3.kolona ait veri
               dr[3] = yeniKisi.TelefonNo;//4.kolona ait veri


               dt.Rows.Add(dr);//datatable'a satırlarıda ekledik.
               KayitSayisiniHesaplama();//kaç kayıt var buluyoruz
               this.lblSonIslemBilgi.Text = "YEni kayıt eklendi";
           }


        }

       

        private void btnKayitDuzenle_Click(object sender, EventArgs e)
        {
            //currrentRow :seçili(şuanki satır)
            if (this.dataGridView1.CurrentRow!=null)//yani bir satır seçilmişsse
            {
               

                frmDuzenle frm = new frmDuzenle();
                frm.GuncellenecekKisi = new Kisi();//balonu şişirdik yoksa değer atarken hata verirdi.
                //seçili satırdaki bilgileri aldık
                frm.GuncellenecekKisi.Ad = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.GuncellenecekKisi.Soyad = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.GuncellenecekKisi.TelefonNo = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                
               DialogResult sonuc= frm.ShowDialog();
               if (sonuc==DialogResult.OK)
               {
                   //seçili satırı DataRow tipinde alma işlemleri yaptık iki satırda
                   DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                   DataRow dr = drv.Row;

                   //seçili satırı güncelledik.
                   dr[1] = frm.GuncellenecekKisi.Ad;//1.kolona ait veri
                   dr[2] = frm.GuncellenecekKisi.Soyad;//2.kolona ait veri
                   dr[3] = frm.GuncellenecekKisi.TelefonNo;//3.kolona ait veri

                   this.lblSonIslemBilgi.Text = "kayıt düzenlendi";
               }

            }
        }

        private void btnKayitSilme_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow != null)//eğer datagridviewde seçili satır varsa işlemleri yap
            {
                DialogResult sonuc = MessageBox.Show("Seçili kaydı silmek istediğinizden eminmisiniz", "Kayıt Silme işlemi", MessageBoxButtons.YesNoCancel);
                if (sonuc == DialogResult.Yes)
                {
                    //seçili satırı DataRow tipinde alma işlemleri yaptık iki satırda
                    DataRowView drv = this.dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                    DataRow dr = drv.Row;

                    dr.Delete();//satırı siler.
                    KayitSayisiniHesaplama();//kaç kayıt var buluyoruz

                    this.lblSonIslemBilgi.Text = "kayıt silme işlemi  yapıldı";
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //interval 1000=1 saniye

            this.lblSaat.Text = DateTime.Now.ToLongTimeString();//saat dakika saniye gösterir

        
        }

        private void mnuYenile_Click(object sender, EventArgs e)
        {
            //Daha önce Eklemiş olduğumuz tabloyu okuduk yani  xml'i okuduk
            ds.Tables.Clear();
            ds.ReadXml(Application.StartupPath + "\\" + "data.xml", XmlReadMode.ReadSchema);//ds'nin tables'larında bir tane tablo var artık

            if (ds.Tables.Count > 0)//yani bir tablo oluşmussa
            {
                this.dataGridView1.DataSource = ds.Tables[0];
                KayitSayisiniHesaplama();
                this.lblSonIslemBilgi.Text = "Veriler Yüklendi";
            }
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();//programdan çıkar.
        }

        private void mnuProgramBilgi_Click(object sender, EventArgs e)
        {
            frmHakkinda frm = new frmHakkinda();
            frm.ShowDialog();
        }

       


    }
}
