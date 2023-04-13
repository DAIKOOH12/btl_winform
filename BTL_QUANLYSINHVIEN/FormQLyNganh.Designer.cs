namespace BTL_QUANLYSINHVIEN
{
    partial class FormQLyNganh
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
            this.lb_manganh = new System.Windows.Forms.Label();
            this.tb_manganh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_tennganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_khoa = new System.Windows.Forms.ComboBox();
            this.dgv_nganh = new System.Windows.Forms.DataGridView();
            this.sMaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_fix = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_manganh
            // 
            this.lb_manganh.AutoSize = true;
            this.lb_manganh.Location = new System.Drawing.Point(255, 139);
            this.lb_manganh.Name = "lb_manganh";
            this.lb_manganh.Size = new System.Drawing.Size(80, 20);
            this.lb_manganh.TabIndex = 0;
            this.lb_manganh.Text = "Mã ngành";
            // 
            // tb_manganh
            // 
            this.tb_manganh.Location = new System.Drawing.Point(341, 139);
            this.tb_manganh.Name = "tb_manganh";
            this.tb_manganh.Size = new System.Drawing.Size(199, 26);
            this.tb_manganh.TabIndex = 1;
            this.tb_manganh.TextChanged += new System.EventHandler(this.tb_manganh_TextChanged);
            this.tb_manganh.Validating += new System.ComponentModel.CancelEventHandler(this.tb_manganh_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên ngành";
            // 
            // tb_tennganh
            // 
            this.tb_tennganh.Location = new System.Drawing.Point(341, 188);
            this.tb_tennganh.Name = "tb_tennganh";
            this.tb_tennganh.Size = new System.Drawing.Size(199, 26);
            this.tb_tennganh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khoa";
            // 
            // cb_khoa
            // 
            this.cb_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_khoa.FormattingEnabled = true;
            this.cb_khoa.Location = new System.Drawing.Point(341, 238);
            this.cb_khoa.Name = "cb_khoa";
            this.cb_khoa.Size = new System.Drawing.Size(197, 28);
            this.cb_khoa.TabIndex = 2;
            // 
            // dgv_nganh
            // 
            this.dgv_nganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaNganh,
            this.sTenNganh,
            this.sMaKhoa});
            this.dgv_nganh.Location = new System.Drawing.Point(230, 292);
            this.dgv_nganh.Name = "dgv_nganh";
            this.dgv_nganh.RowHeadersWidth = 62;
            this.dgv_nganh.RowTemplate.Height = 28;
            this.dgv_nganh.Size = new System.Drawing.Size(792, 292);
            this.dgv_nganh.TabIndex = 3;
            this.dgv_nganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nganh_CellClick);
            // 
            // sMaNganh
            // 
            this.sMaNganh.DataPropertyName = "sMaNganh";
            this.sMaNganh.HeaderText = "Mã ngành";
            this.sMaNganh.MinimumWidth = 8;
            this.sMaNganh.Name = "sMaNganh";
            // 
            // sTenNganh
            // 
            this.sTenNganh.DataPropertyName = "sTenNganh";
            this.sTenNganh.HeaderText = "Tên Ngành";
            this.sTenNganh.MinimumWidth = 8;
            this.sTenNganh.Name = "sTenNganh";
            // 
            // sMaKhoa
            // 
            this.sMaKhoa.DataPropertyName = "sMaKhoa";
            this.sMaKhoa.HeaderText = "Mã khoa";
            this.sMaKhoa.MinimumWidth = 8;
            this.sMaKhoa.Name = "sMaKhoa";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(600, 138);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 37);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(600, 188);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(101, 37);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_fix
            // 
            this.btn_fix.Location = new System.Drawing.Point(707, 139);
            this.btn_fix.Name = "btn_fix";
            this.btn_fix.Size = new System.Drawing.Size(101, 37);
            this.btn_fix.TabIndex = 4;
            this.btn_fix.Text = "Cập nhật";
            this.btn_fix.UseVisualStyleBackColor = true;
            this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(707, 188);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(101, 37);
            this.btn_find.TabIndex = 4;
            this.btn_find.Text = "Tìm kiếm";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // FormQLyNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 659);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_fix);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_nganh);
            this.Controls.Add(this.cb_khoa);
            this.Controls.Add(this.tb_tennganh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_manganh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_manganh);
            this.Name = "FormQLyNganh";
            this.Text = "FormQLyNganh";
            this.Load += new System.EventHandler(this.FormQLyNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_manganh;
        private System.Windows.Forms.TextBox tb_manganh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tennganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_khoa;
        private System.Windows.Forms.DataGridView dgv_nganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKhoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_fix;
        private System.Windows.Forms.Button btn_find;
    }
}