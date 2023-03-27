namespace Lab01
{
    partial class BaiTH5
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
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lbFactorialA = new System.Windows.Forms.Label();
            this.lbFactorialB = new System.Windows.Forms.Label();
            this.lbSumA = new System.Windows.Forms.Label();
            this.lbSumB = new System.Windows.Forms.Label();
            this.lbApowB = new System.Windows.Forms.Label();
            this.lbResultFacA = new System.Windows.Forms.Label();
            this.lbResultFacB = new System.Windows.Forms.Label();
            this.lbResultSumS1 = new System.Windows.Forms.Label();
            this.lbResultSumS2 = new System.Windows.Forms.Label();
            this.lbResultApowB = new System.Windows.Forms.Label();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A";
            // 
            // tbNum1
            // 
            this.tbNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum1.Location = new System.Drawing.Point(97, 35);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(184, 26);
            this.tbNum1.TabIndex = 1;
            this.tbNum1.Validating += new System.ComponentModel.CancelEventHandler(this.tbNum1_Validating);
            // 
            // tbNum2
            // 
            this.tbNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNum2.Location = new System.Drawing.Point(402, 32);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(184, 26);
            this.tbNum2.TabIndex = 3;
            this.tbNum2.TextChanged += new System.EventHandler(this.tbNum2_TextChanged);
            this.tbNum2.Validating += new System.ComponentModel.CancelEventHandler(this.tbNum2_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập B";
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(33, 107);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(314, 36);
            this.btnCal.TabIndex = 4;
            this.btnCal.Text = "Tính các giá trị";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnDel
            // 
            this.btnDel.CausesValidation = false;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(402, 107);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 36);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.CausesValidation = false;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(511, 107);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lbResultApowB);
            this.gbResult.Controls.Add(this.lbResultSumS2);
            this.gbResult.Controls.Add(this.lbResultSumS1);
            this.gbResult.Controls.Add(this.lbResultFacB);
            this.gbResult.Controls.Add(this.lbResultFacA);
            this.gbResult.Controls.Add(this.lbApowB);
            this.gbResult.Controls.Add(this.lbSumB);
            this.gbResult.Controls.Add(this.lbSumA);
            this.gbResult.Controls.Add(this.lbFactorialB);
            this.gbResult.Controls.Add(this.lbFactorialA);
            this.gbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.Location = new System.Drawing.Point(33, 163);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(553, 204);
            this.gbResult.TabIndex = 7;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "KẾT QUẢ";
            // 
            // lbFactorialA
            // 
            this.lbFactorialA.AutoSize = true;
            this.lbFactorialA.Location = new System.Drawing.Point(6, 34);
            this.lbFactorialA.Name = "lbFactorialA";
            this.lbFactorialA.Size = new System.Drawing.Size(46, 20);
            this.lbFactorialA.TabIndex = 0;
            this.lbFactorialA.Text = "A! = ";
            // 
            // lbFactorialB
            // 
            this.lbFactorialB.AutoSize = true;
            this.lbFactorialB.Location = new System.Drawing.Point(301, 34);
            this.lbFactorialB.Name = "lbFactorialB";
            this.lbFactorialB.Size = new System.Drawing.Size(41, 20);
            this.lbFactorialB.TabIndex = 1;
            this.lbFactorialB.Text = "B! =";
            // 
            // lbSumA
            // 
            this.lbSumA.AutoSize = true;
            this.lbSumA.Location = new System.Drawing.Point(6, 71);
            this.lbSumA.Name = "lbSumA";
            this.lbSumA.Size = new System.Drawing.Size(233, 20);
            this.lbSumA.TabIndex = 2;
            this.lbSumA.Text = "S1 = 1 + 2 + 3 + 4 + ... + A =";
            // 
            // lbSumB
            // 
            this.lbSumB.AutoSize = true;
            this.lbSumB.Location = new System.Drawing.Point(6, 113);
            this.lbSumB.Name = "lbSumB";
            this.lbSumB.Size = new System.Drawing.Size(233, 20);
            this.lbSumB.TabIndex = 3;
            this.lbSumB.Text = "S2 = 1 + 2 + 3 + 4 + ... + B =";
            // 
            // lbApowB
            // 
            this.lbApowB.AutoSize = true;
            this.lbApowB.Location = new System.Drawing.Point(6, 155);
            this.lbApowB.Name = "lbApowB";
            this.lbApowB.Size = new System.Drawing.Size(333, 20);
            this.lbApowB.TabIndex = 4;
            this.lbApowB.Text = "S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B =";
            // 
            // lbResultFacA
            // 
            this.lbResultFacA.AutoSize = true;
            this.lbResultFacA.Location = new System.Drawing.Point(47, 34);
            this.lbResultFacA.Name = "lbResultFacA";
            this.lbResultFacA.Size = new System.Drawing.Size(0, 20);
            this.lbResultFacA.TabIndex = 5;
            // 
            // lbResultFacB
            // 
            this.lbResultFacB.AutoSize = true;
            this.lbResultFacB.Location = new System.Drawing.Point(336, 34);
            this.lbResultFacB.Name = "lbResultFacB";
            this.lbResultFacB.Size = new System.Drawing.Size(0, 20);
            this.lbResultFacB.TabIndex = 6;
            // 
            // lbResultSumS1
            // 
            this.lbResultSumS1.AutoSize = true;
            this.lbResultSumS1.Location = new System.Drawing.Point(236, 71);
            this.lbResultSumS1.Name = "lbResultSumS1";
            this.lbResultSumS1.Size = new System.Drawing.Size(0, 20);
            this.lbResultSumS1.TabIndex = 7;
            // 
            // lbResultSumS2
            // 
            this.lbResultSumS2.AutoSize = true;
            this.lbResultSumS2.Location = new System.Drawing.Point(236, 113);
            this.lbResultSumS2.Name = "lbResultSumS2";
            this.lbResultSumS2.Size = new System.Drawing.Size(0, 20);
            this.lbResultSumS2.TabIndex = 8;
            // 
            // lbResultApowB
            // 
            this.lbResultApowB.AutoSize = true;
            this.lbResultApowB.Location = new System.Drawing.Point(336, 155);
            this.lbResultApowB.Name = "lbResultApowB";
            this.lbResultApowB.Size = new System.Drawing.Size(0, 20);
            this.lbResultApowB.TabIndex = 9;
            // 
            // BaiTH5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 379);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label1);
            this.Name = "BaiTH5";
            this.Text = "BaiTH5";
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label lbResultApowB;
        private System.Windows.Forms.Label lbResultSumS2;
        private System.Windows.Forms.Label lbResultSumS1;
        private System.Windows.Forms.Label lbResultFacB;
        private System.Windows.Forms.Label lbResultFacA;
        private System.Windows.Forms.Label lbApowB;
        private System.Windows.Forms.Label lbSumB;
        private System.Windows.Forms.Label lbSumA;
        private System.Windows.Forms.Label lbFactorialB;
        private System.Windows.Forms.Label lbFactorialA;
    }
}