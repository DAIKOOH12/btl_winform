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
    public partial class FormSuaThongTinNganh : Form
    {
        private string maNganh;
        private string tenNganh;
        private string maKhoa;
        private DataTable dsKhoa;
        private SqlConnection con=new SqlConnection();
        public FormSuaThongTinNganh(string maKhoa,string maNganh,string tenNganh,DataTable dsKhoa)
        {
            InitializeComponent();
            this.maNganh = maNganh;
            this.tenNganh= tenNganh;
            this.maKhoa = maKhoa;
            this.dsKhoa= dsKhoa;
        }

        private void FormSuaThongTinNganh_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            tb_manganh.Text= maNganh;
            tb_tennganh.Text= tenNganh;
            cb_makhoa.DataSource= dsKhoa;
            cb_makhoa.DisplayMember = "sMaKhoa";
            cb_makhoa.Text = maKhoa;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát??", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Dispose();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query_upt = $"Update tblNganh set sTenNganh=N'{tb_tennganh.Text}',sMaKhoa='{cb_makhoa.Text}' where sManganh='{tb_manganh.Text}'";
                SqlCommand cmd=new SqlCommand(query_upt, con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            this.Dispose();

        }
    }
}
