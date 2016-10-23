namespace Ders49_DialogPencereleri
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
            this.btnOpenFolderDialog = new System.Windows.Forms.Button();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.btnPrintDialog = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btnOpenFolderDialog
            // 
            this.btnOpenFolderDialog.Location = new System.Drawing.Point(35, 43);
            this.btnOpenFolderDialog.Name = "btnOpenFolderDialog";
            this.btnOpenFolderDialog.Size = new System.Drawing.Size(129, 23);
            this.btnOpenFolderDialog.TabIndex = 0;
            this.btnOpenFolderDialog.Text = "OpenFolderDialog";
            this.btnOpenFolderDialog.UseVisualStyleBackColor = true;
            this.btnOpenFolderDialog.Click += new System.EventHandler(this.btnOpenFolderDialog_Click);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Location = new System.Drawing.Point(197, 43);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(75, 23);
            this.btnColorDialog.TabIndex = 1;
            this.btnColorDialog.Text = "Color Dialog";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(35, 90);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(129, 23);
            this.btnOpenFileDialog.TabIndex = 0;
            this.btnOpenFileDialog.Text = "OpenFileDialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Location = new System.Drawing.Point(197, 90);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(75, 23);
            this.btnFontDialog.TabIndex = 1;
            this.btnFontDialog.Text = "Font Dialog";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(35, 141);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(125, 23);
            this.btnSaveFileDialog.TabIndex = 0;
            this.btnSaveFileDialog.Text = "SaveFileDialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // btnPrintDialog
            // 
            this.btnPrintDialog.Location = new System.Drawing.Point(197, 141);
            this.btnPrintDialog.Name = "btnPrintDialog";
            this.btnPrintDialog.Size = new System.Drawing.Size(75, 23);
            this.btnPrintDialog.TabIndex = 1;
            this.btnPrintDialog.Text = "PrintDialog";
            this.btnPrintDialog.UseVisualStyleBackColor = true;
            this.btnPrintDialog.Click += new System.EventHandler(this.btnPrintDialog_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPrintDialog);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.btnFontDialog);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.btnColorDialog);
            this.Controls.Add(this.btnOpenFolderDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFolderDialog;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button btnFontDialog;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.Button btnPrintDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

