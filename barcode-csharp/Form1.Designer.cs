namespace barcode_csharp
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
            this.btnBarcode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.BarcodeQRcode = new System.Windows.Forms.PictureBox();
            this.txtQRcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQRcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeQRcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBarcode
            // 
            this.btnBarcode.Location = new System.Drawing.Point(351, 312);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(75, 23);
            this.btnBarcode.TabIndex = 0;
            this.btnBarcode.Text = "Barcode";
            this.btnBarcode.UseVisualStyleBackColor = true;
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(85, 315);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(248, 20);
            this.txtBarcode.TabIndex = 2;
            // 
            // BarcodeQRcode
            // 
            this.BarcodeQRcode.BackColor = System.Drawing.SystemColors.Window;
            this.BarcodeQRcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BarcodeQRcode.Location = new System.Drawing.Point(12, 12);
            this.BarcodeQRcode.Name = "BarcodeQRcode";
            this.BarcodeQRcode.Size = new System.Drawing.Size(414, 268);
            this.BarcodeQRcode.TabIndex = 3;
            this.BarcodeQRcode.TabStop = false;
            this.BarcodeQRcode.Click += new System.EventHandler(this.BarcodeQRcode_Click);
            // 
            // txtQRcode
            // 
            this.txtQRcode.Location = new System.Drawing.Point(85, 352);
            this.txtQRcode.Name = "txtQRcode";
            this.txtQRcode.Size = new System.Drawing.Size(248, 20);
            this.txtQRcode.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "QRcode";
            // 
            // btnQRcode
            // 
            this.btnQRcode.Location = new System.Drawing.Point(351, 349);
            this.btnQRcode.Name = "btnQRcode";
            this.btnQRcode.Size = new System.Drawing.Size(75, 23);
            this.btnQRcode.TabIndex = 4;
            this.btnQRcode.Text = "QRcode";
            this.btnQRcode.UseVisualStyleBackColor = true;
            this.btnQRcode.Click += new System.EventHandler(this.btnQRcode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 445);
            this.Controls.Add(this.txtQRcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQRcode);
            this.Controls.Add(this.BarcodeQRcode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBarcode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeQRcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.PictureBox BarcodeQRcode;
        private System.Windows.Forms.TextBox txtQRcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQRcode;
    }
}

