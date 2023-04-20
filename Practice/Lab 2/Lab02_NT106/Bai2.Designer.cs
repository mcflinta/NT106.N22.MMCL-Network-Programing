namespace Lab02_NT106
{
    partial class Bai2
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
            this.btnRead = new System.Windows.Forms.Button();
            this.lbFileName = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLineCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWordsCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbChacracterCount = new System.Windows.Forms.TextBox();
            this.lbChaCount = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(13, 13);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(278, 45);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read From File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(13, 79);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(63, 17);
            this.lbFileName.TabIndex = 1;
            this.lbFileName.Text = "File name";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(119, 71);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.Size = new System.Drawing.Size(172, 25);
            this.tbFileName.TabIndex = 2;
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(119, 107);
            this.tbSize.Name = "tbSize";
            this.tbSize.ReadOnly = true;
            this.tbSize.Size = new System.Drawing.Size(172, 25);
            this.tbSize.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Size";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(119, 138);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.ReadOnly = true;
            this.tbUrl.Size = new System.Drawing.Size(172, 25);
            this.tbUrl.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "URL";
            // 
            // tbLineCount
            // 
            this.tbLineCount.Location = new System.Drawing.Point(119, 169);
            this.tbLineCount.Name = "tbLineCount";
            this.tbLineCount.ReadOnly = true;
            this.tbLineCount.Size = new System.Drawing.Size(172, 25);
            this.tbLineCount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Line count";
            // 
            // tbWordsCount
            // 
            this.tbWordsCount.Location = new System.Drawing.Point(119, 200);
            this.tbWordsCount.Name = "tbWordsCount";
            this.tbWordsCount.ReadOnly = true;
            this.tbWordsCount.Size = new System.Drawing.Size(172, 25);
            this.tbWordsCount.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Words count";
            // 
            // tbChacracterCount
            // 
            this.tbChacracterCount.Location = new System.Drawing.Point(119, 231);
            this.tbChacracterCount.Name = "tbChacracterCount";
            this.tbChacracterCount.ReadOnly = true;
            this.tbChacracterCount.Size = new System.Drawing.Size(172, 25);
            this.tbChacracterCount.TabIndex = 12;
            // 
            // lbChaCount
            // 
            this.lbChaCount.AutoSize = true;
            this.lbChaCount.Location = new System.Drawing.Point(13, 234);
            this.lbChaCount.Name = "lbChaCount";
            this.lbChaCount.Size = new System.Drawing.Size(100, 17);
            this.lbChaCount.TabIndex = 11;
            this.lbChaCount.Text = "Character count";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(298, 13);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(546, 306);
            this.rtbContent.TabIndex = 13;
            this.rtbContent.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(278, 45);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 339);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.tbChacracterCount);
            this.Controls.Add(this.lbChaCount);
            this.Controls.Add(this.tbWordsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLineCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.btnRead);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLineCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWordsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbChacracterCount;
        private System.Windows.Forms.Label lbChaCount;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnExit;
    }
}