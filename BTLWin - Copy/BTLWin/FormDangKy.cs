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
    public partial class FormDangKy : Form
    {
        String connString = @"Data Source=DESKTOP-JFHBGFI;Initial Catalog=QLTCCN;Integrated Security=True";
        String imageLocation = "";
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void bttCaoNhapTK_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    String sql = "Insert into TaiKhoan values(@tenDN,@tenKH,@GTinh,@NgaySinh,@MatKhau,@Anh)";
                    if (txbTenDN.Text.Equals("")) throw new Exception("Tên đăng nhập không được bỏ trống!!!");
                    if (txbTenKH.Text.Equals("")) throw new Exception("Tên người dùng không được bỏ trống!!!");
                    if (radiobttNam.Checked == false && radiobttNu.Checked == false) throw new Exception("Chưa chọn giới tính!!!");
                    if (txbMatKhau.Text.Equals("")) throw new Exception("Mật khẩu không được bỏ trống!!!");
                    if (textMatKhauXN.Text.Equals("")) throw new Exception("Mật khẩu xác nhận không được bỏ trống!!!");
                    if(txbMatKhau.Text!=textMatKhauXN.Text) throw new Exception("Mật khẩu xác nhận không chính xác!!!");
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    String sql1 = "Select tenDN from TaiKhoan";
                    SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (txbTenDN.Text == dt1.Rows[i].ItemArray[0].ToString()) throw new Exception("Đã có tài khoản đăng nhập là " + txbTenDN.Text);
                    }

                    cmd.Parameters.AddWithValue("@tenDN", txbTenDN.Text);
                    cmd.Parameters.AddWithValue("@tenKH", txbTenKH.Text);
                    if(radiobttNam.Checked==true)
                        cmd.Parameters.AddWithValue("@GTinh", 0);
                    else
                        cmd.Parameters.AddWithValue("@GTinh", 1);
                    cmd.Parameters.AddWithValue("@NgaySinh", dateNgaysinh.Value);
                    cmd.Parameters.AddWithValue("@MatKhau", txbMatKhau.Text);
                    cmd.Parameters.AddWithValue("@Anh", imageLocation.Trim());
                    cmd.ExecuteNonQuery();
                    this.Close();
                    FormLogin login = new FormLogin();
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bttImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| ALL Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    img1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không thể truy cập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            dateNgaysinh.CustomFormat = "dd-MM-yyyy";
            dateNgaysinh.Format = DateTimePickerFormat.Custom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin dangKy = new FormLogin();
            this.Hide();
            dangKy.ShowDialog();
        }
    }
}
