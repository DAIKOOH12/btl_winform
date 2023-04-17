namespace BTL_QUANLYSINHVIEN
{
    partial class FormQlyCanBo
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
            this.tb_macb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tencb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_nganh = new System.Windows.Forms.ComboBox();
            this.dgv_canbo = new System.Windows.Forms.DataGridView();
            this.sMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_tiep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_canbo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã cán bộ";
            // 
            // tb_macb
            // 
            this.tb_macb.Location = new System.Drawing.Point(218, 76);
            this.tb_macb.Name = "tb_macb";
            this.tb_macb.Size = new System.Drawing.Size(190, 26);
            this.tb_macb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên cán bộ";
            // 
            // tb_tencb
            // 
            this.tb_tencb.Location = new System.Drawing.Point(218, 128);
            this.tb_tencb.Name = "tb_tencb";
            this.tb_tencb.Size = new System.Drawing.Size(190, 26);
            this.tb_tencb.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(218, 175);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(190, 26);
            this.tb_sdt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã ngành";
            // 
            // cb_nganh
            // 
            this.cb_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nganh.FormattingEnabled = true;
            this.cb_nganh.Location = new System.Drawing.Point(218, 219);
            this.cb_nganh.Name = "cb_nganh";
            this.cb_nganh.Size = new System.Drawing.Size(190, 28);
            this.cb_nganh.TabIndex = 2;
            // 
            // dgv_canbo
            // 
            this.dgv_canbo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_canbo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_canbo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaCB,
            this.sTenCB,
            this.sSDT,
            this.sMaNganh});
            this.dgv_canbo.Location = new System.Drawing.Point(119, 282);
            this.dgv_canbo.Name = "dgv_canbo";
            this.dgv_canbo.RowHeadersWidth = 62;
            this.dgv_canbo.RowTemplate.Height = 28;
            this.dgv_canbo.Size = new System.Drawing.Size(975, 317);
            this.dgv_canbo.TabIndex = 3;
            this.dgv_canbo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_canbo_CellClick);
            // 
            // sMaCB
            // 
            this.sMaCB.DataPropertyName = "sMaCB";
            this.sMaCB.HeaderText = "Mã cán bộ";
            this.sMaCB.MinimumWidth = 8;
            this.sMaCB.Name = "sMaCB";
            // 
            // sTenCB
            // 
            this.sTenCB.DataPropertyName = "sTenCB";
            this.sTenCB.HeaderText = "Tên cán bộ";
            this.sTenCB.MinimumWidth = 8;
            this.sTenCB.Name = "sTenCB";
            // 
            // sSDT
            // 
            this.sSDT.DataPropertyName = "sSDT";
            this.sSDT.HeaderText = "Số điện thoại";
            this.sSDT.MinimumWidth = 8;
            this.sSDT.Name = "sSDT";
            // 
            // sMaNganh
            // 
            this.sMaNganh.DataPropertyName = "sMaNganh";
            this.sMaNganh.HeaderText = "Mã ngành";
            this.sMaNganh.MinimumWidth = 8;
            this.sMaNganh.Name = "sMaNganh";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(556, 69);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 40);
            this.btn_add.TabIndex = 4;
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
            this.btn_xoa.Location = new System.Drawing.Point(556, 128);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(110, 40);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.Location = new System.Drawing.Point(672, 69);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(110, 40);
            this.btn_fix.TabIndex = 4;
            this.btn_fix.Text = "Cập nhật";
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(672, 128);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(110, 40);
            this.btn_find.TabIndex = 4;
            this.btn_find.Text = "Tìm kiếm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_tiep
            // 
            this.btn_tiep.Location = new System.Drawing.Point(616, 175);
            this.btn_tiep.Name = "btn_tiep";
            this.btn_tiep.Size = new System.Drawing.Size(110, 40);
            this.btn_tiep.TabIndex = 4;
            this.btn_tiep.Text = "Tiếp tục";
            this.btn_tiep.UseVisualStyleBackColor = true;
            this.btn_tiep.Click += new System.EventHandler(this.btn_tiep_Click);
            // 
            // FormQlyCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 702);
            this.Controls.Add(this.btn_tiep);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_canbo);
            this.Controls.Add(this.cb_nganh);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_tencb);
            this.Controls.Add(this.tb_macb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQlyCanBo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cán bộ";
            this.Load += new System.EventHandler(this.FormQlyCanBo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_canbo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_macb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tencb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_nganh;
        private System.Windows.Forms.DataGridView dgv_canbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNganh;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_tiep;
    }
}