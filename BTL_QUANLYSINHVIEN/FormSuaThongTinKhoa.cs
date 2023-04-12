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
    public partial class FormSuaThongTinKhoa : Form
    {
        private SqlConnection con=new SqlConnection();
        private string ma_khoa;
        private string ten_khoa;
        private string dia_chi;
        public FormSuaThongTinKhoa(string ma_khoa, string ten_khoa, string dia_chi)
        {
            InitializeComponent();
            this.ma_khoa=ma_khoa;
            this.ten_khoa= ten_khoa;
            this.dia_chi=dia_chi;
        }

        private void FormSuaThongTinKhoa_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            tb_makhoa.Text = ma_khoa;
            tb_tenkhoa.Text = ten_khoa;
            tb_diachi.Text = dia_chi;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"update tblKhoa set sTenKhoa=N'{tb_tenkhoa.Text}',sDiaChi=N'{tb_diachi.Text}' where sMaKhoa='{tb_makhoa.Text}'";
                SqlCommand cmd=new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            this.Dispose();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát???", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
