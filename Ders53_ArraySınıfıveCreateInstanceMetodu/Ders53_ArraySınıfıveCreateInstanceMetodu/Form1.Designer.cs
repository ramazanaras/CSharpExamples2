namespace Ders53_ArraySınıfıveCreateInstanceMetodu
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
            this.btnYukle = new System.Windows.Forms.Button();
            this.btnRuntime = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(24, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 342);
            this.listBox1.TabIndex = 0;
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(150, 25);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(82, 29);
            this.btnYukle.TabIndex = 1;
            this.btnYukle.Text = "Dizi Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // btnRuntime
            // 
            this.btnRuntime.Location = new System.Drawing.Point(151, 77);
            this.btnRuntime.Name = "btnRuntime";
            this.btnRuntime.Size = new System.Drawing.Size(89, 73);
            this.btnRuntime.TabIndex = 2;
            this.btnRuntime.Text = "Çalışma Zamanı Tip Verme";
            this.btnRuntime.UseVisualStyleBackColor = true;
            this.btnRuntime.Click += new System.EventHandler(this.btnRuntime_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(381, 25);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 316);
            this.listBox2.TabIndex = 3;
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(151, 180);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(104, 61);
            this.btnClone.TabIndex = 4;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(151, 267);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(104, 64);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "btnCopy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 437);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnRuntime);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Button btnRuntime;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnCopy;
    }
}

