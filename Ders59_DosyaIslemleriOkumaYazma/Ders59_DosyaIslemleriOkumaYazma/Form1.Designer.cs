namespace Ders59_DosyaIslemleriOkumaYazma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtYazilacakMetin = new System.Windows.Forms.TextBox();
            this.btnDosyaYaz = new System.Windows.Forms.Button();
            this.lblOkunanMetin = new System.Windows.Forms.Label();
            this.btnDosyadanOku = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSatirSatirOku = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnSatirSatirOku);
            this.groupBox1.Controls.Add(this.btnDosyaYaz);
            this.groupBox1.Controls.Add(this.txtYazilacakMetin);
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosya Yazma";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnDosyadanOku);
            this.groupBox2.Controls.Add(this.lblOkunanMetin);
            this.groupBox2.Location = new System.Drawing.Point(424, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 215);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dosya Okuma";
            // 
            // txtYazilacakMetin
            // 
            this.txtYazilacakMetin.Location = new System.Drawing.Point(6, 19);
            this.txtYazilacakMetin.Multiline = true;
            this.txtYazilacakMetin.Name = "txtYazilacakMetin";
            this.txtYazilacakMetin.Size = new System.Drawing.Size(200, 121);
            this.txtYazilacakMetin.TabIndex = 1;
            // 
            // btnDosyaYaz
            // 
            this.btnDosyaYaz.Location = new System.Drawing.Point(97, 146);
            this.btnDosyaYaz.Name = "btnDosyaYaz";
            this.btnDosyaYaz.Size = new System.Drawing.Size(109, 46);
            this.btnDosyaYaz.TabIndex = 2;
            this.btnDosyaYaz.Text = "Dosyaya Yaz";
            this.btnDosyaYaz.UseVisualStyleBackColor = true;
            this.btnDosyaYaz.Click += new System.EventHandler(this.btnDosyaYaz_Click);
            // 
            // lblOkunanMetin
            // 
            this.lblOkunanMetin.Location = new System.Drawing.Point(6, 22);
            this.lblOkunanMetin.Name = "lblOkunanMetin";
            this.lblOkunanMetin.Size = new System.Drawing.Size(220, 118);
            this.lblOkunanMetin.TabIndex = 1;
            this.lblOkunanMetin.Text = "label1";
            this.lblOkunanMetin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDosyadanOku
            // 
            this.btnDosyadanOku.Location = new System.Drawing.Point(117, 146);
            this.btnDosyadanOku.Name = "btnDosyadanOku";
            this.btnDosyadanOku.Size = new System.Drawing.Size(109, 46);
            this.btnDosyadanOku.TabIndex = 2;
            this.btnDosyadanOku.Text = "Dosyadan Oku";
            this.btnDosyadanOku.UseVisualStyleBackColor = true;
            this.btnDosyadanOku.Click += new System.EventHandler(this.btnDosyadanOku_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 216);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 121);
            this.listBox1.TabIndex = 1;
            // 
            // btnSatirSatirOku
            // 
            this.btnSatirSatirOku.Location = new System.Drawing.Point(6, 147);
            this.btnSatirSatirOku.Name = "btnSatirSatirOku";
            this.btnSatirSatirOku.Size = new System.Drawing.Size(85, 45);
            this.btnSatirSatirOku.TabIndex = 3;
            this.btnSatirSatirOku.Text = "Satır Satır Oku";
            this.btnSatirSatirOku.UseVisualStyleBackColor = true;
            this.btnSatirSatirOku.Click += new System.EventHandler(this.btnSatirSatirOku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 389);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDosyaYaz;
        private System.Windows.Forms.TextBox txtYazilacakMetin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDosyadanOku;
        private System.Windows.Forms.Label lblOkunanMetin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSatirSatirOku;
    }
}

