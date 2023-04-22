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
    public partial class FormTkeCanBo : Form
    {
        public FormTkeCanBo()
        {
            InitializeComponent();
        }

        private void FormTkeCanBo_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            string[] items = { "Toàn bộ" };

            cb_loai.DataSource = items;
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            int index = 0;
            if(String.Compare(cb_loai.Text,"Toàn bộ") == 0)
            {
                index = 1;
                FormCRCanBo formCB = new FormCRCanBo(index, tb_info.Text);
                formCB.ShowDialog();
            }
        }
    }
}
