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
        private int index = 3;
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
                string query_check = $"select * from tblDangNhap where sTaiKhoan='{tb_taikhoan.Text}'and sTrangThai=N'Khóa'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlCommand cmd_check=new SqlCommand(query_check, con);

                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                SqlDataAdapter adt_check = new SqlDataAdapter(cmd_check);

                DataTable dt_check = new DataTable();
                DataTable dt = new DataTable();
                adt_check.Fill(dt_check);
                adt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (String.Compare(dt.Rows[0]["sTrangThai"].ToString(), "Khóa") == 0)
                    {
                        lb_noti.Text = "* Tài khoản đã bị khóa";
                    }
                    else
                    {
                        MainForm form = new MainForm();
                        form.ShowDialog();
                        this.Close();
                        index = 3;
                    }
                }
                else
                {
                    if(dt_check.Rows.Count > 0)
                    {
                        lb_noti.Text = "* Tài khoản đã bị khóa";
                    }
                    else
                    {
                        index -= 1;
                        lb_noti.Text = "* Tài khoản hoặc mật khẩu không đúng";
                        lb_count.Text = $"Số lần thử: {index}";
                        if (index == 0)
                        {
                            string query_upt = $"update tblDangNhap set sTrangThai=N'Khóa' where sTaiKhoan = '{tb_taikhoan.Text}'";
                            SqlCommand cmd_upt = new SqlCommand(query_upt, con);
                            cmd_upt.ExecuteNonQuery();
                            MessageBox.Show("Tài khoản đã bị khóa");
                        }
                    }
                }
                con.Close();
            }
        }
    }
}
