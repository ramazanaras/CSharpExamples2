namespace Ders52_Diziler
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDiziMetin = new System.Windows.Forms.Button();
            this.btnDiziSayi = new System.Windows.Forms.Button();
            this.btnKisiDizisi = new System.Windows.Forms.Button();
            this.btnCokBoyutlu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(162, 264);
            this.listBox1.TabIndex = 0;
            // 
            // btnDiziMetin
            // 
            this.btnDiziMetin.Location = new System.Drawing.Point(180, 25);
            this.btnDiziMetin.Name = "btnDiziMetin";
            this.btnDiziMetin.Size = new System.Drawing.Size(75, 23);
            this.btnDiziMetin.TabIndex = 1;
            this.btnDiziMetin.Text = "Dizi Metin";
            this.btnDiziMetin.UseVisualStyleBackColor = true;
            this.btnDiziMetin.Click += new System.EventHandler(this.btnDiziMetin_Click);
            // 
            // btnDiziSayi
            // 
            this.btnDiziSayi.Location = new System.Drawing.Point(181, 66);
            this.btnDiziSayi.Name = "btnDiziSayi";
            this.btnDiziSayi.Size = new System.Drawing.Size(75, 23);
            this.btnDiziSayi.TabIndex = 2;
            this.btnDiziSayi.Text = "Dizi Sayi";
            this.btnDiziSayi.UseVisualStyleBackColor = true;
            this.btnDiziSayi.Click += new System.EventHandler(this.btnDiziSayi_Click);
            // 
            // btnKisiDizisi
            // 
            this.btnKisiDizisi.Location = new System.Drawing.Point(180, 115);
            this.btnKisiDizisi.Name = "btnKisiDizisi";
            this.btnKisiDizisi.Size = new System.Drawing.Size(75, 23);
            this.btnKisiDizisi.TabIndex = 3;
            this.btnKisiDizisi.Text = "Kisi Dizisi";
            this.btnKisiDizisi.UseVisualStyleBackColor = true;
            this.btnKisiDizisi.Click += new System.EventHandler(this.btnKisiDizisi_Click);
            // 
            // btnCokBoyutlu
            // 
            this.btnCokBoyutlu.Location = new System.Drawing.Point(181, 162);
            this.btnCokBoyutlu.Name = "btnCokBoyutlu";
            this.btnCokBoyutlu.Size = new System.Drawing.Size(101, 23);
            this.btnCokBoyutlu.TabIndex = 4;
            this.btnCokBoyutlu.Text = "Çok Boyutlu Dizi";
            this.btnCokBoyutlu.UseVisualStyleBackColor = true;
            this.btnCokBoyutlu.Click += new System.EventHandler(this.btnCokBoyutlu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 415);
            this.Controls.Add(this.btnCokBoyutlu);
            this.Controls.Add(this.btnKisiDizisi);
            this.Controls.Add(this.btnDiziSayi);
            this.Controls.Add(this.btnDiziMetin);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDiziMetin;
        private System.Windows.Forms.Button btnDiziSayi;
        private System.Windows.Forms.Button btnKisiDizisi;
        private System.Windows.Forms.Button btnCokBoyutlu;
    }
}

