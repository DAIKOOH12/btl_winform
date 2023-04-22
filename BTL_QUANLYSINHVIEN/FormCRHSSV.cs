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
    public partial class FormCRHSSV : Form
    {
        private SqlConnection con=new SqlConnection();
        private int index;
        private string info;
        public FormCRHSSV(int index, string info)
        {
            InitializeComponent();
            this.index = index;
            this.info = info;
        }

        private void FormCRHSSV_Load(object sender, EventArgs e)
        {
            if(index == 1)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = "select * from tblHoSoSinhVien";
                SqlCommand cmd=new SqlCommand(query,con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand= cmd;
                DataTable dt=new DataTable();
                adt.Fill(dt);
                CrystalReportHSSV crp=new CrystalReportHSSV();
                crp.SetDataSource(dt);
                crp_hssv.ReportSource = crp;
            }
        }
    }
}
