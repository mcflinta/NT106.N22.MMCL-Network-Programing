namespace Lab02_NT106
{
    partial class Bai3
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
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnReadInput = new System.Windows.Forms.Button();
            this.btnWriteOutput = new System.Windows.Forms.Button();
            this.btnReadOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(215, 12);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(519, 339);
            this.rtbContent.TabIndex = 5;
            this.rtbContent.Text = "";
            // 
            // btnReadInput
            // 
            this.btnReadInput.Location = new System.Drawing.Point(21, 52);
            this.btnReadInput.Name = "btnReadInput";
            this.btnReadInput.Size = new System.Drawing.Size(177, 48);
            this.btnReadInput.TabIndex = 3;
            this.btnReadInput.Text = "Đọc File Input";
            this.btnReadInput.UseVisualStyleBackColor = true;
            this.btnReadInput.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWriteOutput
            // 
            this.btnWriteOutput.Location = new System.Drawing.Point(21, 194);
            this.btnWriteOutput.Name = "btnWriteOutput";
            this.btnWriteOutput.Size = new System.Drawing.Size(177, 48);
            this.btnWriteOutput.TabIndex = 7;
            this.btnWriteOutput.Text = "Viết File Output";
            this.btnWriteOutput.UseVisualStyleBackColor = true;
            this.btnWriteOutput.Click += new System.EventHandler(this.btnWriteOutput_Click);
            // 
            // btnReadOutput
            // 
            this.btnReadOutput.Location = new System.Drawing.Point(21, 126);
            this.btnReadOutput.Name = "btnReadOutput";
            this.btnReadOutput.Size = new System.Drawing.Size(177, 48);
            this.btnReadOutput.TabIndex = 8;
            this.btnReadOutput.Text = "Đọc File Input";
            this.btnReadOutput.UseVisualStyleBackColor = true;
            this.btnReadOutput.Click += new System.EventHandler(this.btnReadOutput_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 446);
            this.Controls.Add(this.btnReadOutput);
            this.Controls.Add(this.btnWriteOutput);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.btnReadInput);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bai3";
            this.Text = "Bai 3";
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnReadInput;
        private System.Windows.Forms.Button btnWriteOutput;
        private System.Windows.Forms.Button btnReadOutput;
    }
}