namespace BTL_QUANLYSINHVIEN
{
    partial class FormQlyDiemChuan
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
            this.cb_sbd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_nganh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_khoitohop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_diem1 = new System.Windows.Forms.TextBox();
            this.tb_diem2 = new System.Windows.Forms.TextBox();
            this.tb_diem3 = new System.Windows.Forms.TextBox();
            this.tb_diemuutien = new System.Windows.Forms.TextBox();
            this.dgv_diem = new System.Windows.Forms.DataGridView();
            this.sSoBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKhoiToHop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDiem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDiem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDiem3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDiemUuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_tiep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_sbd
            // 
            this.cb_sbd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sbd.FormattingEnabled = true;
            this.cb_sbd.Location = new System.Drawing.Point(275, 52);
            this.cb_sbd.Name = "cb_sbd";
            this.cb_sbd.Size = new System.Drawing.Size(166, 28);
            this.cb_sbd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số báo danh";
            // 
            // cb_nganh
            // 
            this.cb_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nganh.FormattingEnabled = true;
            this.cb_nganh.Location = new System.Drawing.Point(275, 102);
            this.cb_nganh.Name = "cb_nganh";
            this.cb_nganh.Size = new System.Drawing.Size(166, 28);
            this.cb_nganh.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khối tổ hợp";
            // 
            // tb_khoitohop
            // 
            this.tb_khoitohop.Location = new System.Drawing.Point(275, 152);
            this.tb_khoitohop.Name = "tb_khoitohop";
            this.tb_khoitohop.Size = new System.Drawing.Size(166, 26);
            this.tb_khoitohop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Điểm môn 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Điểm môn 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Điểm môn 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(584, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Điểm ưu tiên";
            // 
            // tb_diem1
            // 
            this.tb_diem1.Location = new System.Drawing.Point(689, 55);
            this.tb_diem1.Name = "tb_diem1";
            this.tb_diem1.Size = new System.Drawing.Size(69, 26);
            this.tb_diem1.TabIndex = 2;
            this.tb_diem1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_diem1_KeyPress);
            // 
            // tb_diem2
            // 
            this.tb_diem2.Location = new System.Drawing.Point(689, 102);
            this.tb_diem2.Name = "tb_diem2";
            this.tb_diem2.Size = new System.Drawing.Size(69, 26);
            this.tb_diem2.TabIndex = 2;
            this.tb_diem2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_diem2_KeyPress);
            // 
            // tb_diem3
            // 
            this.tb_diem3.Location = new System.Drawing.Point(689, 152);
            this.tb_diem3.Name = "tb_diem3";
            this.tb_diem3.Size = new System.Drawing.Size(69, 26);
            this.tb_diem3.TabIndex = 2;
            this.tb_diem3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_diem3_KeyPress);
            // 
            // tb_diemuutien
            // 
            this.tb_diemuutien.Location = new System.Drawing.Point(689, 192);
            this.tb_diemuutien.Name = "tb_diemuutien";
            this.tb_diemuutien.Size = new System.Drawing.Size(69, 26);
            this.tb_diemuutien.TabIndex = 2;
            this.tb_diemuutien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_diemuutien_KeyPress);
            // 
            // dgv_diem
            // 
            this.dgv_diem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_diem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSoBD,
            this.sMaNganh,
            this.sKhoiToHop,
            this.fDiem1,
            this.fDiem2,
            this.fDiem3,
            this.fDiemUuTien});
            this.dgv_diem.Location = new System.Drawing.Point(58, 286);
            this.dgv_diem.Name = "dgv_diem";
            this.dgv_diem.RowHeadersWidth = 62;
            this.dgv_diem.RowTemplate.Height = 28;
            this.dgv_diem.Size = new System.Drawing.Size(1117, 306);
            this.dgv_diem.TabIndex = 3;
            this.dgv_diem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_diem_CellClick);
            // 
            // sSoBD
            // 
            this.sSoBD.DataPropertyName = "sSoBD";
            this.sSoBD.HeaderText = "Số báo danh";
            this.sSoBD.MinimumWidth = 8;
            this.sSoBD.Name = "sSoBD";
            // 
            // sMaNganh
            // 
            this.sMaNganh.DataPropertyName = "sMaNganh";
            this.sMaNganh.HeaderText = "Mã ngành";
            this.sMaNganh.MinimumWidth = 8;
            this.sMaNganh.Name = "sMaNganh";
            // 
            // sKhoiToHop
            // 
            this.sKhoiToHop.DataPropertyName = "sKhoiToHop";
            this.sKhoiToHop.HeaderText = "Khối tổ hợp";
            this.sKhoiToHop.MinimumWidth = 8;
            this.sKhoiToHop.Name = "sKhoiToHop";
            // 
            // fDiem1
            // 
            this.fDiem1.DataPropertyName = "fDiem1";
            this.fDiem1.HeaderText = "Điểm môn thứ 1";
            this.fDiem1.MinimumWidth = 8;
            this.fDiem1.Name = "fDiem1";
            // 
            // fDiem2
            // 
            this.fDiem2.DataPropertyName = "fDiem2";
            this.fDiem2.HeaderText = "Điểm môn thứ 2";
            this.fDiem2.MinimumWidth = 8;
            this.fDiem2.Name = "fDiem2";
            // 
            // fDiem3
            // 
            this.fDiem3.DataPropertyName = "fDiem3";
            this.fDiem3.HeaderText = "Điểm môn thứ 3";
            this.fDiem3.MinimumWidth = 8;
            this.fDiem3.Name = "fDiem3";
            // 
            // fDiemUuTien
            // 
            this.fDiemUuTien.DataPropertyName = "fDiemUuTien";
            this.fDiemUuTien.HeaderText = "Điểm ưu tiên";
            this.fDiemUuTien.MinimumWidth = 8;
            this.fDiemUuTien.Name = "fDiemUuTien";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(824, 47);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 37);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(824, 97);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 37);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.Location = new System.Drawing.Point(930, 47);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(100, 37);
            this.btn_fix.TabIndex = 4;
            this.btn_fix.Text = "Cập nhật";
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(930, 97);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(100, 37);
            this.btn_find.TabIndex = 4;
            this.btn_find.Text = "Tìm kiếm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_tiep
            // 
            this.btn_tiep.Location = new System.Drawing.Point(877, 144);
            this.btn_tiep.Name = "btn_tiep";
            this.btn_tiep.Size = new System.Drawing.Size(100, 37);
            this.btn_tiep.TabIndex = 4;
            this.btn_tiep.Text = "Tiếp tục";
            this.btn_tiep.UseVisualStyleBackColor = true;
            this.btn_tiep.Click += new System.EventHandler(this.btn_tiep_Click);
            // 
            // FormQlyDiemChuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 677);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_tiep);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_diem);
            this.Controls.Add(this.tb_diemuutien);
            this.Controls.Add(this.tb_diem3);
            this.Controls.Add(this.tb_diem2);
            this.Controls.Add(this.tb_diem1);
            this.Controls.Add(this.tb_khoitohop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_nganh);
            this.Controls.Add(this.cb_sbd);
            this.Name = "FormQlyDiemChuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm đầu vào";
            this.Load += new System.EventHandler(this.FormQlyDiemChuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_diem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_sbd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_khoitohop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_diem1;
        private System.Windows.Forms.TextBox tb_diem2;
        private System.Windows.Forms.TextBox tb_diem3;
        private System.Windows.Forms.TextBox tb_diemuutien;
        private System.Windows.Forms.DataGridView dgv_diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKhoiToHop;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDiem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDiem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDiem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDiemUuTien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_tiep;
        private System.Windows.Forms.Button btn_find;
    }
}