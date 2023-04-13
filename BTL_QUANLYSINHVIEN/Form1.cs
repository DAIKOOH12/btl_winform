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

        }

        private void qli_khoa_Click(object sender, EventArgs e)
        {
            FormQLKhoa form2=new FormQLKhoa();
            form2.FormBorderStyle= FormBorderStyle.None;
            form2.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            form2.TopLevel = false;
            panel1.Controls.Add(form2);
            form2.Show();
        }

        private void qli_nganh_Click(object sender, EventArgs e)
        {
            FormQLyNganh formQlyNganh=new FormQLyNganh();
            formQlyNganh.FormBorderStyle= FormBorderStyle.None;
            formQlyNganh.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            formQlyNganh.TopLevel= false;
            panel1.Controls.Add(formQlyNganh);
            formQlyNganh.Show();
        }
    }
}
