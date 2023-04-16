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
    public partial class FormSuaThongTinHoSo : Form
    {
        private SqlConnection con = new SqlConnection();
        private string mahs;
        private string hokhau;
        private string namtotnghiep;
        private string hotenbo;
        private string hotenme;
        private string ngaythu;
        private string ngaygui;
        private string sobaodanh;
        private string macanbo;
        private DataTable dsSV = new DataTable();
        private DataTable dsCB = new DataTable();
        public FormSuaThongTinHoSo(string mahs, string hokhau, string namtotnghiep, string hotenbo, string hotenme, string ngaythu, string ngaygui, string sobaodanh, string macanbo, DataTable dsSV, DataTable dsCB)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.mahs = mahs;
            this.hokhau = hokhau;
            this.namtotnghiep = namtotnghiep;
            this.hotenbo = hotenbo;
            this.hotenme = hotenme;
            this.ngaythu = ngaythu;
            this.ngaygui = ngaygui;
            this.sobaodanh = sobaodanh;
            this.macanbo = macanbo;
            this.dsSV = dsSV;
            this.dsCB = dsCB;
        }
        private int compareData(string s1, string s2)
        {
            DateTime d1 = Convert.ToDateTime(s1);
            DateTime d2 = Convert.ToDateTime(s2);
            int i = DateTime.Compare(d1, d2);
            return i;
        }
        private void FormSuaThongTinHoSo_Load(object sender, EventArgs e)
        {
            tb_mahoso.Text = this.mahs;
            tb_hokhau.Text = this.hokhau;
            tb_namtotnghiep.Text = this.namtotnghiep;
            tb_hotenbo.Text = this.hotenbo;
            tb_hotenme.Text = this.hotenme;
            dtp_thu.Text = this.ngaythu;
            dtp_gui.Text = this.ngaygui;
            cb_canbo.DataSource = dsCB;
            cb_canbo.DisplayMember = "sMaCB";
            cb_sbd.DataSource = dsSV;
            cb_sbd.DisplayMember = "sSoBD";
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát???","Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (compareData(dtp_thu.Text, dtp_gui.Text) < 0)
            {
                MessageBox.Show("Ngày thu phải lớn hơn ngày gửi");
            }
            else
            {
                try
                {
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                    con.Open();
                    string query_udt = $"update tblHoSoSinhVien set sHoKhau=N'{tb_hokhau.Text}',iNamTotNghiep='{Convert.ToInt32(tb_namtotnghiep.Text)}',sHoTenBo=N'{tb_hotenbo.Text}',sHoTenMe=N'{tb_hotenme.Text}',dThoiGianThu='{dtp_thu.Text}',dThoiGianGui='{dtp_gui.Text}',sSoBD='{cb_sbd.Text}',sMaCB='{cb_canbo.Text}' where sMaHS='{tb_mahoso.Text}'";
                    SqlCommand cmd = new SqlCommand(query_udt, con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { con.Close(); }
                this.Dispose();
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
    }
}
