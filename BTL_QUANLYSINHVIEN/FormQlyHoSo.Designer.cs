namespace BTL_QUANLYSINHVIEN
{
    partial class FormQlyHoSo
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
            this.tb_mahoso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_hokhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_namtotnghiep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_hotenbo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_hotenme = new System.Windows.Forms.TextBox();
            this.dtp_thu = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_gui = new System.Windows.Forms.DateTimePicker();
            this.cb_sbd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_canbo = new System.Windows.Forms.ComboBox();
            this.dgv_hoso = new System.Windows.Forms.DataGridView();
            this.sMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNamTotNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoTenBo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoTenme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dThoiGianThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dThoiGianGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_tiep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hồ sơ";
            // 
            // tb_mahoso
            // 
            this.tb_mahoso.Location = new System.Drawing.Point(203, 71);
            this.tb_mahoso.Name = "tb_mahoso";
            this.tb_mahoso.Size = new System.Drawing.Size(174, 26);
            this.tb_mahoso.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hộ khẩu";
            // 
            // tb_hokhau
            // 
            this.tb_hokhau.Location = new System.Drawing.Point(203, 120);
            this.tb_hokhau.Name = "tb_hokhau";
            this.tb_hokhau.Size = new System.Drawing.Size(174, 26);
            this.tb_hokhau.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm tốt nghiệp";
            // 
            // tb_namtotnghiep
            // 
            this.tb_namtotnghiep.Location = new System.Drawing.Point(203, 169);
            this.tb_namtotnghiep.Name = "tb_namtotnghiep";
            this.tb_namtotnghiep.Size = new System.Drawing.Size(174, 26);
            this.tb_namtotnghiep.TabIndex = 1;
            this.tb_namtotnghiep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_namtotnghiep_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ tên bố";
            // 
            // tb_hotenbo
            // 
            this.tb_hotenbo.Location = new System.Drawing.Point(203, 222);
            this.tb_hotenbo.Name = "tb_hotenbo";
            this.tb_hotenbo.Size = new System.Drawing.Size(174, 26);
            this.tb_hotenbo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ tên mẹ";
            // 
            // tb_hotenme
            // 
            this.tb_hotenme.Location = new System.Drawing.Point(203, 274);
            this.tb_hotenme.Name = "tb_hotenme";
            this.tb_hotenme.Size = new System.Drawing.Size(174, 26);
            this.tb_hotenme.TabIndex = 1;
            // 
            // dtp_thu
            // 
            this.dtp_thu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_thu.Location = new System.Drawing.Point(589, 71);
            this.dtp_thu.Name = "dtp_thu";
            this.dtp_thu.Size = new System.Drawing.Size(215, 26);
            this.dtp_thu.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thời gian thu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thời gian gửi";
            // 
            // dtp_gui
            // 
            this.dtp_gui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_gui.Location = new System.Drawing.Point(589, 117);
            this.dtp_gui.Name = "dtp_gui";
            this.dtp_gui.Size = new System.Drawing.Size(215, 26);
            this.dtp_gui.TabIndex = 2;
            // 
            // cb_sbd
            // 
            this.cb_sbd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sbd.FormattingEnabled = true;
            this.cb_sbd.Location = new System.Drawing.Point(589, 166);
            this.cb_sbd.Name = "cb_sbd";
            this.cb_sbd.Size = new System.Drawing.Size(215, 28);
            this.cb_sbd.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số báo danh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(480, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã cán bộ";
            // 
            // cb_canbo
            // 
            this.cb_canbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_canbo.FormattingEnabled = true;
            this.cb_canbo.Location = new System.Drawing.Point(589, 215);
            this.cb_canbo.Name = "cb_canbo";
            this.cb_canbo.Size = new System.Drawing.Size(215, 28);
            this.cb_canbo.TabIndex = 3;
            // 
            // dgv_hoso
            // 
            this.dgv_hoso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHS,
            this.sHoKhau,
            this.iNamTotNghiep,
            this.sHoTenBo,
            this.sHoTenme,
            this.dThoiGianThu,
            this.dThoiGianGui,
            this.sSoBD,
            this.sMaCB});
            this.dgv_hoso.Location = new System.Drawing.Point(62, 331);
            this.dgv_hoso.Name = "dgv_hoso";
            this.dgv_hoso.RowHeadersWidth = 62;
            this.dgv_hoso.RowTemplate.Height = 28;
            this.dgv_hoso.Size = new System.Drawing.Size(1416, 365);
            this.dgv_hoso.TabIndex = 4;
            this.dgv_hoso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoso_CellClick);
            // 
            // sMaHS
            // 
            this.sMaHS.DataPropertyName = "sMaHS";
            this.sMaHS.HeaderText = "Mã hồ sơ";
            this.sMaHS.MinimumWidth = 8;
            this.sMaHS.Name = "sMaHS";
            // 
            // sHoKhau
            // 
            this.sHoKhau.DataPropertyName = "sHoKhau";
            this.sHoKhau.HeaderText = "Hộ khẩu";
            this.sHoKhau.MinimumWidth = 8;
            this.sHoKhau.Name = "sHoKhau";
            // 
            // iNamTotNghiep
            // 
            this.iNamTotNghiep.DataPropertyName = "iNamTotNghiep";
            this.iNamTotNghiep.HeaderText = "Năm tốt nghiệp";
            this.iNamTotNghiep.MinimumWidth = 8;
            this.iNamTotNghiep.Name = "iNamTotNghiep";
            // 
            // sHoTenBo
            // 
            this.sHoTenBo.DataPropertyName = "sHoTenBo";
            this.sHoTenBo.HeaderText = "Họ tên bố";
            this.sHoTenBo.MinimumWidth = 8;
            this.sHoTenBo.Name = "sHoTenBo";
            // 
            // sHoTenme
            // 
            this.sHoTenme.DataPropertyName = "sHoTenMe";
            this.sHoTenme.HeaderText = "Họ tên mẹ";
            this.sHoTenme.MinimumWidth = 8;
            this.sHoTenme.Name = "sHoTenme";
            // 
            // dThoiGianThu
            // 
            this.dThoiGianThu.DataPropertyName = "dThoiGianThu";
            this.dThoiGianThu.HeaderText = "Thời gian thu";
            this.dThoiGianThu.MinimumWidth = 8;
            this.dThoiGianThu.Name = "dThoiGianThu";
            // 
            // dThoiGianGui
            // 
            this.dThoiGianGui.DataPropertyName = "dThoiGianGui";
            this.dThoiGianGui.HeaderText = "Thời gian gửi";
            this.dThoiGianGui.MinimumWidth = 8;
            this.dThoiGianGui.Name = "dThoiGianGui";
            // 
            // sSoBD
            // 
            this.sSoBD.DataPropertyName = "sSoBD";
            this.sSoBD.HeaderText = "Số báo danh";
            this.sSoBD.MinimumWidth = 8;
            this.sSoBD.Name = "sSoBD";
            // 
            // sMaCB
            // 
            this.sMaCB.DataPropertyName = "sMaCB";
            this.sMaCB.HeaderText = "Mã cán bộ";
            this.sMaCB.MinimumWidth = 8;
            this.sMaCB.Name = "sMaCB";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(899, 65);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 38);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(899, 120);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(110, 38);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.Location = new System.Drawing.Point(1015, 67);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(110, 38);
            this.btn_fix.TabIndex = 5;
            this.btn_fix.Text = "Cập nhật";
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(1015, 120);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(110, 38);
            this.btn_find.TabIndex = 5;
            this.btn_find.Text = "Tìm kiếm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_tiep
            // 
            this.btn_tiep.Location = new System.Drawing.Point(957, 169);
            this.btn_tiep.Name = "btn_tiep";
            this.btn_tiep.Size = new System.Drawing.Size(110, 38);
            this.btn_tiep.TabIndex = 5;
            this.btn_tiep.Text = "Tiếp tục";
            this.btn_tiep.UseVisualStyleBackColor = true;
            this.btn_tiep.Click += new System.EventHandler(this.btn_tiep_Click);
            // 
            // FormQlyHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 766);
            this.Controls.Add(this.btn_tiep);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_hoso);
            this.Controls.Add(this.cb_canbo);
            this.Controls.Add(this.cb_sbd);
            this.Controls.Add(this.dtp_gui);
            this.Controls.Add(this.dtp_thu);
            this.Controls.Add(this.tb_hotenme);
            this.Controls.Add(this.tb_hotenbo);
            this.Controls.Add(this.tb_namtotnghiep);
            this.Controls.Add(this.tb_hokhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_mahoso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "FormQlyHoSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí hồ sơ sinh viên";
            this.Load += new System.EventHandler(this.FormQlyHoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mahoso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_hokhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_namtotnghiep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_hotenbo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_hotenme;
        private System.Windows.Forms.DateTimePicker dtp_thu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_gui;
        private System.Windows.Forms.ComboBox cb_sbd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_canbo;
        private System.Windows.Forms.DataGridView dgv_hoso;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNamTotNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoTenBo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoTenme;
        private System.Windows.Forms.DataGridViewTextBoxColumn dThoiGianThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dThoiGianGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaCB;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_tiep;
    }
}