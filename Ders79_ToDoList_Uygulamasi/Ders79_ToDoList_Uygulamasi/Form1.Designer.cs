namespace Ders79_ToDoList_Uygulamasi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamaHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpYeniGorev = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblYapilacaklarListesi = new System.Windows.Forms.Label();
            this.clbYapilacaklarListesi = new System.Windows.Forms.CheckedListBox();
            this.lblTamamlananlarListesi = new System.Windows.Forms.Label();
            this.lstTamamlananlarListesi = new System.Windows.Forms.ListBox();
            this.txtYeniGorev = new System.Windows.Forms.TextBox();
            this.btnYeni = new System.Windows.Forms.ToolStripButton();
            this.btnDuzelt = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.btnKes = new System.Windows.Forms.ToolStripButton();
            this.btnKopyala = new System.Windows.Forms.ToolStripButton();
            this.btnYapistir = new System.Windows.Forms.ToolStripButton();
            this.btnYardim = new System.Windows.Forms.ToolStripButton();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzeltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.düzeltToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpYeniGorev.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeni,
            this.btnDuzelt,
            this.btnSil,
            this.btnKes,
            this.btnKopyala,
            this.btnYapistir,
            this.btnYardim});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(762, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.todoToolStripMenuItem,
            this.hakkımdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // todoToolStripMenuItem
            // 
            this.todoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.düzeltToolStripMenuItem,
            this.silToolStripMenuItem});
            this.todoToolStripMenuItem.Name = "todoToolStripMenuItem";
            this.todoToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.todoToolStripMenuItem.Text = "Todo";
            // 
            // hakkımdaToolStripMenuItem
            // 
            this.hakkımdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uygulamaHakkındaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.hakkımdaToolStripMenuItem.Name = "hakkımdaToolStripMenuItem";
            this.hakkımdaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.hakkımdaToolStripMenuItem.Text = "Hakkımda";
            // 
            // uygulamaHakkındaToolStripMenuItem
            // 
            this.uygulamaHakkındaToolStripMenuItem.Name = "uygulamaHakkındaToolStripMenuItem";
            this.uygulamaHakkındaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.uygulamaHakkındaToolStripMenuItem.Text = "Uygulama Hakkında";
            this.uygulamaHakkındaToolStripMenuItem.Click += new System.EventHandler(this.uygulamaHakkındaToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.clbYapilacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.lblYapilacaklarListesi);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.grpYeniGorev);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstTamamlananlarListesi);
            this.splitContainer1.Panel2.Controls.Add(this.lblTamamlananlarListesi);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(762, 344);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 2;
            // 
            // grpYeniGorev
            // 
            this.grpYeniGorev.Controls.Add(this.txtYeniGorev);
            this.grpYeniGorev.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpYeniGorev.Location = new System.Drawing.Point(5, 5);
            this.grpYeniGorev.Name = "grpYeniGorev";
            this.grpYeniGorev.Padding = new System.Windows.Forms.Padding(15);
            this.grpYeniGorev.Size = new System.Drawing.Size(244, 100);
            this.grpYeniGorev.TabIndex = 0;
            this.grpYeniGorev.TabStop = false;
            this.grpYeniGorev.Text = "Yeni Görev";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 10);
            this.panel1.TabIndex = 1;
            // 
            // lblYapilacaklarListesi
            // 
            this.lblYapilacaklarListesi.AutoSize = true;
            this.lblYapilacaklarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYapilacaklarListesi.Location = new System.Drawing.Point(5, 115);
            this.lblYapilacaklarListesi.Name = "lblYapilacaklarListesi";
            this.lblYapilacaklarListesi.Padding = new System.Windows.Forms.Padding(5);
            this.lblYapilacaklarListesi.Size = new System.Drawing.Size(107, 23);
            this.lblYapilacaklarListesi.TabIndex = 3;
            this.lblYapilacaklarListesi.Text = "Yapılacaklar Listesi";
            // 
            // clbYapilacaklarListesi
            // 
            this.clbYapilacaklarListesi.ContextMenuStrip = this.contextMenuStrip1;
            this.clbYapilacaklarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbYapilacaklarListesi.FormattingEnabled = true;
            this.clbYapilacaklarListesi.Location = new System.Drawing.Point(5, 138);
            this.clbYapilacaklarListesi.Name = "clbYapilacaklarListesi";
            this.clbYapilacaklarListesi.Size = new System.Drawing.Size(244, 201);
            this.clbYapilacaklarListesi.TabIndex = 4;
            this.clbYapilacaklarListesi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbYapilacaklarListesi_ItemCheck);
            this.clbYapilacaklarListesi.SelectedIndexChanged += new System.EventHandler(this.clbYapilacaklarListesi_SelectedIndexChanged);
            // 
            // lblTamamlananlarListesi
            // 
            this.lblTamamlananlarListesi.AutoSize = true;
            this.lblTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTamamlananlarListesi.Location = new System.Drawing.Point(5, 5);
            this.lblTamamlananlarListesi.Name = "lblTamamlananlarListesi";
            this.lblTamamlananlarListesi.Padding = new System.Windows.Forms.Padding(5);
            this.lblTamamlananlarListesi.Size = new System.Drawing.Size(121, 23);
            this.lblTamamlananlarListesi.TabIndex = 4;
            this.lblTamamlananlarListesi.Text = "Tamamlananlar Listesi";
            // 
            // lstTamamlananlarListesi
            // 
            this.lstTamamlananlarListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTamamlananlarListesi.FormattingEnabled = true;
            this.lstTamamlananlarListesi.Location = new System.Drawing.Point(5, 28);
            this.lstTamamlananlarListesi.Name = "lstTamamlananlarListesi";
            this.lstTamamlananlarListesi.Size = new System.Drawing.Size(494, 311);
            this.lstTamamlananlarListesi.TabIndex = 5;
            // 
            // txtYeniGorev
            // 
            this.txtYeniGorev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYeniGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniGorev.Location = new System.Drawing.Point(15, 28);
            this.txtYeniGorev.MaxLength = 120;
            this.txtYeniGorev.Multiline = true;
            this.txtYeniGorev.Name = "txtYeniGorev";
            this.txtYeniGorev.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtYeniGorev.Size = new System.Drawing.Size(214, 57);
            this.txtYeniGorev.TabIndex = 0;
            // 
            // btnYeni
            // 
            this.btnYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYeni.Image = global::Ders79_ToDoList_Uygulamasi.Properties.Resources._1475421327_Add;
            this.btnYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(23, 22);
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDuzelt.Image = global::Ders79_ToDoList_Uygulamasi.Properties.Resources._1475421065_edit;
            this.btnDuzelt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDuzelt.Name = "btnDuzelt";
            this.btnDuzelt.Size = new System.Drawing.Size(23, 22);
            this.btnDuzelt.Text = "Düzelt";
            this.btnDuzelt.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // btnSil
            // 
            this.btnSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSil.Image = global::Ders79_ToDoList_Uygulamasi.Properties.Resources._1475421166_trash_bin;
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(23, 22);
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKes
            // 
            this.btnKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKes.Image = ((System.Drawing.Image)(resources.GetObject("btnKes.Image")));
            this.btnKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(23, 22);
            this.btnKes.Text = "Kes";
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKopyala.Image = ((System.Drawing.Image)(resources.GetObject("btnKopyala.Image")));
            this.btnKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(23, 22);
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYapistir.Image = ((System.Drawing.Image)(resources.GetObject("btnYapistir.Image")));
            this.btnYapistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(23, 22);
            this.btnYapistir.Text = "Yapıştır";
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // btnYardim
            // 
            this.btnYardim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYardim.Image = ((System.Drawing.Image)(resources.GetObject("btnYardim.Image")));
            this.btnYardim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(23, 22);
            this.btnYardim.Text = "Yardım";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.Image = global::Ders79_ToDoList_Uygulamasi.Properties.Resources._1475421327_Add;
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.yeniToolStripMenuItem.Text = "Yeni";
            this.yeniToolStripMenuItem.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // düzeltToolStripMenuItem
            // 
            this.düzeltToolStripMenuItem.Image = global::Ders79_ToDoList_Uygulamasi.Properties.Resources._1475421065_edit;
            this.düzeltToolStripMenuItem.Name = "düzeltToolStripMenuItem";
            this.düzeltToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.düzeltToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.düzeltToolStripMenuItem.Text = "Düzelt";
            this.düzeltToolStripMenuItem.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = global::Ders79_ToDoList_Uygulamasi.Properties.Resources._1475421166_trash_bin;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.silToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Bilgilendirme";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TodoList";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem1,
            this.düzeltToolStripMenuItem1,
            this.silToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 70);
            // 
            // yeniToolStripMenuItem1
            // 
            this.yeniToolStripMenuItem1.Name = "yeniToolStripMenuItem1";
            this.yeniToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.yeniToolStripMenuItem1.Text = "Yeni";
            this.yeniToolStripMenuItem1.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // düzeltToolStripMenuItem1
            // 
            this.düzeltToolStripMenuItem1.Name = "düzeltToolStripMenuItem1";
            this.düzeltToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.düzeltToolStripMenuItem1.Text = "Düzelt";
            this.düzeltToolStripMenuItem1.Click += new System.EventHandler(this.btnDuzelt_Click);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 393);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpYeniGorev.ResumeLayout(false);
            this.grpYeniGorev.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeni;
        private System.Windows.Forms.ToolStripButton btnDuzelt;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.ToolStripButton btnKes;
        private System.Windows.Forms.ToolStripButton btnKopyala;
        private System.Windows.Forms.ToolStripButton btnYapistir;
        private System.Windows.Forms.ToolStripButton btnYardim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamaHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox clbYapilacaklarListesi;
        private System.Windows.Forms.Label lblYapilacaklarListesi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpYeniGorev;
        private System.Windows.Forms.TextBox txtYeniGorev;
        private System.Windows.Forms.ListBox lstTamamlananlarListesi;
        private System.Windows.Forms.Label lblTamamlananlarListesi;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem düzeltToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
    }
}

