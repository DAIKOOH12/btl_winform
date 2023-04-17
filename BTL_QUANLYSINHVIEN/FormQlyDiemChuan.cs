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
    public partial class FormQlyDiemChuan : Form
    {
        private SqlConnection con=new SqlConnection();
        private DataTable dsSV=new DataTable();
        private DataTable dsNganh=new DataTable();
        private DataTable dsDiem=new DataTable();
        private DataTable check_diem=new DataTable();
        private void loadData()
        {
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query_selSV = "select * from tblSinhVien";
                SqlCommand cmd_sv = new SqlCommand(query_selSV, con);
                SqlDataAdapter adt_sv = new SqlDataAdapter();
                adt_sv.SelectCommand = cmd_sv;
                dsSV.Clear();
                adt_sv.Fill(dsSV);
                cb_sbd.DataSource = dsSV;
                cb_sbd.DisplayMember = "sSoBD";
                if (dsSV.Rows.Count > 0)
                {
                    string query_selNganh = "select * from tblNganh";
                    SqlCommand cmd_nganh = new SqlCommand(query_selNganh, con);
                    SqlDataAdapter adt_nganh = new SqlDataAdapter();
                    adt_nganh.SelectCommand = cmd_nganh;
                    dsNganh.Clear();
                    adt_nganh.Fill(dsNganh);
                    cb_nganh.DataSource = dsNganh;
                    cb_nganh.DisplayMember = "sMaNganh";
                    if (dsNganh.Rows.Count > 0)
                    {
                        string query_selDiem = "Select * from tblDiemChuan";
                        SqlCommand cmd_diem = new SqlCommand(query_selDiem, con);
                        SqlDataAdapter adt_diem = new SqlDataAdapter();
                        adt_diem.SelectCommand= cmd_diem;
                        dsDiem.Clear();
                        adt_diem.Fill(dsDiem);
                        if (dsDiem.Rows.Count > 0)
                        {
                            dgv_diem.DataSource = dsDiem;
                        }
                        else
                        {
                            MessageBox.Show("Không lấy được thông tin điểm đầu vào");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy được dữ liệu ngành");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lấy được dữ liệu sinh viên");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }
        private void resetData()
        {
            tb_khoitohop.Clear();
            tb_diem1.Clear();
            tb_diem2.Clear();
            tb_diem3.Clear();
            tb_diemuutien.Clear();
        }
        public FormQlyDiemChuan()
        {
            InitializeComponent();
        }

        private void FormQlyDiemChuan_Load(object sender, EventArgs e)
        {
            loadData();
            dgv_diem.ReadOnly= true;
        }

        private void dgv_diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider1.SetError(cb_sbd, null);
            errorProvider1.SetError(tb_khoitohop, null);
            int index = dgv_diem.CurrentRow.Index;
            cb_sbd.Text = dsDiem.Rows[index][0].ToString();
            cb_nganh.Text = dsDiem.Rows[index][1].ToString();
            tb_khoitohop.Text = dsDiem.Rows[index][2].ToString();
            tb_diem1.Text = dsDiem.Rows[index][3].ToString();
            tb_diem2.Text = dsDiem.Rows[index][4].ToString();
            tb_diem3.Text = dsDiem.Rows[index][5].ToString();
            tb_diemuutien.Text = dsDiem.Rows[index][6].ToString();
        }

        private void tb_diem1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                // Ngăn không cho ký tự được nhập vào
                e.Handled = true;
            }
            else
            {
                // Kiểm tra giá trị mới của TextBox nếu thêm ký tự được nhập vào
                string text = tb_diem1.Text + e.KeyChar;

                // Chuyển đổi giá trị mới thành số nguyên
                float value = 0;
                float.TryParse(text, out value);

                // Kiểm tra nếu giá trị mới nằm ngoài phạm vi từ 0 đến 10
                if (value < 0 || value > 10)
                {
                    // Ngăn không cho ký tự được nhập vào
                    e.Handled = true;
                }
            }
        }

        private void tb_diem2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                // Ngăn không cho ký tự được nhập vào
                e.Handled = true;
            }
            else
            {
                // Kiểm tra giá trị mới của TextBox nếu thêm ký tự được nhập vào
                string text = tb_diem2.Text + e.KeyChar;

                // Chuyển đổi giá trị mới thành số nguyên
                float value = 0;
                float.TryParse(text, out value);

                // Kiểm tra nếu giá trị mới nằm ngoài phạm vi từ 0 đến 10
                if (value < 0 || value > 10)
                {
                    // Ngăn không cho ký tự được nhập vào
                    e.Handled = true;
                }
            }
        }

        private void tb_diem3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                // Ngăn không cho ký tự được nhập vào
                e.Handled = true;
            }
            else
            {
                // Kiểm tra giá trị mới của TextBox nếu thêm ký tự được nhập vào
                string text = tb_diem3.Text + e.KeyChar;

                // Chuyển đổi giá trị mới thành số nguyên
                float value = 0;
                float.TryParse(text, out value);

                // Kiểm tra nếu giá trị mới nằm ngoài phạm vi từ 0 đến 10
                if (value < 0 || value > 10)
                {
                    // Ngăn không cho ký tự được nhập vào
                    e.Handled = true;
                }
            }
        }

        private void tb_diemuutien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                // Ngăn không cho ký tự được nhập vào
                e.Handled = true;
            }
            else
            {
                // Kiểm tra giá trị mới của TextBox nếu thêm ký tự được nhập vào
                string text = tb_diemuutien.Text + e.KeyChar;

                // Chuyển đổi giá trị mới thành số nguyên
                float value = 0;
                float.TryParse(text, out value);

                // Kiểm tra nếu giá trị mới nằm ngoài phạm vi từ 0 đến 10
                if (value < 0 || value > 10)
                {
                    // Ngăn không cho ký tự được nhập vào
                    e.Handled = true;
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_diemuutien.Text))
            {
                errorProvider1.SetError(tb_khoitohop, "Tổ hợp môn không được để trống");
            }
            else
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query_check = $"select * from tblDiemChuan where sSoBD='{cb_sbd.Text}' and sMaNganh='{cb_nganh.Text}'";
                SqlCommand cmd_check=new SqlCommand(query_check, con);
                SqlDataAdapter adt_check = new SqlDataAdapter();
                adt_check.SelectCommand= cmd_check;
                check_diem.Clear();
                adt_check.Fill(check_diem);
                if(check_diem.Rows.Count > 0 )
                {
                    errorProvider1.SetError(cb_sbd, "Đã tồn tại sinh viên với mã ngành này");
                }
                else
                {
                    try
                    {
                        string query_ins = $"insert into tblDiemChuan values('{cb_sbd.Text}','{cb_nganh.Text}','{tb_khoitohop.Text}','{Convert.ToDouble(tb_diem1.Text)}','{Convert.ToDouble(tb_diem2.Text)}','{Convert.ToDouble(tb_diem3.Text)}','{Convert.ToDouble(tb_diemuutien.Text)}')";
                        SqlCommand cmd_ins=new SqlCommand(query_ins,con);
                        cmd_ins.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { con.Close(); }
                }
                loadData();
                resetData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa thông tin này","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                con.Open();
                string query_del = $"delete from tblDiemChuan where sSoBD='{cb_sbd.Text}' and sMaNganh='{cb_nganh.Text}'";
                SqlCommand cmd_del=new SqlCommand(query_del,con);
                cmd_del.ExecuteNonQuery();
                con.Close();
            }
            loadData();
            resetData();
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_khoitohop.Text))
            {
                MessageBox.Show("Cần chọn 1 thông tin để sửa");
            }
            else
            {
                FormSuaThongTinDiem formDiem = new FormSuaThongTinDiem(cb_sbd.Text, cb_nganh.Text, tb_khoitohop.Text, tb_diem1.Text, tb_diem2.Text, tb_diem3.Text, tb_diemuutien.Text, dsSV, dsNganh);
                formDiem.ShowDialog();
                loadData();
                resetData();
            }
        }

        private void btn_tiep_Click(object sender, EventArgs e)
        {
            loadData();
            resetData();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            string filterSBD = cb_sbd.Text;
            string filterNganh=cb_nganh.Text;
            string filterKhoi = tb_khoitohop.Text;
            DataView dtv = new DataView(dsDiem);

            if (!String.IsNullOrEmpty(filterKhoi))
            {
                dtv.RowFilter = String.Format($"sKhoiToHop like '%{filterKhoi}%'");
            }
            else
            {
                dtv.RowFilter = String.Format($"sSoBD like '%{filterSBD}%' and sMaNganh like '%{filterNganh}%'");
            }

            dgv_diem.DataSource = dtv;
        }
        //Duy Trường đã sửa đoạn này
    }
}
