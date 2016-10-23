using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders49_DialogPencereleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFolderDialog_Click(object sender, EventArgs e)//klasör açtırma
        {
            FolderBrowserDialog frm = new FolderBrowserDialog();//(FolderBrowserDialog toolunu sürükleyip bırakmadanda böyle oluşturabiliriz.)
            frm.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);//seçili yol
            DialogResult sonuc = frm.ShowDialog();//dilaog penceresini açtık
            if (sonuc == DialogResult.OK)//tamama basıldıysa
            {
                MessageBox.Show(frm.SelectedPath);//seçilen yolu verir.(seçili yolun bilgisini verir.)
            }
            else
            {

            }

        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)//dosya açtırma
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);//başlangıçtaki seçili yolu verdik.(Resimler yolu)
            ofd.Multiselect = true;//çoklu seçimi açtık
            DialogResult sonuc = ofd.ShowDialog();//dialog penceresini açtık

            if (sonuc == DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName);
            }

        }

        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);//başlangıçtaki seçili yolu verdik.(Resimler yolu)

            DialogResult sonuc = sfd.ShowDialog();//dialog penceresini açtık

            if (sonuc == DialogResult.OK)
            {
                MessageBox.Show(sfd.FileName);
            }
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult sonuc = cd.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                MessageBox.Show(cd.Color.Name);//rengin kodunu verir.
            }

        }

        private void btnFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowEffects = true;
            DialogResult sonuc = fd.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                MessageBox.Show(fd.Font.Name);//seçilen fontun adını alabiliriz.
            }
        }

        private void btnPrintDialog_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            DialogResult sonuc = pd.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                MessageBox.Show(pd.PrinterSettings.PrinterName);//printerın ismi
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult sonuc = fontDialog1.ShowDialog();//direk yukarıdaki gibi sınıf oluşturmadanda açabiliriz.

            if (sonuc == DialogResult.OK)
            {
                MessageBox.Show(fontDialog1.Font.Name);//seçilen fontun adını alabiliriz.
            }
        }
    }
}
