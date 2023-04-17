namespace BTL_QUANLYSINHVIEN
{
    partial class FormSuaThongTinCB
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
            this.cb_nganh = new System.Windows.Forms.ComboBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_tencb = new System.Windows.Forms.TextBox();
            this.tb_macb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_nganh
            // 
            this.cb_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nganh.FormattingEnabled = true;
            this.cb_nganh.Location = new System.Drawing.Point(470, 237);
            this.cb_nganh.Name = "cb_nganh";
            this.cb_nganh.Size = new System.Drawing.Size(190, 28);
            this.cb_nganh.TabIndex = 10;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(470, 193);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(190, 26);
            this.tb_sdt.TabIndex = 7;
            // 
            // tb_tencb
            // 
            this.tb_tencb.Location = new System.Drawing.Point(470, 146);
            this.tb_tencb.Name = "tb_tencb";
            this.tb_tencb.Size = new System.Drawing.Size(190, 26);
            this.tb_tencb.TabIndex = 8;
            // 
            // tb_macb
            // 
            this.tb_macb.Enabled = false;
            this.tb_macb.Location = new System.Drawing.Point(470, 94);
            this.tb_macb.Name = "tb_macb";
            this.tb_macb.Size = new System.Drawing.Size(190, 26);
            this.tb_macb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên cán bộ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã cán bộ";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(361, 311);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 40);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Cập nhật";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(528, 311);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(108, 40);
            this.btn_huy.TabIndex = 11;
            this.btn_huy.Text = "Hủy bỏ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // FormSuaThongTinCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 645);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_nganh);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_tencb);
            this.Controls.Add(this.tb_macb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaThongTinCB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSuaThongTinCB";
            this.Load += new System.EventHandler(this.FormSuaThongTinCB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_nganh;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_tencb;
        private System.Windows.Forms.TextBox tb_macb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_huy;
    }
}