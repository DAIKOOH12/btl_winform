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
    public partial class FormTkeLop : Form
    {
        public FormTkeLop()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            string[] items = { "Toàn bộ", "Thông tin sinh viên theo từng lớp","Sĩ số sinh viên theo từng lớp"};

            cb_loai.DataSource = items;
        }
        private void FormTkeLop_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            int index = 0;
            string info=tb_info.Text;
            if(String.IsNullOrEmpty(cb_loai.Text))
            {
                MessageBox.Show("Cần chọn 1 loại báo cáo");
            }
            else
            {
                if(String.Compare(cb_loai.Text,"Toàn bộ")==0)
                {
                    index = 1;
                    FormCRLop formCRLop = new FormCRLop(index,info);
                    formCRLop.ShowDialog();
                }
                if (String.Compare(cb_loai.Text, "Thông tin sinh viên theo từng lớp") == 0)
                {
                    if (String.IsNullOrEmpty(tb_info.Text))
                    {
                        MessageBox.Show("Cần nhập thông tin");
                    }
                    else
                    {
                        index = 2;
                        FormCRLop formCRLop = new FormCRLop(index, info);
                        formCRLop.ShowDialog();
                    }
                }
                if (String.Compare(cb_loai.Text, "Sĩ số sinh viên theo từng lớp") == 0)
                {
                    index = 3;
                    FormCRLop formCRLop = new FormCRLop(index, info);
                    formCRLop.ShowDialog();
                }
            }
            loadData();
        }

        private void cb_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Compare(cb_loai.Text, "Thông tin sinh viên theo từng lớp") == 0)
            {
                tb_info.Enabled = true;
            }
            if (String.Compare(cb_loai.Text, "Toàn bộ") == 0)
            {
                tb_info.Enabled = false;
            }
        }
    }
}