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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file
                string filePath = ofd.FileName;
                // Tạo đối tương FileStream để lấy thông tin file
                using(FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    // Lấy tên file và đường dẫn Url
                    string fileName = ofd.SafeFileName;
                    string url = fs.Name;
                    // Lấy kích thước file  
                    long fileSize = fs.Length;
                    // Đếm số dòng, số từ và số ký tự
                    int lineNumber = 0;
                    int wordNumber = 0;
                    int characterNumber = 0;
                    using(StreamReader reader = new StreamReader(fs)) 
                    {
                        string line;
                        while((line = reader.ReadLine()) != null)
                        {
                            lineNumber++;
                            characterNumber += line.Length;
                            string[] words = line.Split(' ');
                            wordNumber += words.Length;
                        }
                    }

                    // Hiển thị thông tin file
                    tbFileName.Text = fileName;
                    tbSize.Text = fileSize.ToString();
                    tbUrl.Text = url;
                    tbLineCount.Text = lineNumber.ToString();
                    tbWordsCount.Text = wordNumber.ToString();
                    tbChacracterCount.Text = characterNumber.ToString();
                    // Đọc nội dung file và hiển thị lên RichTextBox
                    using(StreamReader reader = new StreamReader(filePath))
                    {
                        string content = reader.ReadToEnd();
                        rtbContent.Text = content;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
