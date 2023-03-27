using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StudentManagement
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-OJKQD5I\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Student";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            tbID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tbName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tbbirth.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tbAddress.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into Student values('"+tbID.Text+"', N'"+tbName.Text+"', '"+tbbirth.Text+"', N'"+tbAddress.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from Student where id = '"+tbID.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update Student set id = '"+tbID.Text+"', name = N'"+tbName.Text+"', birth = '"+tbbirth.Text+"', address = N'"+tbAddress.Text+"' where id = '"+tbID.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (connection == null)
                connection = new SqlConnection();
            if(connection.State == ConnectionState.Closed)
                connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from Student where id=@id";
            command.Connection = connection;
            SqlParameter parama = new SqlParameter("@id", SqlDbType.Int);
            parama.Value = tbSearch.Text;
            command.Parameters.Add(parama);
            SqlDataReader reader = command.ExecuteReader();
            
                    if (reader.Read())
                    {
                        tbID.Text = reader.GetInt32(0).ToString();
                        tbName.Text = reader.GetString(1);
                        tbbirth.Text = reader.GetDateTime(2).ToString();
                        tbAddress.Text = reader.GetString(3);
                    }
                    reader.Close();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
