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
    public partial class FormQlySV : Form
    {
        private SqlConnection con=new SqlConnection();
        private DataTable dsSV=new DataTable();
        private DataTable dsLop=new DataTable();
        private DataTable sv_check=new DataTable();
        public FormQlySV()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            con.Open();
            string query_selLop = "select * from tblLop";
            SqlCommand cmd_lop=new SqlCommand(query_selLop,con);
            SqlDataAdapter adt_lop = new SqlDataAdapter();                        
            adt_lop.SelectCommand= cmd_lop;
            dsLop.Clear();
            adt_lop.Fill(dsLop);
            if (dsLop.Rows.Count > 0)
            {
                cb_lop.DataSource= dsLop;
                cb_lop.DisplayMember = "sMaLop";
            }
            else
            {
                MessageBox.Show("Không thể lấy được thông tin lớp học");
            }
            try
            {
                string query_sv = "select * from tblSinhVien";
                SqlCommand cmd_sv=new SqlCommand(query_sv,con);
                SqlDataAdapter adt_sv=new SqlDataAdapter();
                adt_sv.SelectCommand= cmd_sv;
                dsSV.Clear();
                adt_sv.Fill(dsSV);
                if (dsSV.Rows.Count > 0)
                {
                    dgv_sinhvien.DataSource = dsSV;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu sinh viên");
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
            tb_sbd.Clear();
            tb_hoten.Clear();
            tb_cmnd.Clear();
            tb_tongiao.Clear();
            tb_email.Clear();
            tb_truong.Clear();
            tb_quequan.Clear();
            rd_nam.Checked= false;
            rd_nu.Checked=false;
            errorProvider1.SetError(rd_nu, null);
        }
   
        private void FormQlySV_Load(object sender, EventArgs e)
        {
            loadData();
            tb_sbd.Focus();
            dgv_sinhvien.ReadOnly= true;
        }

        private void tb_sbd_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tb_sbd.Text))
            {
                errorProvider1.SetError(tb_sbd, "Số báo danh không được để trống!");
            }
            else
            {
                errorProvider1.SetError(tb_sbd, null);
            }
        }

        private void dgv_sinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider1.SetError(tb_sbd, null);
            int index = dgv_sinhvien.CurrentRow.Index;
            tb_sbd.Text = dsSV.Rows[index]["sSoBd"].ToString();
            tb_hoten.Text = dsSV.Rows[index]["sHoTen"].ToString();
            dtp_ngaysinh.Text = dsSV.Rows[index]["dNgaySinh"].ToString();
            tb_cmnd.Text = dsSV.Rows[index]["sCMND"].ToString();
            tb_tongiao.Text = dsSV.Rows[index]["sTonGiao"].ToString();
            tb_email.Text = dsSV.Rows[index]["sEmail"].ToString();
            tb_truong.Text = dsSV.Rows[index]["sTruongTotNghiep"].ToString();
            tb_quequan.Text = dsSV.Rows[index]["sQueQuan"].ToString();
            if (String.Compare(dsSV.Rows[index]["sGioiTinh"].ToString(),"Nam")==0)
            {
                rd_nam.Checked= true;
            }
            if (String.Compare(dsSV.Rows[index]["sGioiTinh"].ToString(),"Nữ")==0)
            {
                rd_nu.Checked= true;
            }
            cb_lop.Text = dsSV.Rows[index]["sMaLop"].ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_sbd.Text))
            {
                try
                {
                    if (rd_nam.Checked == false && rd_nu.Checked == false)
                    {
                        errorProvider1.SetError(rd_nu, "Bạn cần chọn giới tính");
                    }
                    else
                    {
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ToString();
                        con.Open();
                        string gender = "";
                        string query_check = $"select * from tblSinhVien where sSoBD='{tb_sbd.Text}'";
                        SqlCommand cmd_check = new SqlCommand(query_check, con);
                        SqlDataAdapter adt_check = new SqlDataAdapter();
                        adt_check.SelectCommand = cmd_check;
                        sv_check.Clear();
                        adt_check.Fill(sv_check);
                        if (rd_nam.Checked)
                        {
                            gender = "Nam";
                        }
                        if (rd_nu.Checked)
                        {
                            gender = "Nữ";
                        }
                        if (sv_check.Rows.Count >= 1)
                        {
                            errorProvider1.SetError(tb_sbd, "Số báo danh đã tồn tại");
                        }
                        else
                        {
                            string query_ins = $"insert into tblSinhVien values('{tb_sbd.Text}',N'{tb_hoten.Text}','{dtp_ngaysinh.Text}','{tb_cmnd.Text}',N'{tb_tongiao.Text}','{tb_email.Text}',N'{tb_truong.Text}',N'{tb_quequan.Text}',N'{gender}','{cb_lop.Text}')";
                            SqlCommand cmd_ins = new SqlCommand(query_ins, con);
                            SqlDataAdapter adt_ins = new SqlDataAdapter();
                            cmd_ins.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }
                loadData();
                resetData();
            }
            else
            {
                errorProvider1.SetError(tb_sbd, "Số báo danh không được để trống");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_sbd.Text))
            {
                MessageBox.Show("Cần chọn 1 sinh viên để xóa");
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc muốn xóa sinh viên này???","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                        con.Open();
                        string query_del = $"delete from tblSinhVien where sSoBD = '{tb_sbd.Text}'";
                        SqlCommand cmd_del = new SqlCommand(query_del, con);
                        cmd_del.ExecuteNonQuery();
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Không thể xóa sinh viên này vì đã xác nhận hồ sơ");
                    }
                    finally { con.Close(); }
                    loadData(); 
                    resetData();
                }
            }
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_sbd.Text))
            {
                MessageBox.Show("Bạn cần chọn 1 thông tin sinh viên để sửa");
            }
            else
            {
                if (rd_nam.Checked)
                {
                    FormSuaThongTinSV formSV = new FormSuaThongTinSV(tb_sbd.Text, tb_hoten.Text, dtp_ngaysinh.Text, tb_cmnd.Text, "False", tb_tongiao.Text, tb_email.Text, tb_truong.Text, tb_quequan.Text, cb_lop.Text,dsLop);
                    formSV.ShowDialog(this);
                }
                if(rd_nu.Checked)
                {
                    FormSuaThongTinSV formSV = new FormSuaThongTinSV(tb_sbd.Text, tb_hoten.Text, dtp_ngaysinh.Text, tb_cmnd.Text, "True", tb_tongiao.Text, tb_email.Text, tb_truong.Text, tb_quequan.Text, cb_lop.Text,dsLop);
                    formSV.ShowDialog(this);
                }
            }
            loadData();
            resetData();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(tb_sbd, null);
            string filterSBD = tb_sbd.Text;
            string filterHoTen = tb_hoten.Text;
            string filterNgaySinh = dtp_ngaysinh.Text;
            string filterCMND= tb_cmnd.Text;
            string filterTonGiao= tb_tongiao.Text;
            string filterEmail=tb_email.Text;
            string filterTruong=tb_truong.Text;
            string filterQueQuan=tb_quequan.Text;
            string filterGioiTinh = "";
            if(rd_nam.Checked)
            {
                filterGioiTinh = "Nam";
            }
            if(rd_nu.Checked)
            {
                filterGioiTinh = "Nữ";
            }
            string fillterLop=cb_lop.Text;
            DataView dtv = new DataView(dsSV);

            dtv.RowFilter = String.Format($"sMaLop like '%{fillterLop}%'");
            if(!String.IsNullOrEmpty(filterSBD) )
            {
                dtv.RowFilter = String.Format($"sSoBD like '%{filterSBD}%'");
            }
            if (!String.IsNullOrEmpty(filterGioiTinh))
            {
                dtv.RowFilter = String.Format($"sGioiTinh like '%{filterGioiTinh}%'");
            }
            if (!String.IsNullOrEmpty(filterEmail))
            {
                dtv.RowFilter = String.Format($"sEmail like '%{filterEmail}%'");
            }
            if(!String.IsNullOrEmpty(filterTruong))
            {
                dtv.RowFilter = String.Format($"sTruongTotNghiep like '%{filterTruong}%'");
            }
            if(!String.IsNullOrEmpty(filterQueQuan))
            {
                dtv.RowFilter = String.Format($"sQueQuan like '%{filterQueQuan}%'");
            }
            dgv_sinhvien.DataSource = dtv;
        }

        private void btn_tiep_Click(object sender, EventArgs e)
        {
            loadData();
            resetData();
        }
    }
}
