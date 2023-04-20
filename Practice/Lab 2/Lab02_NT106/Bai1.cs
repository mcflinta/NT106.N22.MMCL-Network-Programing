using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_NT106
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ReadFile(openFileDialog.FileName);
            }
        }
        private void ReadFile(string filePath)
        {
            // Mở filestream
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                // Đọc toàn bộ dữ liệu và đẩy vào RichTextBox
                using (StreamReader reader = new StreamReader(stream))
                {
                    string content = reader.ReadToEnd();
                    rtbInforFile.Text = content;
                }
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string content = rtbInforFile.Text;
                SaveFile(filePath, content);
            }
        }
        private void SaveFile(string filePath, string content)
        {
            // Mở filestream
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                // Ghi nội dung vào file
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(content.ToUpper());
                }
            }
        }
        
    }
}
