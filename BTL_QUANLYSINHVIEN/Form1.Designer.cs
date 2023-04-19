namespace BTL_QUANLYSINHVIEN
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mns_main = new System.Windows.Forms.MenuStrip();
            this.mns_trangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.qli_khoa = new System.Windows.Forms.ToolStripMenuItem();
            this.qli_nganh = new System.Windows.Forms.ToolStripMenuItem();
            this.qli_lop = new System.Windows.Forms.ToolStripMenuItem();
            this.qli_sinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.qli_hoso = new System.Windows.Forms.ToolStripMenuItem();
            this.qli_hoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.qli_diem = new System.Windows.Forms.ToolStripMenuItem();
            this.qli_canbo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsi_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.tke_khoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tke_nganh = new System.Windows.Forms.ToolStripMenuItem();
            this.tke_sinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.tke_lop = new System.Windows.Forms.ToolStripMenuItem();
            this.tke_hososinhvien = new System.Windows.Forms.ToolStripMenuItem();
            this.tke_hoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.tke_diemchuan = new System.Windows.Forms.ToolStripMenuItem();
            this.tke_canbo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mns_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns_main
            // 
            this.mns_main.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mns_main.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mns_main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mns_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mns_trangchu,
            this.mnsi_quanly,
            this.mnsi_baocao});
            this.mns_main.Location = new System.Drawing.Point(0, 0);
            this.mns_main.Name = "mns_main";
            this.mns_main.Size = new System.Drawing.Size(1260, 33);
            this.mns_main.TabIndex = 0;
            this.mns_main.Text = "menuStrip1";
            // 
            // mns_trangchu
            // 
            this.mns_trangchu.Name = "mns_trangchu";
            this.mns_trangchu.Size = new System.Drawing.Size(126, 29);
            this.mns_trangchu.Text = "TRANG CHỦ";
            // 
            // mnsi_quanly
            // 
            this.mnsi_quanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qli_khoa,
            this.qli_nganh,
            this.qli_lop,
            this.qli_sinhvien,
            this.qli_hoso,
            this.qli_hoadon,
            this.qli_diem,
            this.qli_canbo});
            this.mnsi_quanly.Name = "mnsi_quanly";
            this.mnsi_quanly.Size = new System.Drawing.Size(101, 29);
            this.mnsi_quanly.Text = "QUẢN LÝ";
            // 
            // qli_khoa
            // 
            this.qli_khoa.Name = "qli_khoa";
            this.qli_khoa.Size = new System.Drawing.Size(251, 34);
            this.qli_khoa.Text = "Quản lý Khoa";
            this.qli_khoa.Click += new System.EventHandler(this.qli_khoa_Click);
            // 
            // qli_nganh
            // 
            this.qli_nganh.Name = "qli_nganh";
            this.qli_nganh.Size = new System.Drawing.Size(251, 34);
            this.qli_nganh.Text = "Quản lý Ngành";
            this.qli_nganh.Click += new System.EventHandler(this.qli_nganh_Click);
            // 
            // qli_lop
            // 
            this.qli_lop.Name = "qli_lop";
            this.qli_lop.Size = new System.Drawing.Size(251, 34);
            this.qli_lop.Text = "Quản lý Lớp";
            this.qli_lop.Click += new System.EventHandler(this.qli_lop_Click);
            // 
            // qli_sinhvien
            // 
            this.qli_sinhvien.Name = "qli_sinhvien";
            this.qli_sinhvien.Size = new System.Drawing.Size(251, 34);
            this.qli_sinhvien.Text = "Quản lý Sinh viên";
            this.qli_sinhvien.Click += new System.EventHandler(this.qli_sinhvien_Click);
            // 
            // qli_hoso
            // 
            this.qli_hoso.Name = "qli_hoso";
            this.qli_hoso.Size = new System.Drawing.Size(251, 34);
            this.qli_hoso.Text = "Quản lý Hồ sơ";
            this.qli_hoso.Click += new System.EventHandler(this.qli_hoso_Click);
            // 
            // qli_hoadon
            // 
            this.qli_hoadon.Name = "qli_hoadon";
            this.qli_hoadon.Size = new System.Drawing.Size(251, 34);
            this.qli_hoadon.Text = "Quản lý Hóa đơn";
            this.qli_hoadon.Click += new System.EventHandler(this.qli_hoadon_Click);
            // 
            // qli_diem
            // 
            this.qli_diem.Name = "qli_diem";
            this.qli_diem.Size = new System.Drawing.Size(251, 34);
            this.qli_diem.Text = "Quản lý Điểm";
            this.qli_diem.Click += new System.EventHandler(this.qli_diem_Click);
            // 
            // qli_canbo
            // 
            this.qli_canbo.Name = "qli_canbo";
            this.qli_canbo.Size = new System.Drawing.Size(251, 34);
            this.qli_canbo.Text = "Quản lý Cán bộ";
            this.qli_canbo.Click += new System.EventHandler(this.qli_canbo_Click);
            // 
            // mnsi_baocao
            // 
            this.mnsi_baocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tke_khoa,
            this.tke_nganh,
            this.tke_sinhvien,
            this.tke_lop,
            this.tke_hososinhvien,
            this.tke_hoadon,
            this.tke_diemchuan,
            this.tke_canbo});
            this.mnsi_baocao.Name = "mnsi_baocao";
            this.mnsi_baocao.Size = new System.Drawing.Size(113, 29);
            this.mnsi_baocao.Text = "THỐNG KÊ";
            // 
            // tke_khoa
            // 
            this.tke_khoa.Name = "tke_khoa";
            this.tke_khoa.Size = new System.Drawing.Size(270, 34);
            this.tke_khoa.Text = "Khoa";
            this.tke_khoa.Click += new System.EventHandler(this.tke_khoa_Click);
            // 
            // tke_nganh
            // 
            this.tke_nganh.Name = "tke_nganh";
            this.tke_nganh.Size = new System.Drawing.Size(270, 34);
            this.tke_nganh.Text = "Ngành";
            this.tke_nganh.Click += new System.EventHandler(this.tke_nganh_Click);
            // 
            // tke_sinhvien
            // 
            this.tke_sinhvien.Name = "tke_sinhvien";
            this.tke_sinhvien.Size = new System.Drawing.Size(270, 34);
            this.tke_sinhvien.Text = "Sinh viên";
            // 
            // tke_lop
            // 
            this.tke_lop.Name = "tke_lop";
            this.tke_lop.Size = new System.Drawing.Size(270, 34);
            this.tke_lop.Text = "Lớp";
            // 
            // tke_hososinhvien
            // 
            this.tke_hososinhvien.Name = "tke_hososinhvien";
            this.tke_hososinhvien.Size = new System.Drawing.Size(270, 34);
            this.tke_hososinhvien.Text = "Hồ sơ sinh viên";
            // 
            // tke_hoadon
            // 
            this.tke_hoadon.Name = "tke_hoadon";
            this.tke_hoadon.Size = new System.Drawing.Size(270, 34);
            this.tke_hoadon.Text = "Hóa đơn học phí";
            // 
            // tke_diemchuan
            // 
            this.tke_diemchuan.Name = "tke_diemchuan";
            this.tke_diemchuan.Size = new System.Drawing.Size(270, 34);
            this.tke_diemchuan.Text = "Điểm chuẩn";
            // 
            // tke_canbo
            // 
            this.tke_canbo.Name = "tke_canbo";
            this.tke_canbo.Size = new System.Drawing.Size(270, 34);
            this.tke_canbo.Text = "Cán bộ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1165, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chào mừng đến với hệ thống quản lý thông tin sinh viên";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = global::BTL_QUANLYSINHVIEN.Properties.Resources.mattroithieuruihanhtinhjpg1resize_6c46e;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 738);
            this.panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 905);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mns_main);
            this.MainMenuStrip = this.mns_main;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lí sinh viên";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mns_main.ResumeLayout(false);
            this.mns_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_main;
        private System.Windows.Forms.ToolStripMenuItem mnsi_quanly;
        private System.Windows.Forms.ToolStripMenuItem qli_khoa;
        private System.Windows.Forms.ToolStripMenuItem qli_nganh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsi_baocao;
        private System.Windows.Forms.ToolStripMenuItem qli_lop;
        private System.Windows.Forms.ToolStripMenuItem qli_sinhvien;
        private System.Windows.Forms.ToolStripMenuItem qli_hoso;
        private System.Windows.Forms.ToolStripMenuItem qli_hoadon;
        private System.Windows.Forms.ToolStripMenuItem qli_diem;
        private System.Windows.Forms.ToolStripMenuItem qli_canbo;
        private System.Windows.Forms.ToolStripMenuItem tke_sinhvien;
        private System.Windows.Forms.ToolStripMenuItem tke_nganh;
        private System.Windows.Forms.ToolStripMenuItem tke_lop;
        private System.Windows.Forms.ToolStripMenuItem tke_khoa;
        private System.Windows.Forms.ToolStripMenuItem tke_hososinhvien;
        private System.Windows.Forms.ToolStripMenuItem tke_hoadon;
        private System.Windows.Forms.ToolStripMenuItem tke_diemchuan;
        private System.Windows.Forms.ToolStripMenuItem tke_canbo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mns_trangchu;
    }
}

