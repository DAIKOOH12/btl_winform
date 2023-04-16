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
    public partial class FormQlyHoSo : Form
    {
        private SqlConnection con = new SqlConnection();
        private DataTable dsSV = new DataTable();
        private DataTable dsCB = new DataTable();
        private DataTable dsHS = new DataTable();
        public FormQlyHoSo()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            con.Open();
            string query_selSV = "Select * from tblSinhVien";
            string query_selCB = "Select * from tblCanBo";
            SqlCommand cmd_sv = new SqlCommand(query_selSV, con);
            SqlCommand cmd_cb = new SqlCommand(query_selCB, con);
            SqlDataAdapter adt_sv = new SqlDataAdapter();
            SqlDataAdapter adt_cb = new SqlDataAdapter();
            adt_cb.SelectCommand = cmd_cb;
            adt_sv.SelectCommand = cmd_sv;
            dsSV.Clear();
            dsCB.Clear();
            adt_cb.Fill(dsCB);
            adt_sv.Fill(dsSV);
            if (dsCB.Rows.Count > 0)
            {
                cb_canbo.DataSource = dsCB;
                cb_canbo.DisplayMember = "sMaCB";
            }
            else
            {
                MessageBox.Show("Không thể lấy được dữ liệu cán bộ");
            }
            if (dsSV.Rows.Count > 0)
            {
                cb_sbd.DataSource = dsSV;
                cb_sbd.DisplayMember = "sSoBD";
            }
            else
            {
                MessageBox.Show("Không thể lấy được dữ liệu sinh viên");
            }
            try
            {
                string query = "select * from tblHoSoSinhVien";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adt = new SqlDataAdapter();
                adt.SelectCommand = cmd;
                dsHS.Clear();
                adt.Fill(dsHS);
                if (dsHS.Rows.Count > 0)
                {
                    dgv_hoso.DataSource = dsHS;
                }
                else
                {
                    MessageBox.Show("Không thể lấy được thông tin hồ sơ");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
        private void resetData()
        {
            tb_mahoso.Clear();
            tb_hokhau.Clear();
            tb_namtotnghiep.Clear();
            tb_hotenbo.Clear(); 
            tb_hotenme.Clear();
        }
        private int compareDate(string s1,string s2)
        {
            DateTime d1=Convert.ToDateTime(s1);
            DateTime d2= Convert.ToDateTime(s2);
            int i=DateTime.Compare(d1,d2);
            return i;
        }
        private void FormQlyHoSo_Load(object sender, EventArgs e)
        {
            loadData();
            dgv_hoso.ReadOnly = true;
        }

        private void dgv_hoso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_hoso.CurrentRow.Index;
            tb_mahoso.Text = dsHS.Rows[index][0].ToString();
            tb_hokhau.Text = dsHS.Rows[index][1].ToString();
            tb_namtotnghiep.Text = dsHS.Rows[index][2].ToString();
            tb_hotenbo.Text = dsHS.Rows[index][3].ToString();
            tb_hotenme.Text = dsHS.Rows[index][4].ToString();
            dtp_thu.Text = dsHS.Rows[index][5].ToString();
            dtp_gui.Text = dsHS.Rows[index][6].ToString();
            cb_sbd.Text = dsHS.Rows[index][7].ToString();
            cb_canbo.Text = dsHS.Rows[index][8].ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_mahoso.Text))
            {
                errorProvider1.SetError(tb_mahoso, "Mã hồ sơ không được để trống");
            }
            else
            {
                if (compareDate(dtp_thu.Text, dtp_gui.Text) < 0)
                {
                    MessageBox.Show("Ngày gửi phải trước ngày thu");
                }
                else
                {
                    try
                    {
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                        con.Open();
                        DataTable check_hs=new DataTable();
                        string query_check = $"Select * from tblHoSoSinhVien where sMaHS='{tb_mahoso.Text}'";
                        SqlCommand cmd_check=new SqlCommand(query_check, con);
                        SqlDataAdapter adt_check = new SqlDataAdapter();
                        adt_check.SelectCommand= cmd_check;
                        adt_check.Fill(check_hs);
                        if(check_hs.Rows.Count > 0)
                        {
                            MessageBox.Show("Đã tồn tại hồ sơ sinh viên này");
                        }
                        else
                        {
                            string query_ins = $"insert into tblHoSoSinhVien values('{tb_mahoso.Text}',N'{tb_hokhau.Text}','{Convert.ToInt32(tb_namtotnghiep.Text)}',N'{tb_hotenbo.Text}',N'{tb_hotenme.Text}','{dtp_thu.Text}','{dtp_gui.Text}','{cb_sbd.Text}','{cb_canbo.Text}')";
                            SqlCommand cmd=new SqlCommand(query_ins, con);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { con.Close(); }
                    loadData();
                    resetData();
                }
            }
        }

        private void tb_namtotnghiep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            else
            {
                string text = tb_namtotnghiep.Text + e.KeyChar;

                float value = 0;
                float.TryParse(text, out value);

                if (value < 0 || value > 9999)
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_mahoso.Text))
            {
                MessageBox.Show("Bạn cần chọn 1 hồ sơ để xóa");
            }
            else
            {
                try
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    con.Open();
                    string query_del = $"delete from tblHoSoSinhVien where sMaHS='{tb_mahoso.Text}'";
                    SqlCommand cmd = new SqlCommand(query_del, con);
                    cmd.ExecuteNonQuery();
                }catch(Exception ex)
                {
                    MessageBox.Show("Không thể xóa mã hồ sơ này");
                }
                finally { con.Close(); }
                loadData();
                resetData();
            }
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_mahoso.Text))
            {
                MessageBox.Show("Cần chọn 1 hồ sơ để cập nhật");
            }
            else
            {
                FormSuaThongTinHoSo formHS = new FormSuaThongTinHoSo(tb_mahoso.Text,tb_hokhau.Text,tb_namtotnghiep.Text,tb_hotenbo.Text,tb_hotenme.Text,dtp_thu.Text,dtp_gui.Text,cb_sbd.Text,cb_canbo.Text,dsSV,dsCB);
                formHS.ShowDialog(this);
                loadData();
                resetData();
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string filterMaHS = tb_mahoso.Text;
            string filterHoKhau = tb_hokhau.Text;
            string filterNam = tb_namtotnghiep.Text;
            DateTime filterTgianThu = Convert.ToDateTime(dtp_thu.Text);
            DateTime filterTgianGui = Convert.ToDateTime(dtp_gui.Text);
            string filterSBD = cb_sbd.Text;
            string filterCB = cb_canbo.Text;

            DataView dtv = new DataView(dsHS);

            if (!String.IsNullOrEmpty(filterMaHS))
            {
                dtv.RowFilter = String.Format($"sMaHS like '%{filterMaHS}%'");
            }
            if (!String.IsNullOrEmpty(filterHoKhau))
            {
                dtv.RowFilter = String.Format($"sHoKhau like '%{filterHoKhau}%'");
            }
            if (!String.IsNullOrEmpty(filterNam))
            {
                dtv.RowFilter = $"iNamTotNghiep = '{Convert.ToInt32(filterNam)}'";
            }

            dgv_hoso.DataSource = dtv;
        }

        private void btn_tiep_Click(object sender, EventArgs e)
        {
            loadData();
            resetData();
        }
    }
}
