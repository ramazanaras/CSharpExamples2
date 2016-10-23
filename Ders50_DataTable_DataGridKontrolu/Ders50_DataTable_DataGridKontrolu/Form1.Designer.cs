namespace Ders50_DataTable_DataGridKontrolu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerileriDoldur = new System.Windows.Forms.Button();
            this.btnVerileriOku = new System.Windows.Forms.Button();
            this.btnYeniVerileriGetir = new System.Windows.Forms.Button();
            this.btnGuncellenenSatirlar = new System.Windows.Forms.Button();
            this.btnSilinenVerileriGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnVerileriDoldur
            // 
            this.btnVerileriDoldur.Location = new System.Drawing.Point(12, 293);
            this.btnVerileriDoldur.Name = "btnVerileriDoldur";
            this.btnVerileriDoldur.Size = new System.Drawing.Size(112, 58);
            this.btnVerileriDoldur.TabIndex = 1;
            this.btnVerileriDoldur.Text = "DataTable ile Verileri Doldur";
            this.btnVerileriDoldur.UseVisualStyleBackColor = true;
            this.btnVerileriDoldur.Click += new System.EventHandler(this.btnVerileriDoldur_Click);
            // 
            // btnVerileriOku
            // 
            this.btnVerileriOku.Location = new System.Drawing.Point(147, 294);
            this.btnVerileriOku.Name = "btnVerileriOku";
            this.btnVerileriOku.Size = new System.Drawing.Size(118, 57);
            this.btnVerileriOku.TabIndex = 2;
            this.btnVerileriOku.Text = "Verileri Oku";
            this.btnVerileriOku.UseVisualStyleBackColor = true;
            this.btnVerileriOku.Click += new System.EventHandler(this.btnVerileriOku_Click);
            // 
            // btnYeniVerileriGetir
            // 
            this.btnYeniVerileriGetir.Location = new System.Drawing.Point(289, 293);
            this.btnYeniVerileriGetir.Name = "btnYeniVerileriGetir";
            this.btnYeniVerileriGetir.Size = new System.Drawing.Size(114, 58);
            this.btnYeniVerileriGetir.TabIndex = 3;
            this.btnYeniVerileriGetir.Text = "Yeni Verileri Getir";
            this.btnYeniVerileriGetir.UseVisualStyleBackColor = true;
            this.btnYeniVerileriGetir.Click += new System.EventHandler(this.btnYeniVerileriGetir_Click);
            // 
            // btnGuncellenenSatirlar
            // 
            this.btnGuncellenenSatirlar.Location = new System.Drawing.Point(410, 293);
            this.btnGuncellenenSatirlar.Name = "btnGuncellenenSatirlar";
            this.btnGuncellenenSatirlar.Size = new System.Drawing.Size(99, 58);
            this.btnGuncellenenSatirlar.TabIndex = 4;
            this.btnGuncellenenSatirlar.Text = "Güncellenen Satırları Getir";
            this.btnGuncellenenSatirlar.UseVisualStyleBackColor = true;
            this.btnGuncellenenSatirlar.Click += new System.EventHandler(this.btnGuncellenenSatirlar_Click);
            // 
            // btnSilinenVerileriGetir
            // 
            this.btnSilinenVerileriGetir.Location = new System.Drawing.Point(527, 294);
            this.btnSilinenVerileriGetir.Name = "btnSilinenVerileriGetir";
            this.btnSilinenVerileriGetir.Size = new System.Drawing.Size(110, 57);
            this.btnSilinenVerileriGetir.TabIndex = 5;
            this.btnSilinenVerileriGetir.Text = "Silinen Verileri Getir";
            this.btnSilinenVerileriGetir.UseVisualStyleBackColor = true;
            this.btnSilinenVerileriGetir.Click += new System.EventHandler(this.btnSilinenVerileriGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 442);
            this.Controls.Add(this.btnSilinenVerileriGetir);
            this.Controls.Add(this.btnGuncellenenSatirlar);
            this.Controls.Add(this.btnYeniVerileriGetir);
            this.Controls.Add(this.btnVerileriOku);
            this.Controls.Add(this.btnVerileriDoldur);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVerileriDoldur;
        private System.Windows.Forms.Button btnVerileriOku;
        private System.Windows.Forms.Button btnYeniVerileriGetir;
        private System.Windows.Forms.Button btnGuncellenenSatirlar;
        private System.Windows.Forms.Button btnSilinenVerileriGetir;
    }
}

