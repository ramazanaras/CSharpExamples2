using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders46_Menuler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {

            //kaydedilmemiş veri varsa kullanıcıya uyarı verilebilir.

            
            //uygulamadan çıkılır.
            Application.Exit();
        }

        private void mnuProje_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbCombobox.SelectedItem.ToString());
        }

        private void cmnuKes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KEsme işlemi yapılır");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
