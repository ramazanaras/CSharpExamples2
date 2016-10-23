namespace Ders56_Koleksiyonlar_HashTable
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
            this.btnDoldur = new System.Windows.Forms.Button();
            this.btn1KeyToValue = new System.Windows.Forms.Button();
            this.btnYokKeyToValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 316);
            this.listBox1.TabIndex = 0;
            // 
            // btnDoldur
            // 
            this.btnDoldur.Location = new System.Drawing.Point(207, 12);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(139, 57);
            this.btnDoldur.TabIndex = 1;
            this.btnDoldur.Text = "Doldur";
            this.btnDoldur.UseVisualStyleBackColor = true;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // btn1KeyToValue
            // 
            this.btn1KeyToValue.Location = new System.Drawing.Point(217, 95);
            this.btn1KeyToValue.Name = "btn1KeyToValue";
            this.btn1KeyToValue.Size = new System.Drawing.Size(139, 70);
            this.btn1KeyToValue.TabIndex = 2;
            this.btn1KeyToValue.Text = "1 nolu anahtarın değerini ver";
            this.btn1KeyToValue.UseVisualStyleBackColor = true;
            this.btn1KeyToValue.Click += new System.EventHandler(this.btn1KeyToValue_Click);
            // 
            // btnYokKeyToValue
            // 
            this.btnYokKeyToValue.Location = new System.Drawing.Point(217, 171);
            this.btnYokKeyToValue.Name = "btnYokKeyToValue";
            this.btnYokKeyToValue.Size = new System.Drawing.Size(139, 70);
            this.btnYokKeyToValue.TabIndex = 2;
            this.btnYokKeyToValue.Text = "Yok nolu anahtarın değerini ver";
            this.btnYokKeyToValue.UseVisualStyleBackColor = true;
            this.btnYokKeyToValue.Click += new System.EventHandler(this.btnYokKeyToValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 391);
            this.Controls.Add(this.btnYokKeyToValue);
            this.Controls.Add(this.btn1KeyToValue);
            this.Controls.Add(this.btnDoldur);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.Button btn1KeyToValue;
        private System.Windows.Forms.Button btnYokKeyToValue;
    }
}

