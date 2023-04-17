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
    public partial class FormSuaThongTinDiem : Form
    {
        private SqlConnection con=new SqlConnection();
        private string sobaodanh;
        private string nganh;
        private string tohop;
        private string diem1;
        private string diem2;
        private string diem3;
        private string diemuutien;
        private DataTable dsSV=new DataTable();
        private DataTable dsNganh=new DataTable();
        private void loadData()
        {
            cb_sbd.DataSource = dsSV;
            cb_sbd.DisplayMember = "sSoBD";
            cb_nganh.DataSource = dsNganh;
            cb_nganh.DisplayMember = "sMaNganh";
            cb_sbd.Text = this.sobaodanh;
            cb_nganh.Text = this.nganh;
            tb_khoitohop.Text = this.tohop;
            tb_diem1.Text= this.diem1;
            tb_diem2.Text= this.diem2;
            tb_diem3.Text= this.diem3;
            tb_diemuutien.Text = this.diemuutien;
        }
        public FormSuaThongTinDiem(string sobaodanh, string nganh, string tohop, string diem1, string diem2, string diem3, string diemuutien, DataTable dsSV, DataTable dsNganh)
        {
            InitializeComponent();
            this.sobaodanh = sobaodanh;
            this.nganh = nganh;
            this.tohop = tohop;
            this.diem1 = diem1;
            this.diem2 = diem2;
            this.diem3 = diem3;
            this.diemuutien = diemuutien;
            this.dsSV = dsSV;
            this.dsNganh = dsNganh;
        }

        private void FormSuaThongTinDiem_Load(object sender, EventArgs e)
        {
            loadData();
            this.ControlBox = false;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query_udt = $"update tblDiemChuan set sKhoiToHop='{tb_khoitohop.Text}',fDiem1='{Convert.ToDouble(tb_diem1.Text)}',fDiem2='{Convert.ToDouble(tb_diem2.Text)}',fDiem3='{Convert.ToDouble(tb_diem3.Text)}',fDiemUuTien='{Convert.ToDouble(tb_diemuutien.Text)}' where sSoBD='{cb_sbd.Text}' and sMaNganh='{cb_nganh.Text}'";
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
