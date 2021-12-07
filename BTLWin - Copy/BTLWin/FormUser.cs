using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLWin
{
    public partial class FormUser : Form
    {
        String connString = @"Data Source=DESKTOP-JFHBGFI;Initial Catalog=QLTCCN;Integrated Security=True";
        string tenDN1;
        String imageLocation = "";
        public FormUser(string tenDN)
        {
            InitializeComponent();
            tenDN1 = tenDN;
        }

        private void bttImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| ALL Files(*.*)|*.*";
                if( dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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

        private void bttCaoNhapTK_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    String sql = "Update TaiKhoan set tenKH=@tenKH,GTinh=@GTinh,NgaySinh=@NgaySinh,MatKhau= @MatKhau,Anh=@Anh where tenDN=@tenDN1";
                    if (txbTenKH.Text.Equals("")) throw new Exception("Tên người dùng không được bỏ trống!!!");
                    if (radiobttNam.Checked == false && radiobttNu.Checked == false) throw new Exception("Chưa chọn giới tính!!!");
                    if (txbMatKhauMoi.Text.Equals("")) throw new Exception("Mật khẩu không được bỏ trống!!!");
                    if (txbNhapLaiMatKhau.Text.Equals("")) throw new Exception("Mật khẩu xác nhận không được bỏ trống!!!");
                    if (txbMatKhauMoi.Text != txbNhapLaiMatKhau.Text) throw new Exception("Mật khẩu xác nhận không chính xác!!!");
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@tenKH", txbTenKH.Text);
                    if (radiobttNam.Checked == true)
                        cmd.Parameters.AddWithValue("@GTinh", 0);
                    else
                        cmd.Parameters.AddWithValue("@GTinh", 1);
                    cmd.Parameters.AddWithValue("@NgaySinh", dateNgáyinh.Value);
                    cmd.Parameters.AddWithValue("@MatKhau", txbMatKhauMoi.Text);
                    cmd.Parameters.AddWithValue("@Anh", imageLocation.Trim());
                    cmd.Parameters.AddWithValue("@tenDN1", tenDN1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                dateNgáyinh.CustomFormat = "dd-MM-yyyy";
                dateNgáyinh.Format = DateTimePickerFormat.Custom;
                String sql = "Select * From TaiKhoan";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(tenDN1== dt.Rows[i].ItemArray[0].ToString())
                    {
                        txbTenDN.Text = dt.Rows[i].ItemArray[0].ToString();
                 
                        txbTenKH.Text = dt.Rows[i].ItemArray[1].ToString();
                        if (dt.Rows[i].ItemArray[2].ToString() == "False")
                            radiobttNam.Checked = true;
                        else radiobttNu.Checked = true;
                        dateNgáyinh.Value = Convert.ToDateTime(dt.Rows[i].ItemArray[3].ToString());
                        break;
                    }    
                }
                



            }
        }
    }
}
