using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_NT106
{
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Form myForm = new Bai1();
            myForm.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Form myForm = new Bai2();
            myForm.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Form myForm = new Bai3();
            myForm.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Form myForm = new Bai4();
            myForm.ShowDialog();
        }
    }
}
