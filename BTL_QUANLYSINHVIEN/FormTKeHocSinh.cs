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
    public partial class FormTKeHocSinh : Form
    {
        private void loadData()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            string[] items = { "Toàn bộ", "Theo tên", "Theo trường tốt nghiệp", "Theo quê quán","Theo giới tính","Theo lớp","Xem hồ sơ theo mã" };

            cb_loai.DataSource = items;
        }
        public FormTKeHocSinh()
        {
            InitializeComponent();
        }

        private void FormTKeHocSinh_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            int index = 0;
            string chon = cb_loai.Text;
            if (String.IsNullOrEmpty(chon))
            {
                MessageBox.Show("Cần chọn 1 loại thống kê");
            }
            else
            {
                if(String.Compare(chon, "Toàn bộ")==0)
                {
                    index = 1;
                    FormCRHocSinh formHS=new FormCRHocSinh(index,tb_info.Text);
                    formHS.ShowDialog();
                }
                if(String.Compare(chon,"Theo tên") == 0)
                {
                    if (String.IsNullOrEmpty(tb_info.Text))
                    {
                        MessageBox.Show("Cần nhập đủ thông tin");
                    }
                    else
                    {
                        index = 2;
                        FormCRHocSinh formHS = new FormCRHocSinh(index, tb_info.Text);
                        formHS.ShowDialog();
                    }
                }
                if (String.Compare(chon, "Theo trường tốt nghiệp") == 0)
                {
                    if (String.IsNullOrEmpty(tb_info.Text))
                    {
                        MessageBox.Show("Cần nhập đủ thông tin");
                    }
                    else
                    {
                        index = 3;
                        FormCRHocSinh formHS = new FormCRHocSinh(index, tb_info.Text);
                        formHS.ShowDialog();
                    }
                }
                if (String.Compare(chon, "Theo quê quán") == 0)
                {
                    if (String.IsNullOrEmpty(tb_info.Text))
                    {
                        MessageBox.Show("Cần nhập đủ thông tin");
                    }
                    else
                    {
                        index = 4;
                        FormCRHocSinh formHS = new FormCRHocSinh(index, tb_info.Text);
                        formHS.ShowDialog();
                    }
                }
                if (String.Compare(chon, "Theo quê quán") == 0)
                {
                    if (String.IsNullOrEmpty(tb_info.Text))
                    {
                        MessageBox.Show("Cần nhập đủ thông tin");
                    }
                    else
                    {
                        index = 4;
                        FormCRHocSinh formHS = new FormCRHocSinh(index, tb_info.Text);
                        formHS.ShowDialog();
                    }
                }
                if (String.Compare(chon, "Theo giới tính") == 0)
                {
                    if (String.IsNullOrEmpty(tb_info.Text))
                    {
                        MessageBox.Show("Cần nhập đủ thông tin");
                    }
                    else
                    {
                        index = 5;
                        FormCRHocSinh formHS = new FormCRHocSinh(index, tb_info.Text);
                        formHS.ShowDialog();
                    }
                }
                if (String.Compare(chon, "Theo lớp") == 0)
                {
                    if (String.IsNullOrEmpty(tb_info.Text))
                    {
                        MessageBox.Show("Cần nhập đủ thông tin");
                    }
                    else
                    {
                        index = 6;
                        FormCRHocSinh formHS = new FormCRHocSinh(index, tb_info.Text);
                        formHS.ShowDialog();
                    }
                }
                if (String.Compare(chon, "Xem hồ sơ theo mã") == 0)
                {
                    if (String.IsNullOrEmpty(tb_info.Text))
                    {
                        MessageBox.Show("Cần nhập đủ thông tin");
                    }
                    else
                    {
                        index = 7;
                        FormCRHocSinh formHS = new FormCRHocSinh(index, tb_info.Text);
                        formHS.ShowDialog();
                    }
                }
            }
            loadData();
        }

        private void cb_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(String.Compare(cb_loai.Text, "Theo tên") ==0|| String.Compare(cb_loai.Text, "Theo trường tốt nghiệp") == 0|| String.Compare(cb_loai.Text, "Theo quê quán") == 0|| String.Compare(cb_loai.Text, "Theo giới tính") == 0|| String.Compare(cb_loai.Text, "Theo lớp") == 0|| String.Compare(cb_loai.Text, "Xem hồ sơ theo mã") == 0)
            {
                tb_info.Enabled= true;
            }
            if(String.Compare(cb_loai.Text, "Toàn bộ") == 0)
            {
                tb_info.Enabled = false;
            }
        }
    }
}
