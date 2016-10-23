namespace Ders87Masraf_Otomasyonu
{
    partial class frmAnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpMasrafDetaylar = new System.Windows.Forms.GroupBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.nudTutar = new System.Windows.Forms.NumericUpDown();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.flpDugmeler = new System.Windows.Forms.FlowLayoutPanel();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnMasrafEkle = new System.Windows.Forms.Button();
            this.btnMasrafKaydet = new System.Windows.Forms.Button();
            this.btnMasrafSil = new System.Windows.Forms.Button();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPersonelAdSoyad = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbMasrafSahibi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMasraflar = new System.Windows.Forms.ListBox();
            this.cmnuMasrafYonet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuOnayla = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuGuncellenmeli = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuReddet = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMuhasebe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuOdendi = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpMasrafDetaylar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).BeginInit();
            this.flpDugmeler.SuspendLayout();
            this.mnuTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.cmnuMasrafYonet.SuspendLayout();
            this.cmnuMuhasebe.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpMasrafDetaylar);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.mnuTop);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(781, 481);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpMasrafDetaylar
            // 
            this.grpMasrafDetaylar.Controls.Add(this.txtAciklama);
            this.grpMasrafDetaylar.Controls.Add(this.flpDugmeler);
            this.grpMasrafDetaylar.Controls.Add(this.lblAciklama);
            this.grpMasrafDetaylar.Controls.Add(this.nudTutar);
            this.grpMasrafDetaylar.Controls.Add(this.lblTutar);
            this.grpMasrafDetaylar.Controls.Add(this.txtBaslik);
            this.grpMasrafDetaylar.Controls.Add(this.lblBaslik);
            this.grpMasrafDetaylar.Controls.Add(this.dtpTarih);
            this.grpMasrafDetaylar.Controls.Add(this.lblTarih);
            this.grpMasrafDetaylar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMasrafDetaylar.Location = new System.Drawing.Point(10, 10);
            this.grpMasrafDetaylar.Name = "grpMasrafDetaylar";
            this.grpMasrafDetaylar.Padding = new System.Windows.Forms.Padding(10);
            this.grpMasrafDetaylar.Size = new System.Drawing.Size(274, 461);
            this.grpMasrafDetaylar.TabIndex = 0;
            this.grpMasrafDetaylar.TabStop = false;
            this.grpMasrafDetaylar.Text = "Masraf Detayları";
            // 
            // lblTarih
            // 
            this.lblTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTarih.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(10, 23);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblTarih.Size = new System.Drawing.Size(254, 23);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(10, 46);
            this.dtpTarih.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpTarih.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(254, 20);
            this.dtpTarih.TabIndex = 1;
            // 
            // lblBaslik
            // 
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(10, 66);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblBaslik.Size = new System.Drawing.Size(254, 23);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Baslik";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBaslik.Location = new System.Drawing.Point(10, 89);
            this.txtBaslik.MaxLength = 50;
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(254, 20);
            this.txtBaslik.TabIndex = 3;
            // 
            // lblTutar
            // 
            this.lblTutar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTutar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(10, 109);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblTutar.Size = new System.Drawing.Size(254, 23);
            this.lblTutar.TabIndex = 4;
            this.lblTutar.Text = "Tutar";
            this.lblTutar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nudTutar
            // 
            this.nudTutar.DecimalPlaces = 2;
            this.nudTutar.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudTutar.Location = new System.Drawing.Point(10, 132);
            this.nudTutar.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            131072});
            this.nudTutar.Name = "nudTutar";
            this.nudTutar.Size = new System.Drawing.Size(254, 20);
            this.nudTutar.TabIndex = 5;
            // 
            // lblAciklama
            // 
            this.lblAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAciklama.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(10, 152);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblAciklama.Size = new System.Drawing.Size(254, 23);
            this.lblAciklama.TabIndex = 6;
            this.lblAciklama.Text = "Açıklama";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // flpDugmeler
            // 
            this.flpDugmeler.Controls.Add(this.btnMasrafEkle);
            this.flpDugmeler.Controls.Add(this.btnMasrafKaydet);
            this.flpDugmeler.Controls.Add(this.btnMasrafSil);
            this.flpDugmeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpDugmeler.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpDugmeler.Location = new System.Drawing.Point(10, 402);
            this.flpDugmeler.Name = "flpDugmeler";
            this.flpDugmeler.Size = new System.Drawing.Size(254, 49);
            this.flpDugmeler.TabIndex = 7;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAciklama.Location = new System.Drawing.Point(10, 175);
            this.txtAciklama.MaxLength = 150;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(254, 227);
            this.txtAciklama.TabIndex = 8;
            // 
            // btnMasrafEkle
            // 
            this.btnMasrafEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasrafEkle.Image = global::Ders87Masraf_Otomasyonu.Properties.Resources._1477164103_f_check_256;
            this.btnMasrafEkle.Location = new System.Drawing.Point(177, 3);
            this.btnMasrafEkle.Name = "btnMasrafEkle";
            this.btnMasrafEkle.Size = new System.Drawing.Size(74, 40);
            this.btnMasrafEkle.TabIndex = 0;
            this.btnMasrafEkle.Text = "Ekle";
            this.btnMasrafEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasrafEkle.UseVisualStyleBackColor = true;
            this.btnMasrafEkle.Click += new System.EventHandler(this.btnMasrafEkle_Click);
            // 
            // btnMasrafKaydet
            // 
            this.btnMasrafKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasrafKaydet.Image = global::Ders87Masraf_Otomasyonu.Properties.Resources._1477177919_floppy;
            this.btnMasrafKaydet.Location = new System.Drawing.Point(88, 3);
            this.btnMasrafKaydet.Name = "btnMasrafKaydet";
            this.btnMasrafKaydet.Size = new System.Drawing.Size(83, 40);
            this.btnMasrafKaydet.TabIndex = 1;
            this.btnMasrafKaydet.Text = "Kaydet";
            this.btnMasrafKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasrafKaydet.UseVisualStyleBackColor = true;
            this.btnMasrafKaydet.Click += new System.EventHandler(this.btnMasrafKaydet_Click);
            // 
            // btnMasrafSil
            // 
            this.btnMasrafSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasrafSil.Image = global::Ders87Masraf_Otomasyonu.Properties.Resources._1477177998_f_cross_256;
            this.btnMasrafSil.Location = new System.Drawing.Point(8, 3);
            this.btnMasrafSil.Name = "btnMasrafSil";
            this.btnMasrafSil.Size = new System.Drawing.Size(74, 40);
            this.btnMasrafSil.TabIndex = 2;
            this.btnMasrafSil.Text = "Sil";
            this.btnMasrafSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasrafSil.UseVisualStyleBackColor = true;
            this.btnMasrafSil.Click += new System.EventHandler(this.btnMasrafSil_Click);
            // 
            // mnuTop
            // 
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPersonelAdSoyad});
            this.mnuTop.Location = new System.Drawing.Point(6, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Size = new System.Drawing.Size(477, 24);
            this.mnuTop.TabIndex = 0;
            this.mnuTop.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstMasraflar);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(477, 457);
            this.panel1.TabIndex = 1;
            // 
            // lblPersonelAdSoyad
            // 
            this.lblPersonelAdSoyad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblPersonelAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPersonelAdSoyad.Name = "lblPersonelAdSoyad";
            this.lblPersonelAdSoyad.Size = new System.Drawing.Size(115, 20);
            this.lblPersonelAdSoyad.Text = "PersonelAdSoyad";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmbMasrafSahibi);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(457, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cmbMasrafSahibi
            // 
            this.cmbMasrafSahibi.FormattingEnabled = true;
            this.cmbMasrafSahibi.Location = new System.Drawing.Point(191, 3);
            this.cmbMasrafSahibi.Name = "cmbMasrafSahibi";
            this.cmbMasrafSahibi.Size = new System.Drawing.Size(263, 21);
            this.cmbMasrafSahibi.TabIndex = 0;
            this.cmbMasrafSahibi.SelectedIndexChanged += new System.EventHandler(this.cmbMasrafSahibi_SelectedIndexChanged);
            this.cmbMasrafSahibi.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbMasrafSahibi_Format);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masraf Sahibi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstMasraflar
            // 
            this.lstMasraflar.ContextMenuStrip = this.cmnuMasrafYonet;
            this.lstMasraflar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMasraflar.FormattingEnabled = true;
            this.lstMasraflar.Location = new System.Drawing.Point(10, 42);
            this.lstMasraflar.Name = "lstMasraflar";
            this.lstMasraflar.Size = new System.Drawing.Size(457, 405);
            this.lstMasraflar.TabIndex = 1;
            this.lstMasraflar.SelectedIndexChanged += new System.EventHandler(this.lstMasraflar_SelectedIndexChanged);
            this.lstMasraflar.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstMasraflar_Format);
            // 
            // cmnuMasrafYonet
            // 
            this.cmnuMasrafYonet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuOnayla,
            this.cmnuGuncellenmeli,
            this.cmnuReddet});
            this.cmnuMasrafYonet.Name = "cmnuMasrafYonet";
            this.cmnuMasrafYonet.Size = new System.Drawing.Size(151, 70);
            // 
            // cmnuOnayla
            // 
            this.cmnuOnayla.Name = "cmnuOnayla";
            this.cmnuOnayla.Size = new System.Drawing.Size(150, 22);
            this.cmnuOnayla.Text = "Onayla";
            this.cmnuOnayla.Click += new System.EventHandler(this.cmnuOnayla_Click);
            // 
            // cmnuGuncellenmeli
            // 
            this.cmnuGuncellenmeli.Name = "cmnuGuncellenmeli";
            this.cmnuGuncellenmeli.Size = new System.Drawing.Size(150, 22);
            this.cmnuGuncellenmeli.Text = "Güncellenmeli";
            this.cmnuGuncellenmeli.Click += new System.EventHandler(this.cmnuGuncellenmeli_Click);
            // 
            // cmnuReddet
            // 
            this.cmnuReddet.Name = "cmnuReddet";
            this.cmnuReddet.Size = new System.Drawing.Size(150, 22);
            this.cmnuReddet.Text = "Reddet";
            this.cmnuReddet.Click += new System.EventHandler(this.cmnuReddet_Click);
            // 
            // cmnuMuhasebe
            // 
            this.cmnuMuhasebe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuOdendi});
            this.cmnuMuhasebe.Name = "cmnuMuhasebe";
            this.cmnuMuhasebe.Size = new System.Drawing.Size(153, 48);
            // 
            // cmnuOdendi
            // 
            this.cmnuOdendi.Name = "cmnuOdendi";
            this.cmnuOdendi.Size = new System.Drawing.Size(152, 22);
            this.cmnuOdendi.Text = "Ödendi";
            this.cmnuOdendi.Click += new System.EventHandler(this.cmnuOdendi_Click);
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 481);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuTop;
            this.Name = "frmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masraf Otomasyonu:Masraflar";
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpMasrafDetaylar.ResumeLayout(false);
            this.grpMasrafDetaylar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).EndInit();
            this.flpDugmeler.ResumeLayout(false);
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.cmnuMasrafYonet.ResumeLayout(false);
            this.cmnuMuhasebe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpMasrafDetaylar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.FlowLayoutPanel flpDugmeler;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.NumericUpDown nudTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Button btnMasrafEkle;
        private System.Windows.Forms.Button btnMasrafKaydet;
        private System.Windows.Forms.Button btnMasrafSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstMasraflar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbMasrafSahibi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem lblPersonelAdSoyad;
        private System.Windows.Forms.ContextMenuStrip cmnuMasrafYonet;
        private System.Windows.Forms.ToolStripMenuItem cmnuOnayla;
        private System.Windows.Forms.ToolStripMenuItem cmnuGuncellenmeli;
        private System.Windows.Forms.ToolStripMenuItem cmnuReddet;
        private System.Windows.Forms.ContextMenuStrip cmnuMuhasebe;
        private System.Windows.Forms.ToolStripMenuItem cmnuOdendi;
    }
}