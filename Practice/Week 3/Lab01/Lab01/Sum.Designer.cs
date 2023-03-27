namespace Lab01
{
    partial class Sum
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbnum1 = new System.Windows.Forms.TextBox();
            this.tbnum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ 1";
            // 
            // tbnum1
            // 
            this.tbnum1.Location = new System.Drawing.Point(176, 73);
            this.tbnum1.Name = "tbnum1";
            this.tbnum1.Size = new System.Drawing.Size(162, 20);
            this.tbnum1.TabIndex = 1;
            this.tbnum1.TextChanged += new System.EventHandler(this.tbnum1_TextChanged);
            this.tbnum1.Validating += new System.ComponentModel.CancelEventHandler(this.tbnum1_Validating);
            this.tbnum1.Validated += new System.EventHandler(this.tbnum1_Validated);
            // 
            // tbnum2
            // 
            this.tbnum2.Location = new System.Drawing.Point(176, 116);
            this.tbnum2.Name = "tbnum2";
            this.tbnum2.Size = new System.Drawing.Size(162, 20);
            this.tbnum2.TabIndex = 3;
            this.tbnum2.Validating += new System.ComponentModel.CancelEventHandler(this.tbnum2_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số thứ 2";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(176, 200);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(162, 20);
            this.tbResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả";
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(88, 142);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(250, 37);
            this.btnSum.TabIndex = 6;
            this.btnSum.Text = "Tính";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "TÍNH TỔNG 2 SỐ NGUYÊN";
            // 
            // btnExit
            // 
            this.btnExit.CausesValidation = false;
            this.btnExit.Location = new System.Drawing.Point(176, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 290);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbnum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnum1);
            this.Controls.Add(this.label1);
            this.Name = "Sum";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnum1;
        private System.Windows.Forms.TextBox tbnum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
    }
}