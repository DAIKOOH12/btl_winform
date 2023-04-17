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
    public partial class FormQlyHoaDon : Form
    {
        private SqlConnection con = new SqlConnection();
        private DataTable dsHD = new DataTable();
        private DataTable dsSV = new DataTable();
        private DataTable check_hd = new DataTable();
        private void loadData()
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query_selSV = "Select * from tblSinhVien";
                SqlCommand cmd_sv = new SqlCommand(query_selSV, con);
                SqlDataAdapter adt_sv = new SqlDataAdapter();
                adt_sv.SelectCommand = cmd_sv;
                dsSV.Clear();
                adt_sv.Fill(dsSV);
                if (dsSV.Rows.Count > 0)
                {
                    string quert_selHD = "Select * from tblHoaDonHocPhi";
                    SqlCommand cmd_hd = new SqlCommand(quert_selHD, con);
                    SqlDataAdapter adt_hd = new SqlDataAdapter();
                    adt_hd.SelectCommand = cmd_hd;
                    dsHD.Clear();
                    adt_hd.Fill(dsHD);
                    cb_sbd.DataSource = dsSV;
                    cb_sbd.DisplayMember = "sSoBD";
                    if (dsHD.Rows.Count > 0)
                    { 
                        dgv_hoadon.DataSource = dsHD;
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lấy được thông tin sinh viên");  
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
            tb_mahoadon.Clear();
            tb_tien.Clear();
            loadData();
        }
        public FormQlyHoaDon()
        {
            InitializeComponent();
        }

        private void FormQlyHoaDon_Load(object sender, EventArgs e)
        {
            loadData();
            dgv_hoadon.ReadOnly = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_mahoadon.Text))
            {
                errorProvider1.SetError(tb_mahoadon, "Mã hóa đơn không được để trống");
            }
            else
            {
                try
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    con.Open();
                    string query_check = $"select * from tblHoaDonHocPhi where sMaHD='{tb_mahoadon.Text}'";
                    SqlCommand cmd_check = new SqlCommand(query_check, con);
                    SqlDataAdapter adt_check = new SqlDataAdapter();
                    adt_check.SelectCommand = cmd_check;
                    check_hd.Clear();
                    adt_check.Fill(check_hd);
                    if (check_hd.Rows.Count > 0)
                    {
                        errorProvider1.SetError(tb_mahoadon, "Đã tồn tại hóa đơn này");
                    }
                    else
                    {
                        errorProvider1.SetError(tb_mahoadon, null);
                        string query_ins = $"insert into tblHoaDonHocPhi values('{tb_mahoadon.Text}',{Convert.ToDouble(tb_tien.Text)},'{cb_sbd.Text}')";
                        SqlCommand cmd_ins = new SqlCommand(query_ins, con);
                        cmd_ins.ExecuteNonQuery();
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }
                loadData();
                resetData();
            }
        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_hoadon.CurrentRow.Index;
            tb_mahoadon.Text = dsHD.Rows[index][0].ToString();
            tb_tien.Text = dsHD.Rows[index][1].ToString();
            cb_sbd.Text = dsHD.Rows[index][2].ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_mahoadon.Text))
            {
                MessageBox.Show("Bạn cần chọn 1 hóa đơn để xóa");
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc muốn xóa sinh viên này????","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    con.Open();
                    string query_del=$"delete from tblHoaDonHocPhi where sMaHD='{tb_mahoadon.Text}'";
                    SqlCommand cmd_del = new SqlCommand(query_del, con);
                    cmd_del.ExecuteNonQuery();
                    con.Close();
                }
                loadData();
                resetData();
            }
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_mahoadon.Text))
            {
                MessageBox.Show("Bạn cần chọn 1 hóa đơn để cập nhật");
            }
            else
            {
                FormSuaThongTinHD formHD = new FormSuaThongTinHD(tb_mahoadon.Text, tb_tien.Text, cb_sbd.Text, dsSV);
                formHD.ShowDialog();
                loadData();
                resetData();

            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string filterMaHD=tb_mahoadon.Text;
            string filterTien=tb_tien.Text;
            string filterLop = cb_sbd.Text;
            DataView dtv = new DataView(dsHD);

            if (!String.IsNullOrEmpty(filterMaHD))
            {
                dtv.RowFilter = String.Format($"sMaHD like '%{filterMaHD}%'");
            }
            if (!String.IsNullOrEmpty(filterTien))
            {
                dtv.RowFilter = $"fTongTien = '{filterTien}'";
            }
            dgv_hoadon.DataSource= dtv;
        }

        private void btn_tiep_Click(object sender, EventArgs e)
        {
            loadData();
            resetData();
        }

        private void tb_tien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            else
            {
                string text = tb_tien.Text + e.KeyChar;

                float value = 0;
                float.TryParse(text, out value);

                if (value < 0 )
                {
                    e.Handled = true;
                }
            }
        }
    }
}
