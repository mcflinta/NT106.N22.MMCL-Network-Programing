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
    public partial class BaiTH4 : Form
    {
        public BaiTH4()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double number;
            double result = 0;
            number = float.Parse(tbMoney.Text.Trim());
            switch(cbCurrency.Text)
            {
                case "USD (Đô-la Mỹ)":
                    result = number * 22772;
                    tbResult.Text = $"{result:N0}".ToString();
                    break;
                case "EUR (Đồng Euro)":
                    result = number * 28132;
                    tbResult.Text = $"{result:N0}".ToString();
                    break;
                case "GBP (Bảng Anh)":
                    result = number * 31538;
                    tbResult.Text = $"{result:N0}".ToString();
                    break;
                case "SGD (Đô-la Singapore)":
                    result = number * 17286;
                    tbResult.Text = $"{result:N0}".ToString();
                    break;
                case "JPY (Yên Nhật)":
                    result = number * 214;
                    tbResult.Text = $"{result:N0}".ToString();
                    break;
            }
        }

        private void lbConverPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbCurrency.Text)
            {
                case "USD (Đô-la Mỹ)":
                    lbConverPrice.Text = "1 USD = 22,772 VND";
                    break;
                case "GBP (Bảng Anh)":
                    lbConverPrice.Text = "1 GBP = 31,538 VND";
                    break;
                case "EUR (Đồng Euro)":
                    lbConverPrice.Text = "1 EUR = 28,132 VND";
                    break;
                case "SGD (Đô-la Singapore)":
                    lbConverPrice.Text = "1 SGD = 17,286 VND";
                    break;
                case "JPY (Yên Nhật)":
                    lbConverPrice.Text = "1 JPY = 214 VND";
                    break;
            }
        }

        private void tbMoney_Validating(object sender, CancelEventArgs e)
        {
            float number;
            if (!float.TryParse(tbMoney.Text, out number))
            {
                e.Cancel = true;
                tbMoney.Focus();
                tbMoney.SelectAll();
                MessageBox.Show("Vui lòng nhập số tiền!");
            }
            if(cbCurrency.SelectedItem == null)
            {
                e.Cancel = true;
                MessageBox.Show("Vui lòng chọn đơn vị tiền tệ!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
