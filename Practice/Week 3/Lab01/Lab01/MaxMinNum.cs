using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class MaxMinNum : Form
    {
        public MaxMinNum()
        {
            InitializeComponent();
        }

        private void tbNum1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            float num1;
            float num2;
            float num3;
            num1 = float.Parse(tbNum1.Text.Trim());
            num2 = float.Parse(tbNum2.Text.Trim());
            num3 = float.Parse(tbNum3.Text.Trim());
            if (num1 >= num2 && num2 >= num3)
            {
                tbMax.Text = num1.ToString();
                tbMin.Text = num3.ToString();
            }
            else if(num1 >= num3 && num3 >= num2)
            {
                tbMin.Text = num2.ToString();
                tbMax.Text = num1.ToString();
            }
            else if (num2 >= num3 && num3 >= num1)
            {
                tbMax.Text = num2.ToString();
                tbMin.Text = num1.ToString();
            }
            else if(num2 >= num1 && num1 >= num3)
            {
                tbMax.Text=num2.ToString();
                tbMin.Text=num3.ToString();
            }
            else if (num3 >= num1 && num1 >= num2)
            {
                tbMax.Text = num3.ToString();
                tbMin.Text = num2.ToString();
            }
            else
            {
                tbMax.Text = num3.ToString();
                tbMin.Text = num1.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // xóa nội dung tất cả textbox
            tbNum1.Clear();
            tbNum2.Clear();
            tbNum3.Clear();
            tbMax.Clear();
            tbMin.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // thoát chương trình MaxMinNum
            this.Close();
        }

        private void tbNum1_Validated(object sender, EventArgs e)
        {

        }
        //Kiểm tra đầu vào của số thứ nhất
        private void tbNum1_Validating(object sender, CancelEventArgs e)
        {
            float number;
            if (!float.TryParse(tbNum1.Text, out number))
            {
                e.Cancel = true;
                tbNum1.Focus();
                tbNum1.SelectAll();
                MessageBox.Show("Vui lòng nhập số!");
            }
        }

        private void tbNum2_Validating(object sender, CancelEventArgs e)
        {   
            float number;
            if(!float.TryParse(tbNum2.Text, out number))
            {
                e.Cancel = true;
                tbNum2.Focus();
                tbNum2.SelectAll();
                MessageBox.Show("Vui lòng nhập số!");
            }
            
        }

        private void tbNum3_Validating(object sender, CancelEventArgs e)
        {
            float number;
            if (!float.TryParse(tbNum3.Text, out number))
            {
                e.Cancel = true;
                tbNum3.Focus();
                tbNum3.SelectAll();
                MessageBox.Show("Vui lòng nhập số!");
            }
        }
    }
}
