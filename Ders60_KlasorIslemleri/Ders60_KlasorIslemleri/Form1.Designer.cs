namespace Ders60_KlasorIslemleri
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
            this.btnDosyalariOKu = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDosyalariOKu
            // 
            this.btnDosyalariOKu.Location = new System.Drawing.Point(76, 358);
            this.btnDosyalariOKu.Name = "btnDosyalariOKu";
            this.btnDosyalariOKu.Size = new System.Drawing.Size(159, 55);
            this.btnDosyalariOKu.TabIndex = 0;
            this.btnDosyalariOKu.Text = "Klasorden Dosyalari OKu";
            this.btnDosyalariOKu.UseVisualStyleBackColor = true;
            this.btnDosyalariOKu.Click += new System.EventHandler(this.btnDosyalariOKu_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(499, 329);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 464);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDosyalariOKu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDosyalariOKu;
        private System.Windows.Forms.ListBox listBox1;
    }
}

