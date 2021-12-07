using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLWin
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }
        String connString = @"Data Source=DESKTOP-LM1JJVT\SQLEXPRESS;Initial Catalog=QLTCCN;Integrated Security=True";
        void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                String sql = "Select * from TheLoaiAccounts";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                String sql1 = "Select * from TheLoaiExpenses";
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView2.DataSource = dt1;
            }
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    String sql = "Insert into TheLoaiAccounts values(@TenTheLoaiTN)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (textBox1.Text.Trim() == "") throw new Exception("Không được bỏ trống thể loại thu nhập!!!");
                    cmd.Parameters.AddWithValue("@TenTheLoaiTN", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    
                    int index = dataGridView1.CurrentCell.RowIndex;
                    string maLoaiTN = null;
                    maLoaiTN= dataGridView1.Rows[index].Cells[0].Value.ToString();
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa loại thu nhập này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        String sql = "delete TheLoaiAccounts Where MaTheLoaiTN=@MaTheLoaiTN";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@MaTheLoaiTN",maLoaiTN);
                        cmd.ExecuteNonQuery();
                        LoadData();
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chưa chọn dòng loại thu nhập để xóa!!!");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    textBox1.Text=row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    String sql = "Insert into TheLoaiExpenses values(@TenTheLoaiCT)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (textBox2.Text.Trim() == "") throw new Exception("Không được bỏ trống thể loại chi tiêu!!!");
                    cmd.Parameters.AddWithValue("@TenTheLoaiCT", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {

                    int index = dataGridView2.CurrentCell.RowIndex;
                    string maLoaiCT = null;
                    maLoaiCT = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa loại chi tiêu này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        String sql = "delete TheLoaiExpenses Where MaTheLoaiCT=@MaTheLoaiCT";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@MaTheLoaiCT", maLoaiCT);
                        cmd.ExecuteNonQuery();
                        LoadData();
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chưa chọn dòng loại chi tiêu để xóa!!!");
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                    textBox2.Text = row.Cells[1].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
