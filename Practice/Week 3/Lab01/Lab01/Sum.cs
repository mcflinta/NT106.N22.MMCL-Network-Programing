using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01
{
    public partial class Sum : Form
    {
        public Sum()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num1; 
            int num2;
            long sum = 0;
            num1 =  Int32.Parse(tbnum1.Text.Trim());
            num2 = Int32.Parse(tbnum2.Text.Trim());
            sum = num1 + num2;
            tbResult.Text = sum.ToString();
        }

        private void tbnum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnum1_Validated(object sender, EventArgs e)
        {

        }
        //Kiểm tra giá trị đầu vào của số thứ nhất
        private void tbnum1_Validating(object sender, CancelEventArgs e)
        {
            int number;
            if (!int.TryParse(tbnum1.Text, out number))
            {
                e.Cancel = true;
                tbnum1.Focus();
                tbnum1.SelectAll();
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }
        //Kiểm tra đầu vào của số thứ hai
        private void tbnum2_Validating(object sender, CancelEventArgs e)
        {
            int number;
            if(!int.TryParse(tbnum2.Text, out number))
            {
                e.Cancel = true;
                tbnum2.Focus();
                tbnum2.SelectAll();
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
