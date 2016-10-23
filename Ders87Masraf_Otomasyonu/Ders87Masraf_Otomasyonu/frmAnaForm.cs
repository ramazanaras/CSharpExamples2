using BusinessLayer;
using Entities;
using Entities.Enums;//Enities katmanındaki Enums klasörü
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders87Masraf_Otomasyonu
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        private MasrafIslemleri MI = new MasrafIslemleri();
        private PersonelIslemleri PI = new PersonelIslemleri();



        //giriş yapan personelin bilgileri tutulacak.//giriş formundan gelen nesneyi  burada kullancaz.
        public Personel GirisYapanPersonel { get; set; }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            //Giriş yapan personelin adını sağ köşedeki labela yazdırdık
            lblPersonelAdSoyad.Text = GirisYapanPersonel.Adi + " " + GirisYapanPersonel.Soyadi+"( "+PersonelTuruEnumHelper.GetText(GirisYapanPersonel.PersonelTurId)+")" ;

            //masrafları listeledik.
            GetirPersonelMasraflari();

            GetirPersonelSorumluListe();


        }

        private void GetirPersonelSorumluListe()
        {
            List<Personel> masrafSahipleri = new List<Personel>();

            if (GirisYapanPersonel.PersonelTurId!=(byte)PersonelTuruEnum.Muhasebe)//bağlanan kişi muhasebeci değilse
            {
                masrafSahipleri.Add(GirisYapanPersonel);

                masrafSahipleri.AddRange(PI.GetirPersonelBySorumluId(GirisYapanPersonel.Id));//AddRange içerisine bir Liste alır.(yada dizi verebiliriz.)
            }
            else//giriş yapan Muhasebeci ise tü personelleri getirecez.
            {
                masrafSahipleri.AddRange(PI.GetirTumPersonel());
            }


            cmbMasrafSahibi.DataSource = masrafSahipleri;//combobaxa masraf sahiplerini ekledik.
        }

        private void GetirPersonelMasraflari()
        {

            if (cmbMasrafSahibi.SelectedIndex>-1)//bir şey seçilmişse
            {
                Personel personel = cmbMasrafSahibi.SelectedItem as Personel;


                List<Masraf> masraflar = MI.GetirMasraflar(personel.Id);

                lstMasraflar.DataSource = masraflar;//listboxa değerleri veriyoruz.
            }
          
         
        }

        private void btnMasrafEkle_Click(object sender, EventArgs e)
        {
            //Masraf Eklenmesi

            Masraf masraf = new Masraf
            {
                Id = Guid.NewGuid(),//benzersiz sayı ürettik.
                Baslik = txtBaslik.Text,
                Tarih = dtpTarih.Value,
                Tutar = nudTutar.Value,
                Aciklama = txtAciklama.Text,
                PersonelId = GirisYapanPersonel.Id,//Giriş yapan personelin idsini verdik.
                DurumId = (byte)DurumEnum.OnayBekliyor,//enumu byte 'a cast ettik. //1 değerini DurumId'ye atamış oluyoruz.


            };


            if (GirisYapanPersonel.PersonelTurId==(byte)PersonelTuruEnum.Yonetici)//giriş yapan personel yönetici ise onun masraflarını direk onaylandıya çevir.
            {
                masraf.DurumId = (byte)DurumEnum.Onaylandı;
            }


            int sonuc = MI.MasrafEkle(masraf);

            if (sonuc > 0)
            {
                MessageBox.Show("Masraf eklendi");

                //Masrafları tekrar listele
                GetirPersonelMasraflari();


            }
            else
            {
                MessageBox.Show("Masraf Eklenemedi");
            }

        }


        //bir item seçildiğinde 
        private void lstMasraflar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)//hiçbir şey seçili değil demektir.direk metotta çık dedik .aşağıdaki kodları çalıştırma
            {
                return;//direk metottan çık
            }
            //  Masraf masraf = (Masraf)lstMasraflar.SelectedItem  ;//bu şekildede cast edebiliriz.
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;//cast ettik.



            if (masraf != null)
            {
                txtBaslik.Text = masraf.Baslik;
                txtAciklama.Text = masraf.Aciklama;
                dtpTarih.Value = masraf.Tarih;
                nudTutar.Value = masraf.Tutar;
            }

            if (masraf.DurumId == (byte)DurumEnum.Reddedildi || masraf.DurumId == (byte)DurumEnum.Odendi)
            {
                btnMasrafKaydet.Enabled = false;//butonu tıklanamaz yap.
               

            }
            else
            {
                btnMasrafKaydet.Enabled = true;
              
            }

           

            if (masraf.DurumId == (byte)DurumEnum.Odendi)
            {
                btnMasrafSil.Enabled = false;//butonu tıklanamaz yap.

                
            }
            else
            {
                btnMasrafSil.Enabled = true;
               
            }


            if (masraf.DurumId == (byte)DurumEnum.Onaylandı)
            {
                cmnuOdendi.Enabled = true;
            }
            else
            {
                cmnuOdendi.Enabled = false;
            }

        }

        private void btnMasrafKaydet_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)//hiçbir şey seçili değil demektir.direk metotta çık dedik .aşağıdaki kodları çalıştırma
            {
                MessageBox.Show("Lütfen kaydetme işlemi için bir masraf seçiniz");
                return;//direk metottan çık
            }

            //  Masraf masraf = (Masraf)lstMasraflar.SelectedItem  ;//bu şekildede cast edebiliriz.
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;//cast ettik.
            masraf.Baslik = txtBaslik.Text;
            masraf.Aciklama = txtAciklama.Text;
            masraf.Tarih = dtpTarih.Value;
            masraf.Tutar = nudTutar.Value;

            masraf.DurumId = (byte)DurumEnum.OnayBekliyor;


            if (GirisYapanPersonel.PersonelTurId == (byte)PersonelTuruEnum.Yonetici)//giriş yapan personel yönetici ise onun masraflarını direk onaylandıya çevir.
            {
                masraf.DurumId = (byte)DurumEnum.Onaylandı;
            }




            int etkilenen = MI.MasrafGuncelle(masraf);//masrafı güncelliyoruz
            if (etkilenen > 0)
            {

                MessageBox.Show("Güncelleme başarılı");

                //Masrafları tekrar listele
                GetirPersonelMasraflari();


            }
            else
            {
                MessageBox.Show("Güncelleme başarısız");

            }


        }

        //listboxa her bir item eklenirekn bu metot çalışır ve listboxta yazının nasıl görüneceğini belirler.(ikinci bir yol olarak Masraf classında override yaparakta yapabilirdik.)
        private void lstMasraflar_Format(object sender, ListControlConvertEventArgs e)
        {

            Masraf masraf = e.ListItem as Masraf;//e.ListItem'da Masraf nesnesi tutuluyor.bizde cast ederek aldık.
            e.Value = string.Format("{0} ({1})", masraf.Baslik, DurumEnumHelper.GetDurumText(masraf.DurumId));
        }

        private void btnMasrafSil_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)//hiçbir şey seçili değil demektir.direk metotta çık dedik .aşağıdaki kodları çalıştırma
            {
                MessageBox.Show("Lütfen silme işlemi için bir masraf seçiniz");
                return;//direk metottan çık
            }

            Masraf masraf = lstMasraflar.SelectedItem as Masraf;//cast ettik.



            //DialogResult bir enumdur(sarı renkli zaten)//MessageBox.Show geriye DialogResult tipinde değer dönderir.
            DialogResult result = MessageBox.Show(masraf.Baslik + " baslikli masraf silinsin mi?", "Masraf Silme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);

            if (result == DialogResult.Yes)//Yes'e basarsak masrafı sileriz
            {
                int etkilenen = MI.MasrafSil(masraf);

                if (etkilenen > 0)
                {
                    MessageBox.Show("Masraf Silme başarılı");

                    //Masrafları tekrar listele
                    GetirPersonelMasraflari();
                }
                else
                {
                    MessageBox.Show("Masraf Silme başarısız");
                }
            }







        }

        //combobaxa her bir item eklenirekn bu metot çalışır ve combobaxta yazının nasıl görüneceğini belirler.
        private void cmbMasrafSahibi_Format(object sender, ListControlConvertEventArgs e)
        {
            Personel personel = e.ListItem as Personel;//e.ListItem'da Personel nesnesi tutuluyor.bizde cast ederek aldık.
            e.Value = string.Format("{0} {1}", personel.Adi, personel.Soyadi);//combobaxta Adı Soyadı şeklinde gözükür.mesela Ramazan Aras
        }

        private void cmbMasrafSahibi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMasrafSahibi.SelectedIndex > -1)//bir şey seçilmişse bu işlemleri yap.
            {


                Personel personel = cmbMasrafSahibi.SelectedItem as Personel;

                if (personel.Id==GirisYapanPersonel.Id)//eğer seçili personel giriş yapan personel ise
                {
                    flpDugmeler.Enabled = true;//butonlar gözükecek yani aktif

                    lstMasraflar.ContextMenuStrip = null;//masraf sahibi bensem contextmenustrip çıkmamalı
                }
                else
                {
                    flpDugmeler.Enabled = false;//butonlar gözükmeyecek yani pasif
                    lstMasraflar.ContextMenuStrip = cmnuMasrafYonet;//masraf sahibi ben değilsem altımdaki kişi ise contextmenustrip çıkmalı
                }



                if (GirisYapanPersonel.PersonelTurId==(byte)PersonelTuruEnum.Muhasebe)//muhasebeci giriş yapmışsa contextmenuyu cmnuMuhasebe contextmenusu olarak ayarla.
                {
                    lstMasraflar.ContextMenuStrip = cmnuMuhasebe;
                }


                List<Masraf> masraflar = MI.GetirMasraflar(personel.Id);

                lstMasraflar.DataSource = masraflar;



            }





        }

        private void cmnuOnayla_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)//hiçbir şey seçili değil demektir.direk metotta çık dedik .aşağıdaki kodları çalıştırma
            {
                MessageBox.Show("Lütfen onaylama işlemi için bir masraf seçiniz");
                return;//direk metottan çık
            }

            //  Masraf masraf = (Masraf)lstMasraflar.SelectedItem  ;//bu şekildede cast edebiliriz.
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;//cast ettik.
          

            masraf.DurumId = (byte)DurumEnum.Onaylandı;//sadece durumu güncelliyoruz.


            int etkilenen = MI.MasrafGuncelle(masraf);//masrafı güncelliyoruz
            if (etkilenen > 0)
            {

                MessageBox.Show("Onaylama başarılı");

                //Masrafları tekrar listele
                GetirPersonelMasraflari();


            }
            else
            {
                MessageBox.Show("Masraf durumu değiştirilemedi");

            }
        }

        private void cmnuGuncellenmeli_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)//hiçbir şey seçili değil demektir.direk metotta çık dedik .aşağıdaki kodları çalıştırma
            {
                MessageBox.Show("Lütfen güncelleme işlemi için bir masraf seçiniz");
                return;//direk metottan çık
            }

            //  Masraf masraf = (Masraf)lstMasraflar.SelectedItem  ;//bu şekildede cast edebiliriz.
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;//cast ettik.


            masraf.DurumId = (byte)DurumEnum.Duzeltilecek;//sadece durumu güncelliyoruz.


            int etkilenen = MI.MasrafGuncelle(masraf);//masrafı güncelliyoruz
            if (etkilenen > 0)
            {

                MessageBox.Show("güncelleme başarılı");

                //Masrafları tekrar listele
                GetirPersonelMasraflari();


            }
            else
            {
                MessageBox.Show("Masraf durumu değiştirilemedi");

            }
        }

        private void cmnuReddet_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)//hiçbir şey seçili değil demektir.direk metotta çık dedik .aşağıdaki kodları çalıştırma
            {
                MessageBox.Show("Lütfen reddetme işlemi için bir masraf seçiniz");
                return;//direk metottan çık
            }

            //  Masraf masraf = (Masraf)lstMasraflar.SelectedItem  ;//bu şekildede cast edebiliriz.
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;//cast ettik.


            masraf.DurumId = (byte)DurumEnum.Reddedildi;//sadece durumu güncelliyoruz.


            int etkilenen = MI.MasrafGuncelle(masraf);//masrafı güncelliyoruz
            if (etkilenen > 0)
            {

                MessageBox.Show("Reddetme başarılı");

                //Masrafları tekrar listele
                GetirPersonelMasraflari();


            }
            else
            {
                MessageBox.Show("Masraf durumu değiştirilemedi");

            }
        }

        private void cmnuOdendi_Click(object sender, EventArgs e)
        {
            if (lstMasraflar.SelectedIndex == -1)//hiçbir şey seçili değil demektir.direk metotta çık dedik .aşağıdaki kodları çalıştırma
            {
                MessageBox.Show("Lütfen ödeme onayı işlemi için bir masraf seçiniz");
                return;//direk metottan çık
            }

            //  Masraf masraf = (Masraf)lstMasraflar.SelectedItem  ;//bu şekildede cast edebiliriz.
            Masraf masraf = lstMasraflar.SelectedItem as Masraf;//cast ettik.


            masraf.DurumId = (byte)DurumEnum.Odendi;//sadece durumu güncelliyoruz.


            int etkilenen = MI.MasrafGuncelle(masraf);//masrafı güncelliyoruz
            if (etkilenen > 0)
            {

                MessageBox.Show("güncelleme başarılı");

                //Masrafları tekrar listele
                GetirPersonelMasraflari();


            }
            else
            {
                MessageBox.Show("Masraf durumu değiştirilemedi");

            }
        }
    }
}
