namespace Ders58_Dosya_Klasörİslemleri
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
            this.btnKlasorOlustur = new System.Windows.Forms.Button();
            this.btnDosyaOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlasorOlustur
            // 
            this.btnKlasorOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKlasorOlustur.Location = new System.Drawing.Point(54, 73);
            this.btnKlasorOlustur.Name = "btnKlasorOlustur";
            this.btnKlasorOlustur.Size = new System.Drawing.Size(109, 68);
            this.btnKlasorOlustur.TabIndex = 0;
            this.btnKlasorOlustur.Text = "Klasör Oluştur";
            this.btnKlasorOlustur.UseVisualStyleBackColor = true;
            this.btnKlasorOlustur.Click += new System.EventHandler(this.btnKlasorOlustur_Click);
            // 
            // btnDosyaOlustur
            // 
            this.btnDosyaOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaOlustur.Location = new System.Drawing.Point(169, 73);
            this.btnDosyaOlustur.Name = "btnDosyaOlustur";
            this.btnDosyaOlustur.Size = new System.Drawing.Size(118, 68);
            this.btnDosyaOlustur.TabIndex = 1;
            this.btnDosyaOlustur.Text = "Dosya Oluştur";
            this.btnDosyaOlustur.UseVisualStyleBackColor = true;
            this.btnDosyaOlustur.Click += new System.EventHandler(this.btnDosyaOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 239);
            this.Controls.Add(this.btnDosyaOlustur);
            this.Controls.Add(this.btnKlasorOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlasorOlustur;
        private System.Windows.Forms.Button btnDosyaOlustur;
    }
}

