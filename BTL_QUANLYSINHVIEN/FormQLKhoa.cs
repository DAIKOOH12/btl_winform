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
    public partial class FormQLKhoa : Form
    {
        private SqlConnection con=new SqlConnection();
        private DataTable dsKhoa=new DataTable();
        private DataTable dt_check=new DataTable();
        public FormQLKhoa()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString; 
            con.Open();
            try
            {
                string query_select = "Select * from tblKhoa";
                SqlCommand cmd=new SqlCommand(query_select,con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand= cmd;
                dsKhoa.Clear();
                adt.Fill(dsKhoa);
                if(dsKhoa.Rows.Count > 0)
                {
                    dgv_khoa.DataSource= dsKhoa;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }

        }
        private void reLoad()
        {
            tb_makhoa.Clear();
            tb_tenkhoa.Clear();
            tb_diachi.Clear();
        }
        private void FormQLKhoa_Load(object sender, EventArgs e)
        {
            loadData();
            dgv_khoa.ReadOnly = true;
        }

        private void tb_makhoa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_makhoa_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_makhoa.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tb_makhoa, "Mã khoa không được để trống");
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(tb_makhoa, null);
            }
        }

        private void tb_tenkhoa_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_tenkhoa.Text))
            {
                errorProvider1.SetError(tb_tenkhoa, "Mã khoa không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tb_tenkhoa, null);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string ma_khoa = tb_makhoa.Text;
                string query_select = $"Select * from tblKhoa where sMaKhoa='{ma_khoa}'";
                SqlCommand cmd = new SqlCommand(query_select, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand= cmd;
                dt_check.Clear();
                adt.Fill(dt_check);
                if (dt_check.Rows.Count>=1)
                {
                    errorProvider1.SetError(tb_makhoa, "Mã khoa đã tồn tại");
                }
                else
                {
                    string query_ins = $"insert into tblKhoa values('{tb_makhoa.Text}',N'{tb_tenkhoa.Text}',N'{tb_diachi.Text}')";
                    SqlCommand cmd_ins=new SqlCommand(query_ins, con);
                    cmd_ins.ExecuteNonQuery();
                }
                reLoad();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            loadData();
            int index = dgv_khoa.Rows.Count - 1;
            dgv_khoa.CurrentCell = dgv_khoa.Rows[index-1].Cells[0];
        }

        private void dgv_khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_khoa.CurrentRow.Index;
            tb_makhoa.Text = dsKhoa.Rows[index][0].ToString();
            tb_tenkhoa.Text = dsKhoa.Rows[index][1].ToString();
            tb_diachi.Text = dsKhoa.Rows[index][2].ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tb_makhoa.Text))
            {
                MessageBox.Show("Bạn cần chọn 1 thông tin để xóa", "Cảnh báo");
            }
            else
            {
                try
                {
                    if(MessageBox.Show("Bạn có chắc muốn xóa khoa này???","Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                        con.Open();
                        string query_del = $"delete from tblKhoa where sMaKhoa='{tb_makhoa.Text}'";
                        SqlCommand cmd = new SqlCommand(query_del, con);
                        cmd.ExecuteNonQuery();
                        reLoad();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khoa này đang bao gồm các ngành học được đăng kí", "Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                finally { con.Close(); }
                loadData();
            }
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tb_makhoa.Text)|| String.IsNullOrEmpty(tb_tenkhoa.Text)|| String.IsNullOrEmpty(tb_diachi.Text))
            {
                MessageBox.Show("Bạn cần chọn 1 khoa để sửa", "Thông báo");
            }
            else
            {
                FormSuaThongTinKhoa formsua=new FormSuaThongTinKhoa(tb_makhoa.Text,tb_tenkhoa.Text,tb_diachi.Text);
                formsua.ShowDialog();
                loadData();
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tb_makhoa.Text)&& String.IsNullOrEmpty(tb_tenkhoa.Text)&& String.IsNullOrEmpty(tb_diachi.Text))
            {
                MessageBox.Show("Cần nhập ít nhất 1 thông tin để tìm kiếm", "Thông báo");
            }
            else
            {
                string filterMaKhoa=tb_makhoa.Text;
                string filterTenKhoa=tb_tenkhoa.Text;
                string filterDiaChi = tb_diachi.Text;
                DataView dtv = new DataView(dsKhoa);

                if (String.IsNullOrEmpty(filterMaKhoa)&& String.IsNullOrEmpty(filterTenKhoa))
                {
                    dtv.RowFilter = string.Format($"sDiaChi like '%{filterDiaChi}%'");
                }
                if (String.IsNullOrEmpty(filterMaKhoa) && String.IsNullOrEmpty(filterDiaChi))
                {
                    dtv.RowFilter = string.Format($" sTenKhoa like '%{filterTenKhoa}%'");
                }
                if (String.IsNullOrEmpty(filterTenKhoa) && String.IsNullOrEmpty(filterDiaChi))
                {
                    dtv.RowFilter = string.Format($"sMaKhoa like '%{filterMaKhoa}%'");
                }
                if (String.IsNullOrEmpty(filterMaKhoa))
                {
                    dtv.RowFilter = string.Format($" sTenKhoa like '%{filterTenKhoa}%' and sDiaChi like '%{filterDiaChi}%'");
                }
                if (String.IsNullOrEmpty(filterDiaChi))
                {
                    dtv.RowFilter = string.Format($"sMaKhoa like '%{filterMaKhoa}%' and sTenKhoa like '%{filterTenKhoa}%'");
                }
                if (String.IsNullOrEmpty(filterTenKhoa))
                {
                    dtv.RowFilter = string.Format($"sMaKhoa like '%{filterMaKhoa}%' and sDiaChi like '%{filterDiaChi}%'");
                }
                dgv_khoa.DataSource = dtv;
            }
        }
    }
}
