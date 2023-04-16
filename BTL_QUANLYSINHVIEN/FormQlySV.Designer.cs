namespace BTL_QUANLYSINHVIEN
{
    partial class FormQlySV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_sbd = new System.Windows.Forms.TextBox();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.tb_cmnd = new System.Windows.Forms.TextBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_tongiao = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_quequan = new System.Windows.Forms.TextBox();
            this.tb_truong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rd_nam = new System.Windows.Forms.RadioButton();
            this.rd_nu = new System.Windows.Forms.RadioButton();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgv_sinhvien = new System.Windows.Forms.DataGridView();
            this.sSoBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTonGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTruongTotNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sQueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_tiep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số báo danh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số CMND";
            // 
            // tb_sbd
            // 
            this.tb_sbd.Location = new System.Drawing.Point(239, 73);
            this.tb_sbd.Name = "tb_sbd";
            this.tb_sbd.Size = new System.Drawing.Size(200, 26);
            this.tb_sbd.TabIndex = 1;
            this.tb_sbd.Validating += new System.ComponentModel.CancelEventHandler(this.tb_sbd_Validating);
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(239, 121);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(200, 26);
            this.tb_hoten.TabIndex = 1;
            // 
            // tb_cmnd
            // 
            this.tb_cmnd.Location = new System.Drawing.Point(239, 206);
            this.tb_cmnd.Name = "tb_cmnd";
            this.tb_cmnd.Size = new System.Drawing.Size(200, 26);
            this.tb_cmnd.TabIndex = 1;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(239, 163);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 26);
            this.dtp_ngaysinh.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tôn giáo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trường tốt nghiệp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(597, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quê quán";
            // 
            // tb_tongiao
            // 
            this.tb_tongiao.Location = new System.Drawing.Point(737, 76);
            this.tb_tongiao.Name = "tb_tongiao";
            this.tb_tongiao.Size = new System.Drawing.Size(200, 26);
            this.tb_tongiao.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(737, 121);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(200, 26);
            this.tb_email.TabIndex = 1;
            // 
            // tb_quequan
            // 
            this.tb_quequan.Location = new System.Drawing.Point(737, 203);
            this.tb_quequan.Name = "tb_quequan";
            this.tb_quequan.Size = new System.Drawing.Size(200, 26);
            this.tb_quequan.TabIndex = 1;
            // 
            // tb_truong
            // 
            this.tb_truong.Location = new System.Drawing.Point(737, 160);
            this.tb_truong.Name = "tb_truong";
            this.tb_truong.Size = new System.Drawing.Size(200, 26);
            this.tb_truong.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giới tính";
            // 
            // rd_nam
            // 
            this.rd_nam.AutoSize = true;
            this.rd_nam.Location = new System.Drawing.Point(239, 253);
            this.rd_nam.Name = "rd_nam";
            this.rd_nam.Size = new System.Drawing.Size(67, 24);
            this.rd_nam.TabIndex = 3;
            this.rd_nam.TabStop = true;
            this.rd_nam.Text = "Nam";
            this.rd_nam.UseVisualStyleBackColor = true;
            // 
            // rd_nu
            // 
            this.rd_nu.AutoSize = true;
            this.rd_nu.Location = new System.Drawing.Point(312, 253);
            this.rd_nu.Name = "rd_nu";
            this.rd_nu.Size = new System.Drawing.Size(54, 24);
            this.rd_nu.TabIndex = 3;
            this.rd_nu.TabStop = true;
            this.rd_nu.Text = "Nữ";
            this.rd_nu.UseVisualStyleBackColor = true;
            // 
            // cb_lop
            // 
            this.cb_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(737, 248);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(200, 28);
            this.cb_lop.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(597, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã lớp";
            // 
            // dgv_sinhvien
            // 
            this.dgv_sinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_sinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSoBD,
            this.sHoTen,
            this.dNgaySinh,
            this.sCMND,
            this.sTonGiao,
            this.sEmail,
            this.sTruongTotNghiep,
            this.sQueQuan,
            this.sGioiTinh,
            this.sMaLop});
            this.dgv_sinhvien.Location = new System.Drawing.Point(37, 335);
            this.dgv_sinhvien.Name = "dgv_sinhvien";
            this.dgv_sinhvien.RowHeadersWidth = 62;
            this.dgv_sinhvien.RowTemplate.Height = 28;
            this.dgv_sinhvien.Size = new System.Drawing.Size(1381, 378);
            this.dgv_sinhvien.TabIndex = 5;
            this.dgv_sinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sinhvien_CellClick);
            // 
            // sSoBD
            // 
            this.sSoBD.DataPropertyName = "sSoBD";
            this.sSoBD.HeaderText = "Số báo danh";
            this.sSoBD.MinimumWidth = 8;
            this.sSoBD.Name = "sSoBD";
            this.sSoBD.Width = 126;
            // 
            // sHoTen
            // 
            this.sHoTen.DataPropertyName = "sHoTen";
            this.sHoTen.HeaderText = "Họ tên";
            this.sHoTen.MinimumWidth = 8;
            this.sHoTen.Name = "sHoTen";
            this.sHoTen.Width = 87;
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.DataPropertyName = "dNgaySinh";
            this.dNgaySinh.HeaderText = "Ngày sinh";
            this.dNgaySinh.MinimumWidth = 8;
            this.dNgaySinh.Name = "dNgaySinh";
            this.dNgaySinh.Width = 106;
            // 
            // sCMND
            // 
            this.sCMND.DataPropertyName = "sCMND";
            this.sCMND.HeaderText = "Chứng minh nhân dân";
            this.sCMND.MinimumWidth = 8;
            this.sCMND.Name = "sCMND";
            this.sCMND.Width = 160;
            // 
            // sTonGiao
            // 
            this.sTonGiao.DataPropertyName = "sTonGiao";
            this.sTonGiao.HeaderText = "Tôn giáo";
            this.sTonGiao.MinimumWidth = 8;
            this.sTonGiao.Name = "sTonGiao";
            this.sTonGiao.Width = 99;
            // 
            // sEmail
            // 
            this.sEmail.DataPropertyName = "sEmail";
            this.sEmail.HeaderText = "Email";
            this.sEmail.MinimumWidth = 8;
            this.sEmail.Name = "sEmail";
            this.sEmail.Width = 84;
            // 
            // sTruongTotNghiep
            // 
            this.sTruongTotNghiep.DataPropertyName = "sTruongTotNghiep";
            this.sTruongTotNghiep.HeaderText = "Trường tốt nghiệp";
            this.sTruongTotNghiep.MinimumWidth = 8;
            this.sTruongTotNghiep.Name = "sTruongTotNghiep";
            this.sTruongTotNghiep.Width = 156;
            // 
            // sQueQuan
            // 
            this.sQueQuan.DataPropertyName = "sQueQuan";
            this.sQueQuan.HeaderText = "Quê quán";
            this.sQueQuan.MinimumWidth = 8;
            this.sQueQuan.Name = "sQueQuan";
            this.sQueQuan.Width = 107;
            // 
            // sGioiTinh
            // 
            this.sGioiTinh.DataPropertyName = "sGioiTinh";
            this.sGioiTinh.HeaderText = "Giới tính";
            this.sGioiTinh.MinimumWidth = 8;
            this.sGioiTinh.Name = "sGioiTinh";
            this.sGioiTinh.Width = 96;
            // 
            // sMaLop
            // 
            this.sMaLop.DataPropertyName = "sMaLop";
            this.sMaLop.HeaderText = "Lớp học";
            this.sMaLop.MinimumWidth = 8;
            this.sMaLop.Name = "sMaLop";
            this.sMaLop.Width = 72;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1008, 76);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 43);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(1008, 137);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(103, 46);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.Location = new System.Drawing.Point(1117, 76);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(105, 43);
            this.btn_fix.TabIndex = 6;
            this.btn_fix.Text = "Cập nhật";
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(1117, 137);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(105, 43);
            this.btn_find.TabIndex = 6;
            this.btn_find.Text = "Tìm kiếm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_tiep
            // 
            this.btn_tiep.Location = new System.Drawing.Point(1062, 195);
            this.btn_tiep.Name = "btn_tiep";
            this.btn_tiep.Size = new System.Drawing.Size(105, 43);
            this.btn_tiep.TabIndex = 6;
            this.btn_tiep.Text = "Tiếp tục";
            this.btn_tiep.UseVisualStyleBackColor = true;
            this.btn_tiep.Click += new System.EventHandler(this.btn_tiep_Click);
            // 
            // FormQlySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 777);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_tiep);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_sinhvien);
            this.Controls.Add(this.cb_lop);
            this.Controls.Add(this.rd_nu);
            this.Controls.Add(this.rd_nam);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.tb_quequan);
            this.Controls.Add(this.tb_cmnd);
            this.Controls.Add(this.tb_truong);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_hoten);
            this.Controls.Add(this.tb_tongiao);
            this.Controls.Add(this.tb_sbd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "FormQlySV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí sinh viên";
            this.Load += new System.EventHandler(this.FormQlySV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_sbd;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.TextBox tb_cmnd;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_tongiao;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_quequan;
        private System.Windows.Forms.TextBox tb_truong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rd_nam;
        private System.Windows.Forms.RadioButton rd_nu;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_sinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTonGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTruongTotNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLop;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_tiep;
    }
}