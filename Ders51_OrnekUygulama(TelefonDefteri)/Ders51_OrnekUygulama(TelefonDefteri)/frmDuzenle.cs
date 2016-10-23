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
    public partial class frmDuzenle : Form
    {
        public frmDuzenle()
        {
            InitializeComponent();
        }

        //global değişken
        public Kisi GuncellenecekKisi { get; set; }//Kisi sınıfı tipinde nesne 

        private void frmDuzenle_Load(object sender, EventArgs e)
        {
            if (this.GuncellenecekKisi!=null)//boş değilse
            {
                //Form1'den aldığımız verileri burda load da gösterdik.
                txtAd.Text = GuncellenecekKisi.Ad;
                txtSoyad.Text = GuncellenecekKisi.Soyad;
                txtTelNo.Text = GuncellenecekKisi.TelefonNo;
            }
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //düzenlenecek verileri Form1'e tekrar yolladık.
            this.GuncellenecekKisi.Ad = this.txtAd.Text;
            this.GuncellenecekKisi.Soyad= this.txtSoyad.Text;
            this.GuncellenecekKisi.TelefonNo= this.txtTelNo.Text;

            this.DialogResult = DialogResult.OK;//kaydete basıldı diyoruz

            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            TextBox txt = this.ActiveControl as TextBox;//ActiveControlu TextBox'a çevirdik.

            if (txt != null)
            {
                txt.Cut();
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
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
