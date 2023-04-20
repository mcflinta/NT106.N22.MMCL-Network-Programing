using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class BaiTH5 : Form
    {
        public BaiTH5()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            num1 = Int32.Parse(tbNum1.Text.Trim());
            num2 = Int32.Parse(tbNum2.Text.Trim());
            int fac1 = 1;
            int fac2 = 1;
            for(int i = 1; i <= num1; i++)
            {
                if (num1 == 0)
                    break;
                else
                    fac1 *= i;
                
                
            }
            for(int i = 1; i <= num2; i++)
            {
                if (num2 == 0)
                    break;
                else
                    fac2 *= i;
            }
            int sumS1 = 0;
            int sumS2 = 0;
            for (int i = 0; i <= num1; i++)
                sumS1 += i;
            for (int i = 0; i <= num2; i++)
                sumS2 += i;
            int powS3 = 0;
            for (int i = 1; i <= num2; i++)
                powS3 += (int)(Math.Pow(num1, i));
            lbResultFacA.Text = fac1.ToString();
            lbResultFacB.Text = fac2.ToString();
            lbResultSumS1.Text = sumS1.ToString();
            lbResultSumS2.Text = sumS2.ToString();
            lbResultApowB.Text = powS3.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbNum1.Clear();
            tbNum2.Clear();
            lbResultFacA.Text = string.Empty;
            lbResultFacB.Text = string.Empty;
            lbResultSumS1.Text = string.Empty;
            lbResultSumS2.Text = string.Empty;
            lbResultApowB.Text = string.Empty;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbNum1_Validating(object sender, CancelEventArgs e)
        {
            int number;
            if ((!int.TryParse(tbNum1.Text, out number)) || number < 0)
            {
                e.Cancel = true;
                tbNum1.Focus();
                tbNum1.SelectAll();
                MessageBox.Show("Vui lòng nhập số nguyên dương!");
            }
            

        }

        private void tbNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNum2_Validating(object sender, CancelEventArgs e)
        {
            int number;
            if ((!int.TryParse(tbNum1.Text, out number)) || number < 0)
            {
                e.Cancel = true;
                tbNum1.Focus();
                tbNum1.SelectAll();
                MessageBox.Show("Vui lòng nhập số nguyên dương!");
            }
        }
    }
}
