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
    public partial class frmYeniKayit : Form
    {
        
        public frmYeniKayit()
        {
            InitializeComponent();
        }


        //global'de tanımladık.
        public Kisi YeniKisi { get; set; } //Kisi sınıfından bir nesne oluşturduk.


        private void btnKaydet_Click(object sender, EventArgs e)
        {


            this.YeniKisi = new Kisi();//balonu şişirdik(yani içine değerleri atabiliriz.)

            this.YeniKisi.Id = Guid.NewGuid();//id otomatikmen farklı bir sayı oluşturacak.
            this.YeniKisi.Ad = this.txtAd.Text;
            this.YeniKisi.Soyad = this.txtSoyad.Text;
            this.YeniKisi.TelefonNo = this.txtTelNo.Text;

            this.DialogResult = DialogResult.OK;//diğer formda bu OK kullanılacak ya o yüzden yaptık
            this.Close();//formu kapat.

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;//diğer formda bu OK kullanılacak ya o yüzden yaptık
            this.Close();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            TextBox txt = this.ActiveControl as TextBox;//ActiveControlu TextBox'a çevirdik.

            if (txt!=null)
            {
                txt.Cut();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            //active textbox üzerinde işlemler yapıyoruz.
            TextBox txt = this.ActiveControl as TextBox;//ActiveControlu TextBox'a çevirdik.

            if (txt != null)
            {
                txt.Copy();
            }
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            TextBox txt = this.ActiveControl as TextBox;//ActiveControlu TextBox'a çevirdik.

            if (txt != null)
            {
                txt.Paste();
            }
        }
    }
}
