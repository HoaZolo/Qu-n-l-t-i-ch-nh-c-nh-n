using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLWin
{
    public partial class FormHome : Form
    {
        String connString = @"Data Source=DESKTOP-LM1JJVT\SQLEXPRESS;Initial Catalog=QLTCCN;Integrated Security=True";
        double thuNhap = 0, chiTieu = 0;
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            
            using (SqlConnection conn = new SqlConnection(connString))
            {
                String sql = "Select SotienTN From Accounts";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    thuNhap +=  double.Parse(dt.Rows[i].ItemArray[0].ToString());
                }
                labThuNhap.Text = thuNhap.ToString("#,###", cul.NumberFormat) + " VND";
                String sql1 = "Select SotienCT From Expenses";
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    chiTieu += double.Parse(dt1.Rows[i].ItemArray[0].ToString());
                }
                labChiTieu.Text = chiTieu.ToString("#,###", cul.NumberFormat) + " VND";

                labTong.Text = (thuNhap - chiTieu).ToString("#,###", cul.NumberFormat) + " VND";
            }    

        }
    }
}
