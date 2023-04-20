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
    public partial class BaiTH2 : Form
    {
        public BaiTH2()
        {
            InitializeComponent();
        }
        private void BaiTH2_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int number;
            number = Int32.Parse(tbNum.Text.Trim());
            switch(number)
            {
                case 0:
                    tbResult.Text = "Không";
                    break;
                case 1:
                    tbResult.Text = "Một";
                    break;
                case 2:
                    tbResult.Text = "Hai";
                    break;
                case 3:
                    tbResult.Text = "Ba";
                    break;
                case 4:
                    tbResult.Text = "Bốn";
                    break;
                case 5:
                    tbResult.Text = "Năm";
                    break;
                case 6:
                    tbResult.Text = "Sáu";
                    break;
                case 7:
                    tbResult.Text = "Bảy";
                    break;
                case 8:
                    tbResult.Text = "Tám";
                    break;
                case 9:
                    tbResult.Text = "Chín";
                    break;
            }
        }

        private void tbNum_Validating(object sender, CancelEventArgs e)
        {
            int number;
            if (!int.TryParse(tbNum.Text, out number))
            {
                e.Cancel = true;
                tbNum.Focus();
                tbNum.SelectAll();
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!");
            }
            else if(number < 0 || number >= 10)
            {
                e.Cancel = true;
                tbNum.Focus();
                tbNum.SelectAll();
                MessageBox.Show("Vui lòng nhập số nguyên từ 0 đến 9!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbNum.Clear();
            tbResult.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
