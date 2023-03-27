namespace Lab01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB4 = new System.Windows.Forms.Button();
            this.btnB5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(78, 51);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(150, 50);
            this.btnB1.TabIndex = 0;
            this.btnB1.Text = "Bài 1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // btnB2
            // 
            this.btnB2.Location = new System.Drawing.Point(317, 51);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(150, 50);
            this.btnB2.TabIndex = 1;
            this.btnB2.Text = "Bài 2";
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.btnB2_Click);
            // 
            // btnB3
            // 
            this.btnB3.Location = new System.Drawing.Point(78, 144);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(150, 50);
            this.btnB3.TabIndex = 2;
            this.btnB3.Text = "Bài 3";
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click);
            // 
            // btnB4
            // 
            this.btnB4.Location = new System.Drawing.Point(317, 144);
            this.btnB4.Name = "btnB4";
            this.btnB4.Size = new System.Drawing.Size(150, 50);
            this.btnB4.TabIndex = 3;
            this.btnB4.Text = "Bài 4";
            this.btnB4.UseVisualStyleBackColor = true;
            this.btnB4.Click += new System.EventHandler(this.btnB4_Click);
            // 
            // btnB5
            // 
            this.btnB5.Location = new System.Drawing.Point(78, 237);
            this.btnB5.Name = "btnB5";
            this.btnB5.Size = new System.Drawing.Size(150, 50);
            this.btnB5.TabIndex = 4;
            this.btnB5.Text = "Bài 5";
            this.btnB5.UseVisualStyleBackColor = true;
            this.btnB5.Click += new System.EventHandler(this.btnB5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 387);
            this.Controls.Add(this.btnB5);
            this.Controls.Add(this.btnB4);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lab01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB4;
        private System.Windows.Forms.Button btnB5;
    }
}

