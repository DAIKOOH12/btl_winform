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
    public partial class FormSuaThongTinCB : Form
    {
        private SqlConnection con=new SqlConnection();
        private string macanbo;
        private string tencanbo;
        private string sdt;
        private string manganh;
        private DataTable dsNganh=new DataTable();
        
        private void loadData()
        {
            tb_macb.Text= macanbo;
            tb_tencb.Text= tencanbo;
            tb_sdt.Text= sdt;
            cb_nganh.DataSource= dsNganh;
            cb_nganh.DisplayMember = "sMaNganh";
            cb_nganh.Text = manganh;
        }
        public FormSuaThongTinCB(string macanbo, string tencanbo, string sdt, string manganh, DataTable dsNganh)
        {
            InitializeComponent();
            this.macanbo = macanbo;
            this.tencanbo = tencanbo;
            this.sdt = sdt;
            this.manganh = manganh;
            this.dsNganh = dsNganh;
        }

        private void FormSuaThongTinCB_Load(object sender, EventArgs e)
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
                string query_udt = $"update tblCanBo set sTenCB=N'{tb_tencb.Text}',sSDT='{tb_sdt.Text}',sMaNganh='{cb_nganh.Text}' where sMaCB='{tb_macb.Text}'";
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
