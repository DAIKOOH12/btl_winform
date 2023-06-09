﻿using System;
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
    public partial class FormCRKhoa : Form
    {
        private int index;
        private string info;
        private SqlConnection con=new SqlConnection();
        public FormCRKhoa(int index, string info)
        {
            InitializeComponent();
            this.index = index;
            this.info = info;
        }

        private void FormCRKhoa_Load(object sender, EventArgs e)
        {
            if (index == 1)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"select * from tblKhoa";
                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                ds.Clear();
                adt.Fill(ds);
                CrystalReportKhoa crp = new CrystalReportKhoa();
                crp.SetDataSource(ds.Tables[0]);
                crp_TkeKhoa.ReportSource = crp;
            }
            if (index == 2)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"select * from tblKhoa where sTenKhoa like N'%{info}%'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                ds.Clear();
                adt.Fill(ds);
                CrystalReportKhoa crp = new CrystalReportKhoa();
                crp.SetDataSource(ds.Tables[0]);
                crp_TkeKhoa.ReportSource = crp;
            }
            if (index == 3)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"select * from tblKhoa where sDiaChi like N'%{info}%'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                ds.Clear();
                adt.Fill(ds);
                CrystalReportKhoa crp = new CrystalReportKhoa();
                crp.SetDataSource(ds.Tables[0]);
                crp_TkeKhoa.ReportSource = crp;
            }
            if (index == 4)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"sp_tongnganh";
                SqlCommand cmd = new SqlCommand(query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                DataSet ds = new DataSet();
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                ds.Clear();
                adt.Fill(ds);
                CrystalReportTongNganh crp = new CrystalReportTongNganh();
                crp.SetDataSource(ds.Tables[0]);
                crp_TkeKhoa.ReportSource = crp;
            }
            if (index == 5)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"sp_TTNganhTheoKhoa";
                SqlCommand cmd = new SqlCommand(query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@makhoa", SqlDbType.VarChar).Value = info;
                SqlDataAdapter adt = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adt.SelectCommand = cmd;
                adt.Fill(dt);
                CrystalReportTTNganhTheoKHoa crp = new CrystalReportTTNganhTheoKHoa();
                crp.SetDataSource(dt);
                crp_TkeKhoa.ReportSource = crp;
            }
        }
    }
}
