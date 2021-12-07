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
    public partial class FormAccounts : Form
    {
        String connString = @"Data Source=DESKTOP-JFHBGFI;Initial Catalog=QLTCCN;Integrated Security=True";
        String maTN = "";
        string tenDN1;
        public FormAccounts(string tenDN)
        {
            InitializeComponent();
            tenDN1 = tenDN;
        }

        void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                String sql = "Select TenTheLoaiTN,SotienTN,ThoiGianTN,ChiTietTN,MaTN from Accounts,TheLoaiAccounts where Accounts.MaTheLoaiTN=TheLoaiAccounts.MaTheLoaiTN";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGVAccounts.DataSource = dt;
                dGVAccounts.Columns[4].Visible = false;
                dGVAccounts.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                
            }
        }

        void LoadCbb()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                String sql = "select * from TheLoaiAccounts";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxAcc.DataSource = dt;
                comboBoxAcc.DisplayMember = "TenTheLoaiTN";
                comboBoxAcc.ValueMember = "MaTheLoaiTN";
            }
        }

        private void FormAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                LoadCbb();
                dateTimePickerAcc.CustomFormat = "dd-MM-yyyy hh:mm tt";
                dateTimePickerAcc.Format = DateTimePickerFormat.Custom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dGVAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dGVAccounts.Rows[e.RowIndex];
                    comboBoxAcc.Text = row.Cells[0].Value.ToString();
                    textBoxAcc.Text = row.Cells[1].Value.ToString();
                    dateTimePickerAcc.Value =Convert.ToDateTime(row.Cells[2].Value.ToString());
                    richTextBoxAcc.Text = row.Cells[3].Value.ToString();
                    maTN = row.Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttAccThem_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn=new SqlConnection(connString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    String sql = "Insert into Accounts values(@MaTheLoaiTN,@SotienTN,@ThoiGianTN,@ChiTietTN,@tenDN)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaTheLoaiTN", comboBoxAcc.SelectedValue.ToString());
                    if (textBoxAcc.Text.Equals("")) throw new Exception("Không được bỏ trống tiền thu nhập!!!");
                    if (!UInt64.TryParse(textBoxAcc.Text, out UInt64 o))
                        throw new Exception("Lỗi định dạng tiền tệ!!!");
                    cmd.Parameters.AddWithValue("@SotienTN", Int64.Parse(textBoxAcc.Text));
                    cmd.Parameters.AddWithValue("@ThoiGianTN", dateTimePickerAcc.Value);
                    if (richTextBoxAcc.Text.Equals("")) throw new Exception("Không được bỏ trống chi tiết thu nhập!!!");
                    cmd.Parameters.AddWithValue("@ChiTietTN", richTextBoxAcc.Text);
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

        private void bttAccSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (maTN == "") throw new Exception("Chưa chọn dòng thu nhập nào!!!");
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    String sql = "update Accounts set MaTheLoaiTN= @MaTheLoaiTN,SotienTN= @SotienTN,ThoiGianTN= @ThoiGianTN,ChiTietTN= @ChiTietTN where MaTN=@MaTN";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    if (comboBoxAcc.SelectedIndex.Equals(""))
                        throw new Exception("Vui lòng chọn loại thu nhập!!!");
                    cmd.Parameters.AddWithValue("@MaTheLoaiTN", comboBoxAcc.SelectedValue.ToString());
                    if (textBoxAcc.Text.Equals("")) throw new Exception("Không được bỏ trống tiền thu nhập!!!");
                    if (!UInt64.TryParse(textBoxAcc.Text, out UInt64 o))
                        throw new Exception("Lỗi định dạng tiền tệ!!!");
                    cmd.Parameters.AddWithValue("@SotienTN", Int64.Parse(textBoxAcc.Text));
                    cmd.Parameters.AddWithValue("@ThoiGianTN", dateTimePickerAcc.Value);
                    if (richTextBoxAcc.Text.Equals("")) throw new Exception("Không được bỏ trống chi tiết thu nhập!!!");
                    cmd.Parameters.AddWithValue("@ChiTietTN", richTextBoxAcc.Text);
                    cmd.Parameters.AddWithValue("@MaTN",maTN);
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

        private void bttAccXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (maTN == "") throw new Exception("Chưa chọn dòng thu nhập nào!!!");
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    if(MessageBox.Show("Bạn chắc chắn muốn xóa dòng thu nhập này?","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        String sql = "delete Accounts Where MaTN=@MaTN";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@MaTN", maTN);
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
        void clear()
        {
            textBoxAcc.Clear();
            richTextBoxAcc.Clear();
            dateTimePickerAcc.Value = DateTime.Now;
            comboBoxAcc.SelectedIndex = 0;
        }
    }
}
