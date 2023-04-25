using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QUANLYSINHVIEN
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            tb_taikhoan.Focus();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (String.IsNullOrEmpty(tb_taikhoan.Text))
            {
                errorProvider.SetError(tb_taikhoan, "tài khoản không được để trống");
            }
            else
            {
                errorProvider.SetError(tb_taikhoan, null);
            }
            if (String.IsNullOrEmpty(tb_matkhau.Text))
            {
                errorProvider.SetError(tb_matkhau, "mật khẩu không được để trống");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"select * from tblDangNhap where sTaiKhoan='{tb_taikhoan.Text}' and sMatKhau='{tb_matkhau.Text}'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MainForm form = new MainForm();
                    form.ShowDialog();
                }
                else
                {
                    lb_noti.Text = "* Tài khoản hoặc mật khẩu không đúng";
                }
            }
        }
    }
}
