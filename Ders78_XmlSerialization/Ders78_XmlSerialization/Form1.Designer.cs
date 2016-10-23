namespace Ders78_XmlSerialization
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
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnSerialize2 = new System.Windows.Forms.Button();
            this.btnDeserialize2 = new System.Windows.Forms.Button();
            this.btnSerialize3 = new System.Windows.Forms.Button();
            this.btnDeserialize3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(12, 37);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(183, 42);
            this.btnSerialize.TabIndex = 0;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(214, 38);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(157, 41);
            this.btnDeserialize.TabIndex = 1;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnSerialize2
            // 
            this.btnSerialize2.Location = new System.Drawing.Point(12, 97);
            this.btnSerialize2.Name = "btnSerialize2";
            this.btnSerialize2.Size = new System.Drawing.Size(183, 42);
            this.btnSerialize2.TabIndex = 0;
            this.btnSerialize2.Text = "Serialize";
            this.btnSerialize2.UseVisualStyleBackColor = true;
            this.btnSerialize2.Click += new System.EventHandler(this.btnSerialize2_Click);
            // 
            // btnDeserialize2
            // 
            this.btnDeserialize2.Location = new System.Drawing.Point(214, 98);
            this.btnDeserialize2.Name = "btnDeserialize2";
            this.btnDeserialize2.Size = new System.Drawing.Size(157, 41);
            this.btnDeserialize2.TabIndex = 1;
            this.btnDeserialize2.Text = "Deserialize";
            this.btnDeserialize2.UseVisualStyleBackColor = true;
            this.btnDeserialize2.Click += new System.EventHandler(this.btnDeserialize2_Click);
            // 
            // btnSerialize3
            // 
            this.btnSerialize3.Location = new System.Drawing.Point(13, 177);
            this.btnSerialize3.Name = "btnSerialize3";
            this.btnSerialize3.Size = new System.Drawing.Size(182, 52);
            this.btnSerialize3.TabIndex = 2;
            this.btnSerialize3.Text = "Serialize";
            this.btnSerialize3.UseVisualStyleBackColor = true;
            this.btnSerialize3.Click += new System.EventHandler(this.btnSerialize3_Click);
            // 
            // btnDeserialize3
            // 
            this.btnDeserialize3.Location = new System.Drawing.Point(214, 176);
            this.btnDeserialize3.Name = "btnDeserialize3";
            this.btnDeserialize3.Size = new System.Drawing.Size(157, 53);
            this.btnDeserialize3.TabIndex = 3;
            this.btnDeserialize3.Text = "Deserialize";
            this.btnDeserialize3.UseVisualStyleBackColor = true;
            this.btnDeserialize3.Click += new System.EventHandler(this.btnDeserialize3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 372);
            this.Controls.Add(this.btnDeserialize3);
            this.Controls.Add(this.btnSerialize3);
            this.Controls.Add(this.btnDeserialize2);
            this.Controls.Add(this.btnSerialize2);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Button btnSerialize2;
        private System.Windows.Forms.Button btnDeserialize2;
        private System.Windows.Forms.Button btnSerialize3;
        private System.Windows.Forms.Button btnDeserialize3;
    }
}

