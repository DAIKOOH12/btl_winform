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
    public partial class FormCRNganh : Form
    {
        private int index;
        private string info;
        private SqlConnection con = new SqlConnection();
        public FormCRNganh(int index, string info)
        {
            InitializeComponent();
            this.index = index;
            this.info = info;
        }

        private void FormCRNganh_Load(object sender, EventArgs e)
        {
            if (index == 1)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"select * from tblNganh";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adt.Fill(ds);
                CrystalReportNganh crp = new CrystalReportNganh();
                crp.SetDataSource(ds.Tables[0]);
                crp_nganh.ReportSource = crp;
            }
            if(index == 2)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"Select * from tblNganh where sTenNganh like N'%{info}%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adt.Fill(ds);
                CrystalReportNganh crp = new CrystalReportNganh();
                crp.SetDataSource(ds.Tables[0]);
                crp_nganh.ReportSource = crp;
            }
            if(index == 3)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = $"Select * from tblNganh where sMaKhoa like '%{info}%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adt.Fill(ds);
                CrystalReportNganh crp = new CrystalReportNganh();
                crp.SetDataSource(ds.Tables[0]);
                crp_nganh.ReportSource = crp;
            }
            if (index == 4)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = "select sMaKhoa, count(sMaNganh) as tong_so from tblNganh group by sMaKhoa";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adt.Fill(ds);
                CrystalReportNganh crp = new CrystalReportNganh();
                crp.SetDataSource(ds.Tables[0]);
                crp_nganh.ReportSource = crp;
            }
        }
    }
}
