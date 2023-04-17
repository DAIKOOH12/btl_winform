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
    public partial class FormSuaThongTinHD : Form
    {
        private SqlConnection con = new SqlConnection();
        private string mahoadon;
        private string tongtien;
        private string sobaodanh;
        private DataTable dsSV=new DataTable();
        public FormSuaThongTinHD(string mahoadon, string tongtien, string malop, DataTable dsSV)
        {
            InitializeComponent();
            this.mahoadon = mahoadon;
            this.tongtien = tongtien;
            this.sobaodanh = malop;
            this.dsSV = dsSV;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormSuaThongTinHD_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            tb_mahoadon.Text= mahoadon;
            tb_tien.Text= tongtien;
            cb_sbd.DataSource= dsSV;
            cb_sbd.DisplayMember = "sSoBD";
            cb_sbd.Text = sobaodanh;
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query_udt = $"update tblHoaDonHocPhi set fTongTien='{Convert.ToDouble(tb_tien.Text)}',sSoBD='{cb_sbd.Text}' where sMaHD='{tb_mahoadon.Text}'";
                SqlCommand cmd=new SqlCommand(query_udt, con);
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
