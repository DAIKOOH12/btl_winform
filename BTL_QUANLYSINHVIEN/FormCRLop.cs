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
    public partial class FormCRLop : Form
    {
        private SqlConnection con=new SqlConnection();
        private int index;
        private string info;
        public FormCRLop(int index, string info)
        {
            InitializeComponent();
            this.index = index;
            this.info = info;
        }

        private void FormCRLop_Load(object sender, EventArgs e)
        {
            if (index == 1)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = "select * from tblLop";
                SqlCommand cmd=new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adt.SelectCommand= cmd;
                adt.Fill(dt);
                CrystalReportLop crp = new CrystalReportLop();
                crp.SetDataSource(dt);
                crp_lop.ReportSource = crp;
            }
            if (index == 2)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_TTSVTheoLop", con)
                {
                    CommandType=CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@malop", SqlDbType.VarChar).Value = info;
                SqlDataAdapter adt = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adt.SelectCommand = cmd;
                adt.Fill(dt);
                CrystalReportTTSVTheoLop crp=new CrystalReportTTSVTheoLop();
                crp.SetDataSource(dt);
                crp_lop.ReportSource = crp;
            }
        }
    }
}
