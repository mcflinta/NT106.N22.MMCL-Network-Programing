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
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public class SinhVien
        {
            public string HoTen { get; set; }
            public int MSSV { get; set; }
            public string DienThoai { get; set; }
            public float DiemMon1 { get; set; }
            public float DiemMon2 { get; set; }
            public float DiemMon3 { get; set; }
            public float DiemTrungBinh { get; set; }
            public bool IsValid()
            {
                return (MSSV.ToString().Length == 8 && DienThoai.StartsWith("0") && DienThoai.Length == 10);
            }
        }
        // Nhập danh sách sinh viên
        List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        private void btnWrite_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("input4.txt", FileMode.Create))
            {
                formatter.Serialize(stream, danhSachSinhVien);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            while (true)
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.HoTen = tbNameWrite.Text;
                sinhVien.MSSV = Convert.ToInt32(tbIDWrite.Text);
                sinhVien.DienThoai = tbPhoneWrite.Text;
                sinhVien.DiemMon1 = Convert.ToInt32(tbCourse1.Text);
                sinhVien.DiemMon2 = Convert.ToInt32(tbCourse2.Text);
                sinhVien.DiemMon3 = Convert.ToInt32(tbCourse3.Text);
                danhSachSinhVien.Add(sinhVien);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream("input4.txt", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                danhSachSinhVien = (List<SinhVien>)formatter.Deserialize(stream);
            }
            using (StreamWriter writer = new StreamWriter("output4.txt"))
            {
                int currentPage = Convert.ToInt32(lbCount);
                int pageSize = 5;
                int totalPages = (int)Math.Ceiling((double)danhSachSinhVien.Count / pageSize);
            }
            
        }
    }
}
