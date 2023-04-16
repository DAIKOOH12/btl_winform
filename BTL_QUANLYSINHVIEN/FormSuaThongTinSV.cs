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
    public partial class FormSuaThongTinSV : Form
    {
        private SqlConnection con=new SqlConnection();
        private string sobd;
        private string hoten;
        private string ngaysinh;
        private string cmnd;
        private string gioitinh;
        private string tongiao;
        private string email;
        private string truongtotnghiep;
        private string quequan;
        private string malop;
        private DataTable dsLop=new DataTable();
        public FormSuaThongTinSV(string sobd, string hoten, string ngaysinh, string cmnd, string gioitinh, string tongiao, string email, string truongtotnghiep, string quequan, string malop,DataTable dsLop)
        {
            InitializeComponent();
            this.sobd = sobd;
            this.hoten = hoten;
            this.ngaysinh= ngaysinh;
            this.cmnd = cmnd;
            this.gioitinh= gioitinh;
            this.tongiao = tongiao;
            this.email = email;
            this.truongtotnghiep= truongtotnghiep;
            this.quequan=quequan;
            this.malop=malop;
            this.dsLop=dsLop;
        }

        private void FormSuaThongTinSV_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            tb_sbd.Text = this.sobd;
            tb_hoten.Text = this.hoten;
            dtp_ngaysinh.Text=this.ngaysinh;
            tb_cmnd.Text= this.cmnd;
            if(String.Compare(gioitinh,"False")==0 )
            {
                rd_nam.Checked= true;
            }
            if(String.Compare(gioitinh,"True")==0 )
            {
                rd_nu.Checked= true;
            }
            tb_tongiao.Text = this.tongiao;
            tb_email.Text = this.email;
            tb_truong.Text = this.truongtotnghiep;
            tb_quequan.Text = this.quequan;
            cb_lop.DataSource = dsLop;
            cb_lop.DisplayMember = "sMaLop";
            cb_lop.Text = this.malop;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát","Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            con.Open();
            string gender = "";
            if(rd_nam.Checked )
            {
                gender = "Nam";
            }
            if(rd_nu.Checked)
            {
                gender = "Nữ";
            }
            string query_udt = $"update tblSinhVien set sHoTen=N'{tb_hoten.Text}',dNgaySinh='{dtp_ngaysinh.Text}',sCMND='{tb_cmnd.Text}',sTonGiao='{tb_tongiao.Text}',sEmail='{tb_email.Text}',sTruongTotNghiep=N'{tb_truong.Text}',sQueQuan=N'{tb_quequan.Text}',sGioiTinh=N'{gender}',sMaLop='{cb_lop.Text}'where sSoBD='{tb_sbd.Text}'";
            SqlCommand cmd=new SqlCommand(query_udt,con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Dispose();
        }
    }
}
