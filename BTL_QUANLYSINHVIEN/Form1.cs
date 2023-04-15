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
    }
}
