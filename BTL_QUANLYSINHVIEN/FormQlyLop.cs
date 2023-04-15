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
    public partial class FormQlyLop : Form
    {
        private SqlConnection con=new SqlConnection();
        private DataTable dsLop=new DataTable();
        private DataTable dsNganh=new DataTable();
        public FormQlyLop()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query = "Select * from tblLop";
                SqlCommand cmd_lop=new SqlCommand(query, con);
                SqlDataAdapter adt_lop = new SqlDataAdapter();
                adt_lop.SelectCommand= cmd_lop;
                dsLop.Clear();
                adt_lop.Fill(dsLop);
                if (dsLop.Rows.Count > 0)
                {
                    dgv_lop.DataSource = dsLop;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }
                string query_sel = "Select * from tblNganh";
                SqlCommand cmd_nganh = new SqlCommand(query_sel, con);
                SqlDataAdapter adt_nganh = new SqlDataAdapter();
                adt_nganh.SelectCommand = cmd_nganh;
                dsNganh.Clear();
                adt_nganh.Fill(dsNganh);
                if (dsNganh.Rows.Count > 0)
                {
                    cb_nganh.DataSource = dsNganh;
                    cb_nganh.DisplayMember = "sMaNganh";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
        private void resetData()
        {
            tb_malop.Clear();
            tb_tenlop.Clear();

        }
        private void FormQlyLop_Load(object sender, EventArgs e)
        {
            loadData();
            dgv_lop.ReadOnly = true;
        }

        private void tb_malop_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_malop.Text))
            {
                errorProvider1.SetError(tb_malop, "Mã lớp không được để trống");
            }
            else
            {
                errorProvider1.SetError(tb_malop, null);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(!String.IsNullOrEmpty(tb_malop.Text))
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    con.Open();
                    string query_check = $"Select * from tblLop where sMaLop='{tb_malop.Text}'";
                    SqlCommand cmd = new SqlCommand(query_check, con);
                    SqlDataAdapter adt = new SqlDataAdapter();
                    adt.SelectCommand = cmd;
                    DataTable checkLop = new DataTable();
                    adt.Fill(checkLop);
                    if (checkLop.Rows.Count >= 1)
                    {
                        errorProvider1.SetError(tb_malop, "Mã lớp đã tồn tại");
                    }
                    else
                    {
                        string query_ins = $"insert into tblLop values('{tb_malop.Text}',N'{tb_tenlop.Text}','{cb_nganh.Text}')";
                        SqlCommand cmd_ins = new SqlCommand(query_ins, con);
                        cmd_ins.ExecuteNonQuery();
                    }
                }
                else
                {
                    errorProvider1.SetError(tb_malop, "Mã lớp không được để trống");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            loadData();
            resetData();
            //int index = dgv_lop.CurrentRow.Index;
            //dgv_lop.Rows[index].Selected = true;
            //dgv_lop.CurrentCell = dgv_lop.Rows[index-1].Cells[1];
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa lớp này???", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    con.Open();
                    string query_del = $"delete from tblLop where sMaLop='{tb_malop.Text}'";
                    SqlCommand cmd_del=new SqlCommand(query_del,con);
                    cmd_del.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lớp này đã được đăng kí dạy học");
                }
                finally { con.Close(); } 
                loadData();
                resetData();
            }
        }

        private void dgv_lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_lop.CurrentRow.Index;
            tb_malop.Text = dsLop.Rows[index][0].ToString();
            tb_tenlop.Text = dsLop.Rows[index][1].ToString();
            cb_nganh.Text = dsLop.Rows[index][2].ToString();
        }

        private void tb_malop_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(tb_malop, null);
            if (String.IsNullOrEmpty(tb_malop.Text)){
                loadData();
            }
        }

        private void btn_udt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_malop.Text))
            {
                MessageBox.Show("Bạn cần chọn 1 lớp để cập nhật");
            }
            else
            {
                FormSuaThongTinLop formSuaLop = new FormSuaThongTinLop(tb_malop.Text, tb_tenlop.Text, cb_nganh.Text, dsNganh);
                formSuaLop.ShowDialog();
                loadData();
                resetData();
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            {
                errorProvider1.SetError(tb_malop, null);
                string filterMaLop = tb_malop.Text;
                string filterTenLop = tb_tenlop.Text;
                string FilterMaNganh = cb_nganh.Text;
                DataView dtv = new DataView(dsLop);

                if (String.IsNullOrEmpty(filterMaLop) && String.IsNullOrEmpty(filterTenLop))
                {
                    dtv.RowFilter = string.Format($"sMaNganh like '%{FilterMaNganh}%'");
                }
                if (String.IsNullOrEmpty(filterMaLop) && String.IsNullOrEmpty(FilterMaNganh))
                {
                    dtv.RowFilter = string.Format($" sTenLop like '%{filterTenLop}%'");
                }
                if (String.IsNullOrEmpty(filterTenLop) && String.IsNullOrEmpty(FilterMaNganh))
                {
                    dtv.RowFilter = string.Format($"sMaLop like '%{filterMaLop}%'");
                }
                if (String.IsNullOrEmpty(filterMaLop))
                {
                    dtv.RowFilter = string.Format($" sTenLop like '%{filterTenLop}%' and sMaNganh like '%{FilterMaNganh}%'");
                }
                if (String.IsNullOrEmpty(FilterMaNganh))
                {
                    dtv.RowFilter = string.Format($"sMaLop like '%{filterMaLop}%' and sTenLop like '%{filterTenLop}%'");
                }
                if (String.IsNullOrEmpty(filterTenLop))
                {
                    dtv.RowFilter = string.Format($"sMaLop like '%{filterMaLop}%' and sMaNganh like '%{FilterMaNganh}%'");
                }
                if (!String.IsNullOrEmpty(filterMaLop)&&!String.IsNullOrEmpty(filterTenLop))
                {
                    dtv.RowFilter = string.Format($"sMaLop like '%{filterMaLop}%' and sTenLop like '%{filterTenLop}%'");
                }
                dgv_lop.DataSource = dtv;
            }
        }
    }
}
