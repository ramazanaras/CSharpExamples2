namespace Ders54_ArraySinifivekopyalama_siralama
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
            this.btnDiziKopyala = new System.Windows.Forms.Button();
            this.btnSiralamaAZ = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnSiralaZA = new System.Windows.Forms.Button();
            this.btnBulma = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDiziKopyala
            // 
            this.btnDiziKopyala.Location = new System.Drawing.Point(174, 12);
            this.btnDiziKopyala.Name = "btnDiziKopyala";
            this.btnDiziKopyala.Size = new System.Drawing.Size(89, 41);
            this.btnDiziKopyala.TabIndex = 0;
            this.btnDiziKopyala.Text = "Kopyala";
            this.btnDiziKopyala.UseVisualStyleBackColor = true;
            this.btnDiziKopyala.Click += new System.EventHandler(this.btnDiziKopyala_Click);
            // 
            // btnSiralamaAZ
            // 
            this.btnSiralamaAZ.Location = new System.Drawing.Point(174, 59);
            this.btnSiralamaAZ.Name = "btnSiralamaAZ";
            this.btnSiralamaAZ.Size = new System.Drawing.Size(89, 44);
            this.btnSiralamaAZ.TabIndex = 1;
            this.btnSiralamaAZ.Text = "Sırala A-Z";
            this.btnSiralamaAZ.UseVisualStyleBackColor = true;
            this.btnSiralamaAZ.Click += new System.EventHandler(this.btnSiralamaAZ_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 303);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(283, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 277);
            this.listBox2.TabIndex = 2;
            // 
            // btnSiralaZA
            // 
            this.btnSiralaZA.Location = new System.Drawing.Point(174, 122);
            this.btnSiralaZA.Name = "btnSiralaZA";
            this.btnSiralaZA.Size = new System.Drawing.Size(89, 54);
            this.btnSiralaZA.TabIndex = 3;
            this.btnSiralaZA.Text = "SIRALA Z-A";
            this.btnSiralaZA.UseVisualStyleBackColor = true;
            this.btnSiralaZA.Click += new System.EventHandler(this.btnSiralaZA_Click);
            // 
            // btnBulma
            // 
            this.btnBulma.Location = new System.Drawing.Point(174, 195);
            this.btnBulma.Name = "btnBulma";
            this.btnBulma.Size = new System.Drawing.Size(89, 49);
            this.btnBulma.TabIndex = 4;
            this.btnBulma.Text = "Bul";
            this.btnBulma.UseVisualStyleBackColor = true;
            this.btnBulma.Click += new System.EventHandler(this.btnBulma_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 415);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBulma);
            this.Controls.Add(this.btnSiralaZA);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSiralamaAZ);
            this.Controls.Add(this.btnDiziKopyala);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiziKopyala;
        private System.Windows.Forms.Button btnSiralamaAZ;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnSiralaZA;
        private System.Windows.Forms.Button btnBulma;
        private System.Windows.Forms.TextBox textBox1;
    }
}

