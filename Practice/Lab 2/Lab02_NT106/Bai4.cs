using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02_NT106
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        private void Bai4_Load(object sender, EventArgs e)
        {

        }
        [Serializable]
        public class Student
        {
            public string name { get; set; }
            public int id { get; set; }
            public string phone { get; set; }
            public float course1 { get; set; }
            public float course2 { get; set; }
            public float course3 { get; set; }
            public float averageScore { get; set; }
        }

        private List<Student> students = new List<Student>();
        private void btnWrite_Click(object sender, EventArgs e)
        {
            using(StreamWriter writer = File.CreateText("output4.txt"))
            {
                foreach(Student student in students)
                {
                    writer.WriteLine(student.name);
                    writer.WriteLine(student.id);
                    writer.WriteLine(student.phone);
                    writer.WriteLine(student.course1);
                    writer.WriteLine(student.course2);
                    writer.WriteLine(student.course3);
                    writer.WriteLine(student.averageScore);
                    writer.WriteLine();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAverageWrite.Text != null && tbCourse1Write.Text != null && tbCourse2Write.Text != null 
                && tbCourse3Write.Text != null && tbIDWrite.Text != null && tbNameWrite.Text != null
                && tbPhoneWrite.Text != null && tbAverageWrite.Text == null)
            {
                if (string.IsNullOrEmpty(tbPhoneWrite.Text) || !Regex.IsMatch(tbPhoneWrite.Text, @"^0-9{10}$"))
                {
                    MessageBox.Show("Số điện thoại phải có đầu 0 và có 10 số");
                    return;
                }

                if (string.IsNullOrEmpty(tbIDWrite.Text) || !Regex.IsMatch(tbIDWrite.Text, @"^A-Z{2}0-9{6}$"))
                {
                    MessageBox.Show("Mã số sinh viên phải con số có 6 chữ số");
                    return;
                }

                Student student = new Student()
                {
                    name = tbNameWrite.Text,
                    id = int.Parse(tbIDWrite.Text),
                    phone = tbPhoneWrite.Text,
                    course1 = float.Parse(tbCourse1Write.Text),
                    course2 = float.Parse(tbCourse2Write.Text),
                    course3 = float.Parse(tbCourse3Write.Text),
                    averageScore = (float.Parse(tbCourse1Write.Text) + float.Parse(tbCourse2Write.Text) + float.Parse(tbCourse3Write.Text)) / 3
                };
                students.Add(student);
            }
            else
            {
                MessageBox.Show("Vui long nhap day du thong tin");
                return;
            }
            

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream stream = File.OpenRead("input4.txt"))
            {
                students = (List<Student>)formatter.Deserialize(stream);
                
            }
            using(StreamReader reader = new StreamReader("output4.txt"))
            {
                rtbContent.Text = reader.ReadToEnd();
            }    
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream stream = File.Open("input4.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, students);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int page = Int32.Parse(lbCount.Text) - 1;

            if (page >= 0)
            {
                lbCount.Text = page.ToString();
                tbCourse1Read.Text = students[page].course1.ToString();
                tbCourse2Read.Text = students[page].course2.ToString();
                tbCourse3Read.Text = students[page].course3.ToString();
                tbIDRead.Text = students[page].id.ToString();
                tbAverageRead.Text = students[page].averageScore.ToString();
                tbNameRead.Text = students[page].name.ToString();
                tbPhoneRead.Text = students[page].phone.ToString();
            }
            else
            {
                MessageBox.Show("Đã đi tới đầu trang");
                return;
            }
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
         
            int page = Int32.Parse(lbCount.Text) + 1;
            
            if (page < students.Count)
            {
                lbCount.Text = page.ToString();
                tbCourse1Read.Text = students[page].course1.ToString();
                tbCourse2Read.Text = students[page].course2.ToString();
                tbCourse3Read.Text = students[page].course3.ToString();
                tbIDRead.Text = students[page].id.ToString();
                tbAverageRead.Text = students[page].averageScore.ToString();
                tbNameRead.Text = students[page].name.ToString();
                tbPhoneRead.Text = students[page].phone.ToString();
            }
            else
            {
                MessageBox.Show("Đã đi tới cuối trang");
                return;
            }
        }
    }
}
