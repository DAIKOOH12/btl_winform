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
    public partial class FormQlyCanBo : Form
    {
        private SqlConnection con=new SqlConnection();
        private DataTable dsCB=new DataTable();
        private DataTable dsNganh=new DataTable();
        private DataTable check_cb=new DataTable();

        private void loadData()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            con.Open();
            string query_selNganh = "Select * from tblNganh";
            SqlCommand cmd_nganh = new SqlCommand(query_selNganh, con);
            SqlDataAdapter adt_nganh = new SqlDataAdapter();
            adt_nganh.SelectCommand= cmd_nganh;
            dsNganh.Clear();
            adt_nganh.Fill(dsNganh);
            if (dsNganh.Rows.Count < 0)
            {
                MessageBox.Show("Không lấy được thông tin ngành");
            }
            else
            {
                cb_nganh.DataSource=dsNganh;
                cb_nganh.DisplayMember = "sMaNganh";
                try
                {
                    string query_selCB = "Select * from tblCanBo";
                    SqlCommand cmd_cb=new SqlCommand(query_selCB, con);
                    SqlDataAdapter adt_cb = new SqlDataAdapter();
                    adt_cb.SelectCommand= cmd_cb;
                    dsCB.Clear();
                    adt_cb.Fill(dsCB);
                    if(dsCB.Rows.Count < 0)
                    {
                        MessageBox.Show("Không lấy được thông tin cán bộ");
                    }
                    else
                    {
                        dgv_canbo.DataSource=dsCB;
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }
            }
        }
        private void resetData()
        {
            tb_macb.Clear();
            tb_tencb.Clear();
            tb_sdt.Clear();
            loadData();
        }
        public FormQlyCanBo()
        {
            InitializeComponent();
        }

        private void FormQlyCanBo_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgv_canbo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider1.SetError(tb_macb, null);
            int index = dgv_canbo.CurrentRow.Index;
            tb_macb.Text = dsCB.Rows[index][0].ToString();
            tb_tencb.Text = dsCB.Rows[index][1].ToString();
            tb_sdt.Text = dsCB.Rows[index][2].ToString();
            cb_nganh.Text = dsCB.Rows[index][3].ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_macb.Text))
            {
                errorProvider1.SetError(tb_macb, "Mã cán bộ không được để trống");
            }
            else
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query_check = $"select * from tblCanBo where sMaCB='{tb_macb.Text}'";
                SqlCommand cmd_check=new SqlCommand(query_check, con);
                SqlDataAdapter adt_check = new SqlDataAdapter();
                adt_check.SelectCommand=cmd_check;
                check_cb.Clear();
                adt_check.Fill(check_cb);
                if(check_cb.Rows.Count> 0 )
                {
                    errorProvider1.SetError(tb_macb, "Mã cán bộ đã tồn tại");
                }
                else
                {
                    try
                    {
                        string query_ins = $"insert into tblCanBo values('{tb_macb.Text}',N'{tb_tencb.Text}','{tb_sdt.Text}','{cb_nganh.Text}')";
                        SqlCommand cmd_ins=new SqlCommand(query_ins, con);
                        cmd_ins.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { con.Close(); }
                }
            }
            loadData();
            resetData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_macb.Text))
            {
                MessageBox.Show("Cần chọn 1 cán bộ để xóa");
            }
            else
            {
                try
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    con.Open();
                    string query_del = $"delete from tblCanBo where sMaCB='{tb_macb.Text}'";
                    SqlCommand cmd = new SqlCommand(query_del, con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cán bộ này đang quản lí hồ sơ của học sinh");
                }
                finally { con.Close(); }
            }
            loadData();
            resetData();
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_macb.Text))
            {
                MessageBox.Show("Cần chọn 1 thông tin để sửa");
            }
            else
            {
                FormSuaThongTinCB formCB = new FormSuaThongTinCB(tb_macb.Text, tb_tencb.Text, tb_sdt.Text, cb_nganh.Text, dsNganh);
                formCB.ShowDialog();
            }
            loadData();
            resetData();
        }

        private void btn_tiep_Click(object sender, EventArgs e)
        {
            loadData();
            resetData();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string filterMaCB = tb_macb.Text;
            string filterTenCB=tb_tencb.Text;
            string filterSDT=tb_sdt.Text;
            string filterNganh = cb_nganh.Text;

            DataView dtv = new DataView(dsCB);

            if (!String.IsNullOrEmpty(tb_macb.Text))
            {
                dtv.RowFilter = String.Format($"sMaCB like '%{filterMaCB}%'");
            }
            if (!String.IsNullOrEmpty(tb_tencb.Text))
            {
                dtv.RowFilter = String.Format($"sTenCB like '%{filterTenCB}%'");
            }
            if (!String.IsNullOrEmpty(tb_sdt.Text))
            {
                dtv.RowFilter = String.Format($"sSDT like '%{filterSDT}%'");
            }
            dtv.RowFilter = String.Format($"sMaNganh like '%{filterNganh}%'");

            dgv_canbo.DataSource= dtv;
        }
    }
}
