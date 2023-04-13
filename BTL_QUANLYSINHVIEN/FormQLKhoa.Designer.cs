namespace BTL_QUANLYSINHVIEN
{
    partial class FormQLKhoa
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
            this.tb_makhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tenkhoa = new System.Windows.Forms.TextBox();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.dgv_khoa = new System.Windows.Forms.DataGridView();
            this.sMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_add = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa";
            // 
            // tb_makhoa
            // 
            this.tb_makhoa.Location = new System.Drawing.Point(437, 59);
            this.tb_makhoa.Name = "tb_makhoa";
            this.tb_makhoa.Size = new System.Drawing.Size(185, 26);
            this.tb_makhoa.TabIndex = 1;
            this.tb_makhoa.TextChanged += new System.EventHandler(this.tb_makhoa_TextChanged);
            this.tb_makhoa.Validating += new System.ComponentModel.CancelEventHandler(this.tb_makhoa_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // tb_tenkhoa
            // 
            this.tb_tenkhoa.Location = new System.Drawing.Point(437, 117);
            this.tb_tenkhoa.Name = "tb_tenkhoa";
            this.tb_tenkhoa.Size = new System.Drawing.Size(185, 26);
            this.tb_tenkhoa.TabIndex = 1;
            this.tb_tenkhoa.Validating += new System.ComponentModel.CancelEventHandler(this.tb_tenkhoa_Validating);
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(437, 167);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(185, 26);
            this.tb_diachi.TabIndex = 1;
            // 
            // dgv_khoa
            // 
            this.dgv_khoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaKhoa,
            this.sTenKhoa,
            this.sDiaChi});
            this.dgv_khoa.Location = new System.Drawing.Point(235, 278);
            this.dgv_khoa.Name = "dgv_khoa";
            this.dgv_khoa.RowHeadersWidth = 62;
            this.dgv_khoa.RowTemplate.Height = 28;
            this.dgv_khoa.Size = new System.Drawing.Size(806, 300);
            this.dgv_khoa.TabIndex = 2;
            this.dgv_khoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khoa_CellClick);
            // 
            // sMaKhoa
            // 
            this.sMaKhoa.DataPropertyName = "sMaKhoa";
            this.sMaKhoa.HeaderText = "Mã khoa";
            this.sMaKhoa.MinimumWidth = 8;
            this.sMaKhoa.Name = "sMaKhoa";
            this.sMaKhoa.ReadOnly = true;
            // 
            // sTenKhoa
            // 
            this.sTenKhoa.DataPropertyName = "sTenKhoa";
            this.sTenKhoa.HeaderText = "Tên khoa";
            this.sTenKhoa.MinimumWidth = 8;
            this.sTenKhoa.Name = "sTenKhoa";
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa chỉ";
            this.sDiaChi.MinimumWidth = 8;
            this.sDiaChi.Name = "sDiaChi";
            // 
            // bt_add
            // 
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_add.Location = new System.Drawing.Point(728, 73);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(91, 29);
            this.bt_add.TabIndex = 3;
            this.bt_add.Text = "Thêm mới";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_xoa.Location = new System.Drawing.Point(728, 108);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(91, 29);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_fix.Location = new System.Drawing.Point(728, 143);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(91, 29);
            this.btn_fix.TabIndex = 3;
            this.btn_fix.Text = "Cập nhật";
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // btn_find
            // 
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_find.Location = new System.Drawing.Point(728, 178);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(91, 29);
            this.btn_find.TabIndex = 3;
            this.btn_find.Text = "Tìm kiếm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // FormQLKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 590);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.dgv_khoa);
            this.Controls.Add(this.tb_diachi);
            this.Controls.Add(this.tb_tenkhoa);
            this.Controls.Add(this.tb_makhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQLKhoa";
            this.Text = "Quản lý Khoa";
            this.Load += new System.EventHandler(this.FormQLKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_makhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tenkhoa;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.DataGridView dgv_khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_find;
    }
}