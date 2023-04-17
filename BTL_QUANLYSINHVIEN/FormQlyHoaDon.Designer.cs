namespace BTL_QUANLYSINHVIEN
{
    partial class FormQlyHoaDon
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
            this.btn_tiep = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_sbd = new System.Windows.Forms.ComboBox();
            this.tb_tien = new System.Windows.Forms.TextBox();
            this.tb_mahoadon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.sMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSoBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tiep
            // 
            this.btn_tiep.Location = new System.Drawing.Point(727, 216);
            this.btn_tiep.Name = "btn_tiep";
            this.btn_tiep.Size = new System.Drawing.Size(110, 38);
            this.btn_tiep.TabIndex = 12;
            this.btn_tiep.Text = "Tiếp tục";
            this.btn_tiep.UseVisualStyleBackColor = true;
            this.btn_tiep.Click += new System.EventHandler(this.btn_tiep_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(785, 167);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(110, 38);
            this.btn_find.TabIndex = 13;
            this.btn_find.Text = "Tìm kiếm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(669, 167);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(110, 38);
            this.btn_xoa.TabIndex = 14;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.Location = new System.Drawing.Point(785, 114);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(110, 38);
            this.btn_fix.TabIndex = 15;
            this.btn_fix.Text = "Cập nhật";
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(669, 112);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 38);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_sbd
            // 
            this.cb_sbd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sbd.FormattingEnabled = true;
            this.cb_sbd.Location = new System.Drawing.Point(298, 223);
            this.cb_sbd.Name = "cb_sbd";
            this.cb_sbd.Size = new System.Drawing.Size(174, 28);
            this.cb_sbd.TabIndex = 11;
            // 
            // tb_tien
            // 
            this.tb_tien.Location = new System.Drawing.Point(298, 167);
            this.tb_tien.Name = "tb_tien";
            this.tb_tien.Size = new System.Drawing.Size(174, 26);
            this.tb_tien.TabIndex = 9;
            this.tb_tien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tien_KeyPress);
            // 
            // tb_mahoadon
            // 
            this.tb_mahoadon.Location = new System.Drawing.Point(298, 118);
            this.tb_mahoadon.Name = "tb_mahoadon";
            this.tb_mahoadon.Size = new System.Drawing.Size(174, 26);
            this.tb_mahoadon.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số báo danh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã hóa đơn";
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaHD,
            this.fTongTien,
            this.sSoBD});
            this.dgv_hoadon.Location = new System.Drawing.Point(133, 299);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowHeadersWidth = 62;
            this.dgv_hoadon.RowTemplate.Height = 28;
            this.dgv_hoadon.Size = new System.Drawing.Size(847, 329);
            this.dgv_hoadon.TabIndex = 18;
            this.dgv_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellClick);
            // 
            // sMaHD
            // 
            this.sMaHD.DataPropertyName = "sMaHD";
            this.sMaHD.HeaderText = "Mã hóa đơn";
            this.sMaHD.MinimumWidth = 8;
            this.sMaHD.Name = "sMaHD";
            // 
            // fTongTien
            // 
            this.fTongTien.DataPropertyName = "fTongTien";
            this.fTongTien.HeaderText = "Tiền đã đóng";
            this.fTongTien.MinimumWidth = 8;
            this.fTongTien.Name = "fTongTien";
            // 
            // sSoBD
            // 
            this.sSoBD.DataPropertyName = "sSoBD";
            this.sSoBD.HeaderText = "Số báo danh";
            this.sSoBD.MinimumWidth = 8;
            this.sSoBD.Name = "sSoBD";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormQlyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 705);
            this.Controls.Add(this.dgv_hoadon);
            this.Controls.Add(this.btn_tiep);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_sbd);
            this.Controls.Add(this.tb_tien);
            this.Controls.Add(this.tb_mahoadon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "FormQlyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQlyHoaDon";
            this.Load += new System.EventHandler(this.FormQlyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tiep;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_sbd;
        private System.Windows.Forms.TextBox tb_tien;
        private System.Windows.Forms.TextBox tb_mahoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn fTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSoBD;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}