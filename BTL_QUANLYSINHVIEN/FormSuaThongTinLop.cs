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
    public partial class FormSuaThongTinLop : Form
    {
        private string maLop;
        private string tenLop;
        private string maNganh;
        private DataTable dsNganh = new DataTable();
        private SqlConnection con = new SqlConnection();
        public FormSuaThongTinLop(string maLop,string tenLop, string maNganh, DataTable dsNganh)
        {
            InitializeComponent();
            this.maLop= maLop;
            this.tenLop= tenLop;
            this.maNganh= maNganh;
            this.dsNganh = dsNganh;
        }

        private void cb_manganh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormSuaThongTinLop_Load(object sender, EventArgs e)
        {
            cb_manganh.DataSource = dsNganh;
            cb_manganh.DisplayMember = "sMaNganh";
            this.ControlBox = false;
            tb_malop.Text = maLop;
            tb_tenlop.Text = tenLop;
            cb_manganh.Text = maNganh; 
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query_udt = $"update tblLop set sTenLop=N'{tb_tenlop.Text}',sMaNganh='{cb_manganh.Text}' where sMaLop='{tb_malop.Text}'";
                SqlCommand cmd = new SqlCommand(query_udt, con);
                cmd.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            this.Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát???","Cảnh bảo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
