using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using NCalc;
using System.Security.Policy;
using System.Collections;

namespace Lab02_NT106
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }
     
        private void btnRead_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("input3.txt"))
            {
                rtbContent.Text = reader.ReadToEnd();
            }
        }
        private void btnWriteOutput_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("input3.txt"))
            {
                string content = reader.ReadToEnd();
                string[] expressions = content.Split('\r');
                Stack<double> result = new Stack<double>();
                DataTable dt = new DataTable();
                dt.Columns.Add("expression", typeof(string));
                foreach (string expression in expressions)
                {
                    DataRow dr = dt.NewRow();
                    dr["expression"] = expression;
                    dt.Rows.Add(dr);
                    object resultStr = dt.Compute(expression, null);
                    double value = Convert.ToDouble(resultStr);
                    result.Push(value);

                }

                using (StreamWriter writer = new StreamWriter("output3.txt"))
                {
                   
                    for (int i = expressions.Length - 1;  i >= 0; i--)
                    {
                        expressions[i] += " = " + result.Pop();
                    }
                    foreach(string expression in expressions)
                    {
                        writer.Write(expression);
                    }
                }

                
            }
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void btnReadOutput_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("output3.txt"))
            {
                rtbContent.Text = reader.ReadToEnd();
            }
        }
    }
}
