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
    public partial class FormTkeKhoa : Form
    {
        private int index = 0;
        
        private void loadData()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            string[] items = { "Toàn bộ", "Theo tên", "Theo địa chỉ" };
            
            cb_loai.DataSource= items;
        }
        public FormTkeKhoa()
        {
            InitializeComponent();
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            string loai = cb_loai.Text;
            if (String.IsNullOrEmpty(loai))
            {
                MessageBox.Show("Bạn cần chọn loại thống kê");
            }
            else if(String.Compare(loai, "Toàn bộ") == 0)
            {
                index = 1;
                FormCRKhoa formTkeKhoa = new FormCRKhoa(index, loai);
                formTkeKhoa.ShowDialog();
            }
            else if(String.Compare(loai, "Theo tên") == 0)
            { 
                if (String.IsNullOrEmpty(tb_info.Text))
                {
                    MessageBox.Show("Cần nhập thông tin đầy đủ");
                }
                else
                {
                    index = 2;
                    FormCRKhoa formTkeKhoa = new FormCRKhoa(index, tb_info.Text);
                    formTkeKhoa.ShowDialog();
                }
            }
            else if (String.Compare(loai, "Theo địa chỉ") == 0)
            {
                if (String.IsNullOrEmpty(tb_info.Text))
                {
                    MessageBox.Show("Cần nhập thông tin đầy đủ");
                }
                else
                {
                    index = 3;
                    FormCRKhoa formTkeKhoa = new FormCRKhoa(index, tb_info.Text);
                    formTkeKhoa.ShowDialog();
                }
            }
            loadData();
        }

        private void cb_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.Compare(cb_loai.Text, "Theo tên") == 0|| String.Compare(cb_loai.Text, "Theo địa chỉ") == 0)
            {
                tb_info.Enabled = true;
            }
            if (String.Compare(cb_loai.Text, "Toàn bộ") == 0)
            {
                tb_info.Enabled = false;
            }
        }

        private void FormTkeKhoa_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
