

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;//bu using blogunu kullanabilmemiz için referencelar kısmına BusinessLayer'ı reference olarak ekledik.
using System.Windows.Forms;
using Entities;////bu using blogunu kullanabilmemiz için referencelar kısmına Entities'ı reference olarak ekledik.

//using DataAccessLayer;//DataAccessLayer projesini Masraf Otomasyonu projesine reference olarak eklemiştik burdada using diyerek kullanıyoruz. vede içindeki sınıfları kullanabiliyoruz. Artık işlemleri business layer üzerinden yaptığımız için DataAcceslayerı references kısmından sildik.Arayüz DataAccesslayera bağlı değil artık.işlemler business layer katmanı üzerinden devam edecek.DataAccess layer katmanı business layerla bağlantılı.Business layerda Arayüz katmanı(Ders87Masraf_Otomasyonu) ile bağlantılı



namespace Ders87Masraf_Otomasyonu
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            //if(OnDenetleme())
            if (OnDenetleme() == true)//eğer hata varsa
            {
                return;//hata varsa direk metottan çık aşağıdaki kodları çalıştırma
            }

            PersonelIslemleri pi =new PersonelIslemleri();
            Personel personel = pi.PersoneLogin(txtKullanciAdi.Text,txtSifre.Text);

            if (personel!=null)//eğer boş değilse 
            {
                //Giriş başarılı
                this.Hide();//şuanki formu gizle(giriş formunu)

                frmAnaForm frm = new frmAnaForm();
                frm.GirisYapanPersonel = personel;//formlar arası veri transferi yaptık
                frm.ShowDialog();

                this.Close();//şuanki formuda(giriş formunu) kapat.yada Application.Exitte yazabiliriz.
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı yada Şifre hatalı ","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private bool OnDenetleme()
        {
            bool result = false;//hata yoksa

            errorProvider1.Clear();//eğer ekranda hata gösteriliyorsa bunları temizler.

            string kullaniciAdi = txtKullanciAdi.Text.Trim();//baştaki ve sondaki boşlukları siler
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi))//null yada boşsa
            {
                errorProvider1.SetError(txtKullanciAdi, "Kullanici Adi Boş geçilemez");//SetError bizden iki parametre ister.Birinicisi Control tipinde control ister bizde txtKullanciAdini verdik ,İkinci parametre ise bizden hatanın mesajını ister mesajı verdik.

                result = true;//hata varsa
            }

            if (string.IsNullOrEmpty(sifre))//null yada boşsa
            {
                errorProvider1.SetError(txtSifre, "Şifre Boş geçilemez");
                result = true;//hata varsa
            }



            return result;
        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
