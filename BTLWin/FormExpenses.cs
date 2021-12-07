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
    public partial class FormExpenses : Form
    {
        String connString = @"Data Source=DESKTOP-LM1JJVT\SQLEXPRESS;Initial Catalog=QLTCCN;Integrated Security=True";
        String maCT = "";
        string tenDN1;
        public FormExpenses(string tenDN)
        {
            InitializeComponent();
            tenDN1 = tenDN;
            
        }
        void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                String sql = "Select TenTheLoaiCT,SotienCT,ThoiGianCT,ChiTietCT,id from Expenses,TheLoaiExpenses where Expenses.MaTheLoaiCT=TheLoaiExpenses.MaTheLoaiCT ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGVExpenses.DataSource = dt;
                dGVExpenses.Columns[4].Visible = false;
                dGVExpenses.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
            }
        }

        void LoadCbb()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                String sql = "select * from TheLoaiExpenses";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbExpenTheLoai.DataSource = dt;
                cbbExpenTheLoai.DisplayMember = "TenTheLoaiCT";
                cbbExpenTheLoai.ValueMember = "MaTheLoaiCT";
            }
        }

        private void FormExpenses_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                LoadCbb();
                datatimeExpen.CustomFormat = "dd-MM-yyyy hh:mm tt";
                datatimeExpen.Format = DateTimePickerFormat.Custom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttExpenThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    String sql = "Insert into Expenses values(@MaTheLoaiCT,@SotienCT,@ThoiGianCT,@ChiTietCT,@tenDN)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaTheLoaiCT", cbbExpenTheLoai.SelectedValue.ToString());
                    if (txtBExpenSotien.Text.Equals("")) throw new Exception("Không được bỏ trống tiền chi tiêu!!!");
                    if (!UInt64.TryParse(txtBExpenSotien.Text, out UInt64 o))
                        throw new Exception("Lỗi định dạng tiền tệ!!!");
                    cmd.Parameters.AddWithValue("@SotienCT", Int64.Parse(txtBExpenSotien.Text));
                    cmd.Parameters.AddWithValue("@ThoiGianCT", datatimeExpen.Value);
                    if (richTextBoxExpen.Text.Equals("")) throw new Exception("Không được bỏ trống chi tiết chi tiêu!!!");
                    cmd.Parameters.AddWithValue("@ChiTietCT", richTextBoxExpen.Text);
                    cmd.Parameters.AddWithValue("@tenDN", tenDN1);
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

        private void dGVExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dGVExpenses.Rows[e.RowIndex];
                    cbbExpenTheLoai.Text = row.Cells[0].Value.ToString();
                    txtBExpenSotien.Text = row.Cells[1].Value.ToString();
                    datatimeExpen.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                    richTextBoxExpen.Text = row.Cells[3].Value.ToString();
                    maCT = row.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void clear()
        {
            txtBExpenSotien.Clear();
            richTextBoxExpen.Clear();
            datatimeExpen.Value = DateTime.Now;
            cbbExpenTheLoai.SelectedIndex = 0;
        }

        private void bttExpenSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (maCT == "") throw new Exception("Chưa chọn dòng chi tiêu nào!!!");
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    String sql = "update Expenses set MaTheLoaiCT= @MaTheLoaiCT,SotienCT=@SotienCT,ThoiGianCT=@ThoiGianCT,ChiTietCT=@ChiTietCT where id=@MaCT";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    if (cbbExpenTheLoai.SelectedIndex.Equals(""))
                        throw new Exception("Vui lòng chọn loại thu nhập!!!");
                    cmd.Parameters.AddWithValue("@MaTheLoaiCT", cbbExpenTheLoai.SelectedValue.ToString());
                    if (txtBExpenSotien.Text.Equals("")) throw new Exception("Không được bỏ trống tiền thu nhập!!!");
                    if (!UInt64.TryParse(txtBExpenSotien.Text, out UInt64 o))
                        throw new Exception("Lỗi định dạng tiền tệ!!!");
                    cmd.Parameters.AddWithValue("@SotienCT", Int64.Parse(txtBExpenSotien.Text));
                    cmd.Parameters.AddWithValue("@ThoiGianCT", datatimeExpen.Value);
                    if (richTextBoxExpen.Text.Equals("")) throw new Exception("Không được bỏ trống chi tiết thu nhập!!!");
                    cmd.Parameters.AddWithValue("@ChiTietCT", richTextBoxExpen.Text);
                    cmd.Parameters.AddWithValue("@MaCT", maCT);
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

        private void bttExpenXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (maCT == "") throw new Exception("Chưa chọn dòng thu nhập nào!!!");
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa dòng thu nhập này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        String sql = "delete Expenses Where id=@MaCT";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@MaCT", maCT);
                        cmd.ExecuteNonQuery();
                        LoadData();
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
