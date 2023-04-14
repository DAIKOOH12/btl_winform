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
    public partial class FormQLyNganh : Form
    {
        private SqlConnection con=new SqlConnection();
        private DataTable dsNganh=new DataTable();
        private DataTable dsKhoa=new DataTable();
        private DataTable dsCheck=new DataTable();
        public FormQLyNganh()
        {
            InitializeComponent();
            loadData();
        }

        private void FormQLyNganh_Load(object sender, EventArgs e)
        {
            tb_manganh.Focus();
            dgv_nganh.ReadOnly= true;
        }
       
        private  void loadData()
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query_nganh = "Select * from tblNganh";
                string query_khoa = "Select * from tblKhoa";

                SqlCommand cmd_nganh=new SqlCommand(query_nganh, con);
                SqlDataAdapter adt_nganh = new SqlDataAdapter();

                adt_nganh.SelectCommand= cmd_nganh;
                dsNganh.Clear();
                adt_nganh.Fill(dsNganh);
                if(dsNganh.Rows.Count > 0)
                {
                    dgv_nganh.DataSource = dsNganh;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }

                SqlCommand cmd_khoa=new SqlCommand(query_khoa, con);
                SqlDataAdapter adt_khoa= new SqlDataAdapter();
                adt_khoa.SelectCommand= cmd_khoa;

                dsKhoa.Clear();
                adt_khoa.Fill(dsKhoa);

                cb_khoa.DataSource= dsKhoa;
                cb_khoa.DisplayMember= "sMaKhoa";

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
        private void resetData()
        {
            tb_manganh.Clear();
            tb_tennganh.Clear();

        }
        private void tb_manganh_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_manganh.Text))
            {
                errorProvider1.SetError(tb_manganh,"Mã ngành không được để trống");
            }
            else
            {
                errorProvider1.SetError(tb_manganh,null);
                tb_tennganh.Focus();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query_check = $"Select * from tblNganh where sMaNganh='{tb_manganh.Text}'";
                SqlCommand cmd = new SqlCommand(query_check, con);
                SqlDataAdapter adt=new SqlDataAdapter();
                adt.SelectCommand= cmd;
                dsCheck.Clear();
                adt.Fill(dsCheck);
                if (dsCheck.Rows.Count >= 1)
                {
                    errorProvider1.SetError(tb_manganh, "Mã ngành này đã tồn tại");
                }
                else
                {
                    string query_ins = $"insert into tblNganh values('{tb_manganh.Text}',N'{tb_tennganh.Text}','{cb_khoa.Text}')";
                    SqlCommand cmd_ins = new SqlCommand(query_ins, con);
                    cmd_ins.ExecuteNonQuery();
                    con.Close();
                    loadData();
                    resetData();
                    int index = dsNganh.Rows.Count - 1;
                    dgv_nganh.CurrentCell = dgv_nganh.Rows[index].Cells[0];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_manganh.Text))
            {
                MessageBox.Show("Bạn cần chọn 1 ngành để xóa");
            }
            else
            {
                try
                {
                    if(MessageBox.Show("Bạn có chắc muốn xóa ngành này??","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                        con.Open();
                        string query_del = $"delete from tblNganh where sMaNganh='{tb_manganh.Text}'";
                        SqlCommand cmd = new SqlCommand(query_del, con);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Mã ngành đang được đăng kí bởi các lớp khác","Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { con.Close(); }
            }
            loadData();
            resetData();
        }

        private void dgv_nganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index=dgv_nganh.CurrentRow.Index;
            tb_manganh.Text = dsNganh.Rows[index][0].ToString();
            tb_tennganh.Text = dsNganh.Rows[index][1].ToString();
            cb_khoa.Text = dsNganh.Rows[index][2].ToString();
        }

        private void tb_manganh_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_manganh.Text))
            {
                errorProvider1.SetError(tb_manganh, null);
            }
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_manganh.Text))
            {
                MessageBox.Show("Bạn cần chọn 1 ngành để sửa");
            }
            else
            {
                FormSuaThongTinNganh formNganh = new FormSuaThongTinNganh(cb_khoa.Text, tb_manganh.Text, tb_tennganh.Text,  dsKhoa);
                formNganh.ShowDialog();
                loadData();
                resetData();
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_manganh.Text) && String.IsNullOrEmpty(tb_tennganh.Text))
            {
                MessageBox.Show("Cần nhập ít nhất 1 thông tin để tìm kiếm", "Thông báo");
            }
            else
            {
                string filterMaNganh = tb_manganh.Text;
                string filterTenNganh = tb_tennganh.Text;
                string filterMaKhoa = cb_khoa.Text;
                DataView dtv = new DataView(dsNganh);

                if (String.IsNullOrEmpty(filterMaNganh) && String.IsNullOrEmpty(filterTenNganh))
                {
                    dtv.RowFilter = string.Format($"sMaKhoa like '%{filterMaKhoa}%'");
                }
                if (String.IsNullOrEmpty(filterMaNganh) && String.IsNullOrEmpty(filterMaKhoa))
                {
                    dtv.RowFilter = string.Format($" sTenNganh like '%{filterTenNganh}%'");
                }
                if (String.IsNullOrEmpty(filterTenNganh) && String.IsNullOrEmpty(filterMaKhoa))
                {
                    dtv.RowFilter = string.Format($"sMaNganh like '%{filterMaNganh}%'");
                }
                if (String.IsNullOrEmpty(filterMaNganh))
                {
                    dtv.RowFilter = string.Format($" sTenNganh like '%{filterTenNganh}%' and sMaKhoa like '%{filterMaKhoa}%'");
                }
                if (String.IsNullOrEmpty(filterMaKhoa))
                {
                    dtv.RowFilter = string.Format($"sMaNganh like '%{filterMaNganh}%' and sTenNganh like '%{filterTenNganh}%'");
                }
                if (String.IsNullOrEmpty(filterTenNganh))
                {
                    dtv.RowFilter = string.Format($"sMaNganh like '%{filterMaNganh}%' and sMaKhoa like '%{filterMaKhoa}%'");
                }
                dgv_nganh.DataSource = dtv;
            }
        }
    }
}
