using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QUANLYSINHVIEN
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
        }

        private void qli_khoa_Click(object sender, EventArgs e)
        {
            FormQLKhoa form2=new FormQLKhoa();
            form2.ShowDialog();
            this.Refresh();
        }

        private void qli_nganh_Click(object sender, EventArgs e)
        {
            FormQLyNganh formQlyNganh=new FormQLyNganh();
            formQlyNganh.ShowDialog();
            this.Refresh();
        }

        private void qli_lop_Click(object sender, EventArgs e)
        {
            FormQlyLop formLop = new FormQlyLop();
            formLop.ShowDialog();
            this.Refresh();
        }

        private void qli_sinhvien_Click(object sender, EventArgs e)
        {
            FormQlySV formSV = new FormQlySV();
            formSV.ShowDialog();
        }

        private void qli_hoso_Click(object sender, EventArgs e)
        {
            FormQlyHoSo formHoSo=new FormQlyHoSo();
            formHoSo.ShowDialog();
        }

        private void qli_hoadon_Click(object sender, EventArgs e)
        {
            FormQlyHoaDon formHD=new FormQlyHoaDon();
            formHD.ShowDialog();
        }

        private void qli_diem_Click(object sender, EventArgs e)
        {
            FormQlyDiemChuan formDiem = new FormQlyDiemChuan();
            formDiem.ShowDialog();
        }

        private void qli_canbo_Click(object sender, EventArgs e)
        {
            FormQlyCanBo formCB=new FormQlyCanBo();
            formCB.ShowDialog();
        }

        private void tke_khoa_Click(object sender, EventArgs e)
        {
            FormTkeKhoa formTkeKhoa=new FormTkeKhoa();
            formTkeKhoa.ShowDialog();
        }

        private void tke_nganh_Click(object sender, EventArgs e)
        {
            FormTkeNganh formTkeNganh=new FormTkeNganh();
            formTkeNganh.ShowDialog();
        }

        private void tke_sinhvien_Click(object sender, EventArgs e)
        {
            FormTKeHocSinh formHS=new FormTKeHocSinh();
            formHS.ShowDialog();
        }
    }
}
