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
using System.Web.WebSockets;
using System.Windows.Forms;

namespace BTL_QUANLYSINHVIEN
{
    public partial class FormCRHocSinh : Form
    {
        private int index;
        private string info;
        private SqlConnection con = new SqlConnection();
        public FormCRHocSinh(int index, string info)
        {
            InitializeComponent();
            this.index = index;
            this.info = info;
        }

        private void FormCRHocSinh_Load(object sender, EventArgs e)
        {
            if (index == 1)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = "Select * from tblSinhVien";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                DataTable dt=new DataTable();
                adt.Fill(dt);
                CrystalReportHocSinh crp = new CrystalReportHocSinh();
                crp.SetDataSource(dt);
                crp_hocsinh.ReportSource = crp;
                con.Close();
            }
            if (index == 2)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"Select * from tblSinhVien where sHoTen like N'%{info}%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adt.Fill(dt);
                CrystalReportHocSinh crp = new CrystalReportHocSinh();
                crp.SetDataSource(dt);
                crp_hocsinh.ReportSource = crp;
                con.Close();
            }
            if (index == 3)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"Select * from tblSinhVien where sTruongTotNghiep like N'%{info}%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adt.Fill(dt);
                CrystalReportHocSinh crp = new CrystalReportHocSinh();
                crp.SetDataSource(dt);
                crp_hocsinh.ReportSource = crp;
                con.Close();
            }
            if (index == 4)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"Select * from tblSinhVien where sQueQuan like N'%{info}%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adt.Fill(dt);
                CrystalReportHocSinh crp = new CrystalReportHocSinh();
                crp.SetDataSource(dt);
                crp_hocsinh.ReportSource = crp;
                con.Close();
            }
            if (index == 5)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"Select * from tblSinhVien where sGioiTinh like N'%{info}%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adt.Fill(dt);
                CrystalReportHocSinh crp = new CrystalReportHocSinh();
                crp.SetDataSource(dt);
                crp_hocsinh.ReportSource = crp;
                con.Close();
            }
            if (index == 6)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"Select * from tblSinhVien where sMaLop ='{info}'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adt.Fill(dt);
                CrystalReportHocSinh crp = new CrystalReportHocSinh();
                crp.SetDataSource(dt);
                crp_hocsinh.ReportSource = crp;
                con.Close();
            }
            if (index == 7)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_HoSoTheoHocSinh", con)
                {
                    CommandType=CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@masv", SqlDbType.VarChar).Value = info;
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adt.Fill(dt);
                CrystalReportHSTheoSV crp = new CrystalReportHSTheoSV();
                crp.SetDataSource(dt);
                crp_hocsinh.ReportSource = crp;
                con.Close();
            }
        }
    }
}
