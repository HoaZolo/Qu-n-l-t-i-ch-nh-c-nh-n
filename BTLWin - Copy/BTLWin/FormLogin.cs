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
    public partial class FormLogin : Form
    {
        String tenDN = "";
        String connString = @"Data Source=DESKTOP-JFHBGFI;Initial Catalog=QLTCCN;Integrated Security=True";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Ẩn mật khẩu";
                txtMK.PasswordChar = '\0';
            }
            else
            {
                checkBox1.Text = "Hiển thị mật khẩu";
                txtMK.PasswordChar = '•';
            }
        }
        private void dangNhap()
        {
            string taikhoan = txtTenDN.Text.Trim();
            string matkhau = txtMK.Text.Trim();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (taikhoan.Equals("")) throw new Exception("Tài khoản không được để trống!");
                    if (matkhau.Equals("")) throw new Exception("Mật khẩu không được để trống!");
                    String sql = "Select * From TaiKhoan";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bool check = false;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (taikhoan == dt.Rows[i].ItemArray[0].ToString() && matkhau == dt.Rows[i].ItemArray[4].ToString())
                        {
                            tenDN = taikhoan;
                            FormTrangChu trangChu = new FormTrangChu();
                            trangChu.Tag = tenDN;
                            this.Hide();
                            trangChu.ShowDialog();
                            check = true;
                            break;
                        }
                        
                    }
                    if (check == false)
                        throw new Exception("Sai tài khoản hoặc mật khẩu!!!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dangNhap();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDangKy dangKy = new FormDangKy();
            this.Hide();
            dangKy.ShowDialog();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
