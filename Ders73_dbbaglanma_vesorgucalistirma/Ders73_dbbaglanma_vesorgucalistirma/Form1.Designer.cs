namespace Ders73_dbbaglanma_vesorgucalistirma
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
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnKisileriGetir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(235, 44);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(98, 45);
            this.btnBaglan.TabIndex = 0;
            this.btnBaglan.Text = "BAğlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnKisileriGetir
            // 
            this.btnKisileriGetir.Location = new System.Drawing.Point(235, 113);
            this.btnKisileriGetir.Name = "btnKisileriGetir";
            this.btnKisileriGetir.Size = new System.Drawing.Size(99, 52);
            this.btnKisileriGetir.TabIndex = 1;
            this.btnKisileriGetir.Text = "Kişileri Getir";
            this.btnKisileriGetir.UseVisualStyleBackColor = true;
            this.btnKisileriGetir.Click += new System.EventHandler(this.btnKisileriGetir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 238);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 429);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKisileriGetir);
            this.Controls.Add(this.btnBaglan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnKisileriGetir;
        private System.Windows.Forms.ListBox listBox1;
    }
}

