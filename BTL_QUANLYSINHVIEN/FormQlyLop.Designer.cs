namespace BTL_QUANLYSINHVIEN
{
    partial class FormQlyLop
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
            this.tb_tenlop = new System.Windows.Forms.TextBox();
            this.tb_malop = new System.Windows.Forms.TextBox();
            this.cb_nganh = new System.Windows.Forms.ComboBox();
            this.dgv_lop = new System.Windows.Forms.DataGridView();
            this.sMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã ngành";
            // 
            // tb_tenlop
            // 
            this.tb_tenlop.Location = new System.Drawing.Point(488, 172);
            this.tb_tenlop.Name = "tb_tenlop";
            this.tb_tenlop.Size = new System.Drawing.Size(144, 26);
            this.tb_tenlop.TabIndex = 1;
            // 
            // tb_malop
            // 
            this.tb_malop.Location = new System.Drawing.Point(488, 132);
            this.tb_malop.Name = "tb_malop";
            this.tb_malop.Size = new System.Drawing.Size(144, 26);
            this.tb_malop.TabIndex = 1;
            this.tb_malop.TextChanged += new System.EventHandler(this.tb_malop_TextChanged);
            this.tb_malop.Validating += new System.ComponentModel.CancelEventHandler(this.tb_malop_Validating);
            // 
            // cb_nganh
            // 
            this.cb_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nganh.FormattingEnabled = true;
            this.cb_nganh.Location = new System.Drawing.Point(488, 210);
            this.cb_nganh.Name = "cb_nganh";
            this.cb_nganh.Size = new System.Drawing.Size(144, 28);
            this.cb_nganh.TabIndex = 2;
            // 
            // dgv_lop
            // 
            this.dgv_lop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaLop,
            this.sTenLop,
            this.sMaNganh});
            this.dgv_lop.Location = new System.Drawing.Point(246, 301);
            this.dgv_lop.Name = "dgv_lop";
            this.dgv_lop.RowHeadersWidth = 62;
            this.dgv_lop.RowTemplate.Height = 28;
            this.dgv_lop.Size = new System.Drawing.Size(878, 333);
            this.dgv_lop.TabIndex = 3;
            this.dgv_lop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lop_CellClick);
            // 
            // sMaLop
            // 
            this.sMaLop.DataPropertyName = "sMaLop";
            this.sMaLop.HeaderText = "Mã lớp";
            this.sMaLop.MinimumWidth = 8;
            this.sMaLop.Name = "sMaLop";
            // 
            // sTenLop
            // 
            this.sTenLop.DataPropertyName = "sTenLop";
            this.sTenLop.HeaderText = "Tên lớp";
            this.sTenLop.MinimumWidth = 8;
            this.sTenLop.Name = "sTenLop";
            // 
            // sMaNganh
            // 
            this.sMaNganh.DataPropertyName = "sMaNganh";
            this.sMaNganh.HeaderText = "Mã ngành";
            this.sMaNganh.MinimumWidth = 8;
            this.sMaNganh.Name = "sMaNganh";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(704, 132);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 34);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Thêm mới";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(704, 172);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(101, 34);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // FormQlyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 646);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_lop);
            this.Controls.Add(this.cb_nganh);
            this.Controls.Add(this.tb_malop);
            this.Controls.Add(this.tb_tenlop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQlyLop";
            this.Text = "FormQlyLop";
            this.Load += new System.EventHandler(this.FormQlyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tenlop;
        private System.Windows.Forms.TextBox tb_malop;
        private System.Windows.Forms.ComboBox cb_nganh;
        private System.Windows.Forms.DataGridView dgv_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaNganh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_xoa;
    }
}