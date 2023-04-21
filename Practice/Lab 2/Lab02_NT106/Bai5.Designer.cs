namespace Lab02_NT106
{
    partial class Bai5
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
            this.btnCompressToZip = new System.Windows.Forms.Button();
            this.btnCompressToGzip = new System.Windows.Forms.Button();
            this.btnDecompressZip = new System.Windows.Forms.Button();
            this.btnDecompressGzip = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnCompressToZip
            // 
            this.btnCompressToZip.Location = new System.Drawing.Point(18, 13);
            this.btnCompressToZip.Name = "btnCompressToZip";
            this.btnCompressToZip.Size = new System.Drawing.Size(103, 56);
            this.btnCompressToZip.TabIndex = 0;
            this.btnCompressToZip.Text = "Compress to Zip";
            this.btnCompressToZip.UseVisualStyleBackColor = true;
            this.btnCompressToZip.Click += new System.EventHandler(this.btnCompressToZip_Click);
            // 
            // btnCompressToGzip
            // 
            this.btnCompressToGzip.Location = new System.Drawing.Point(18, 98);
            this.btnCompressToGzip.Name = "btnCompressToGzip";
            this.btnCompressToGzip.Size = new System.Drawing.Size(103, 56);
            this.btnCompressToGzip.TabIndex = 1;
            this.btnCompressToGzip.Text = "Compress to Gzip";
            this.btnCompressToGzip.UseVisualStyleBackColor = true;
            this.btnCompressToGzip.Click += new System.EventHandler(this.btnCompressToGzip_Click);
            // 
            // btnDecompressZip
            // 
            this.btnDecompressZip.Location = new System.Drawing.Point(159, 13);
            this.btnDecompressZip.Name = "btnDecompressZip";
            this.btnDecompressZip.Size = new System.Drawing.Size(103, 56);
            this.btnDecompressZip.TabIndex = 2;
            this.btnDecompressZip.Text = "Decompress Zip";
            this.btnDecompressZip.UseVisualStyleBackColor = true;
            this.btnDecompressZip.Click += new System.EventHandler(this.btnDecompressZip_Click);
            // 
            // btnDecompressGzip
            // 
            this.btnDecompressGzip.Location = new System.Drawing.Point(159, 98);
            this.btnDecompressGzip.Name = "btnDecompressGzip";
            this.btnDecompressGzip.Size = new System.Drawing.Size(103, 56);
            this.btnDecompressGzip.TabIndex = 3;
            this.btnDecompressGzip.Text = "Decompress GZip";
            this.btnDecompressGzip.UseVisualStyleBackColor = true;
            this.btnDecompressGzip.Click += new System.EventHandler(this.btnDecompressGzip_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(18, 175);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(244, 23);
            this.progressBar.TabIndex = 4;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 211);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnDecompressGzip);
            this.Controls.Add(this.btnDecompressZip);
            this.Controls.Add(this.btnCompressToGzip);
            this.Controls.Add(this.btnCompressToZip);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompressToZip;
        private System.Windows.Forms.Button btnCompressToGzip;
        private System.Windows.Forms.Button btnDecompressZip;
        private System.Windows.Forms.Button btnDecompressGzip;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}