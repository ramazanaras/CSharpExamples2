using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders79_ToDoList_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListeleriDoldur()
        {
            this.clbYapilacaklarListesi.Items.Clear();
            lstTamamlananlarListesi.Items.Clear();

            foreach (TodoItem gorev in Gorevlerim)
            {
                if (gorev.Tamamlandi==false)//eğer  false ise yapılacaklar listesine ekle
                {
                    this.clbYapilacaklarListesi.Items.Add(gorev);//her bir gorevi checklistboxa ekler
                }
                else //true ise tamamlananlar lsitesine ekle.
                {
                    this.lstTamamlananlarListesi.Items.Add(gorev);
                }
             
            }
        }
        private string path = Application.StartupPath + @"\data.xml";
        private List<TodoItem> Gorevlerim = new List<TodoItem>();

        
        private void YapilacaklarListesiKaydet()
        {
            MyXmlSerializer serializer = new MyXmlSerializer();
            serializer.Serialize<List<TodoItem>>(path, this.Gorevlerim);//Nesneleri Xml'e çevirdik. vede verdiğimiz yoldaki(path) xml dosyasına yazıcak.
        }

        private void YapilacaklarListesiOku()
        {
            MyXmlSerializer serializer = new MyXmlSerializer();
            this.Gorevlerim = serializer.Deserialize<List<TodoItem>>(path);//xml'deki verileri oku ve nesne olarak bize geri dönder dedik.

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(path))//dosya varsa işlemleri yap
            {
                this.YapilacaklarListesiOku();//xml dosyasından nesneleri okuyoruz Gorevlerim Listesine nesnelerimiz dolmuş oluyor
            }

     
            this.ListeleriDoldur();//tekrardan checklistboxı dolduruyoruz.
        }
       
        private void btnYeni_Click(object sender, EventArgs e)
        {
            TodoItem yeniGorev = new TodoItem
            {

                Id = Guid.NewGuid(),//benzersiz sayı üretir
                GorevMetni = txtYeniGorev.Text,
                Tamamlandi = false

            };

            this.Gorevlerim.Add(yeniGorev);
            ListeleriDoldur();
            this.YapilacaklarListesiKaydet();//xml dosyasına nesnelerimizi kaydediyoruz.
            //  this.clbYapilacaklarListesi.Items.Add(yeniGorev);//görevi ekledim checklistboxa


            this.notifyIcon1.BalloonTipText = "Yeni Görev oluşturuldu";
            this.notifyIcon1.ShowBalloonTip(2000);//2 saniye görüntülensin
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            if (clbYapilacaklarListesi.SelectedIndex == -1)//birşey seçilmemişse
            {
                MessageBox.Show("Lütfen düzeltme işlemi için bir görev seçiniz");
                return;//direk metotdan çık
            }

            TodoItem gorev = clbYapilacaklarListesi.SelectedItem as TodoItem;//cast ettik

            gorev.GorevMetni = txtYeniGorev.Text;

            ListeleriDoldur();
            this.YapilacaklarListesiKaydet();//xml dosyasına nesnelerimizi kaydediyoruz.
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (clbYapilacaklarListesi.SelectedIndex == -1)//birşey seçilmemişse
            {
                MessageBox.Show("Lütfen silme işlemi için bir görev seçiniz");
                return;//direk metotdan çık
            }
            this.Gorevlerim.Remove((TodoItem)clbYapilacaklarListesi.SelectedItem);

            ListeleriDoldur();
            this.YapilacaklarListesiKaydet();//xml dosyasına nesnelerimizi kaydediyoruz.

            // clbYapilacaklarListesi.Items.Remove(clbYapilacaklarListesi.SelectedItem);//remove metodu bizden object tipinde değer istiyordu clbYapilacaklarListesi.SelectedItem 'da geriye obje dönderdiği için bunu verdik.
        }

        //seçili item değiştiğinde  
        private void clbYapilacaklarListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TodoItem gorev  =(TodoItem)clbYapilacaklarListesi.SelectedItem bu şekildede cast edebilirdik


            if (clbYapilacaklarListesi.SelectedIndex == -1)//seçili index -1 ise return ile metotdan çık dedik yani aşağıdaki kodlar çalışmayacaktır.//silme işleminde sildikten sonra seçili item olmadığı için seçili index -1 oluyordu alt taraftaki koddada seçili item olmadığı için hata veriyordu.
            {
                return;
            }

            TodoItem gorev = clbYapilacaklarListesi.SelectedItem as TodoItem;//cast ettik

            txtYeniGorev.Text = gorev.GorevMetni;//seçilen itemdaki GorevMetnini textboxa yazdık.

        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            txtYeniGorev.Cut();//textboxtaki  yazıyı keser
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            txtYeniGorev.Copy();//textboxtaki  yazıyı kopyalar
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            txtYeniGorev.Paste();//textboxtaki  yazıyı yapıştırır
        }

        //item check edildiğinde
        private void clbYapilacaklarListesi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue==CheckState.Checked)//checklenen item  checklenmiş ise
            {
                TodoItem gorev = (TodoItem)clbYapilacaklarListesi.SelectedItem;
                gorev.Tamamlandi = true;//Tamamlandi'yi true yaptık
                gorev.TamamlanmaTarihi = DateTime.Now;

                ListeleriDoldur();


                YapilacaklarListesiKaydet();
               
              
            }


          
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uygulamaHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 form = new AboutBox1();
            form.ShowDialog();
        }

       
    }
}
