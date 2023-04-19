using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QUANLYSINHVIEN
{
    public partial class FormTkeNganh : Form
    {
        private int index;
        private void loadData()
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }
        public FormTkeNganh()
        {
            InitializeComponent();
        }

        private void FormTkeNganh_Load(object sender, EventArgs e)
        {

        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            string loai = cb_loai.Text;
            if(String.IsNullOrEmpty(cb_loai.Text))
            {
                MessageBox.Show("Chọn loại để xuất báo cáo");
            }
            else if (String.Compare(loai, "Toàn bộ") == 0)
            {
                index = 1;
                FormCRNganh formCRNganh = new FormCRNganh(index, tb_info.Text);
                formCRNganh.ShowDialog();
                
            }
            else if(String.Compare(cb_loai.Text, "Theo tên ngành") == 0)
            {
                if (String.IsNullOrEmpty(tb_info.Text))
                {
                    MessageBox.Show("Bạn cần nhập thông tin để lập báo cáo");
                }
                else
                {
                    index = 2;
                    FormCRNganh formCRNganh = new FormCRNganh(index, tb_info.Text);
                    formCRNganh.ShowDialog();
                }
            }
            else if (String.Compare(cb_loai.Text, "Theo khoa") == 0)
            {
                if (String.IsNullOrEmpty(tb_info.Text))
                {
                    MessageBox.Show("Bạn cần nhập thông tin để lập báo cáo");
                }
                else
                {
                    index = 3;
                    FormCRNganh formCRNganh = new FormCRNganh(index, tb_info.Text);
                    formCRNganh.ShowDialog();
                }
            }
            else if (String.Compare(cb_loai.Text, "Số lượng từng ngành theo khoa") == 0)
            {
                if (String.IsNullOrEmpty(tb_info.Text))
                {
                    MessageBox.Show("Bạn cần nhập thông tin để lập báo cáo");
                }
                else
                {
                    index = 4;
                    FormCRNganh formCRNganh = new FormCRNganh(index, tb_info.Text);
                    formCRNganh.ShowDialog();
                }
            }
            loadData();
        }

        private void cb_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Compare(cb_loai.Text, "Theo tên ngành") == 0 || String.Compare(cb_loai.Text, "Theo khoa") == 0|| String.Compare(cb_loai.Text, "Số lượng ngành theo khoa") == 0)
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
