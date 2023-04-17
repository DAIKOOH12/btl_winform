namespace BTL_QUANLYSINHVIEN
{
    partial class FormSuaThongTinHD
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
            this.cb_sbd = new System.Windows.Forms.ComboBox();
            this.tb_tien = new System.Windows.Forms.TextBox();
            this.tb_mahoadon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_sbd
            // 
            this.cb_sbd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sbd.FormattingEnabled = true;
            this.cb_sbd.Location = new System.Drawing.Point(505, 231);
            this.cb_sbd.Name = "cb_sbd";
            this.cb_sbd.Size = new System.Drawing.Size(174, 28);
            this.cb_sbd.TabIndex = 17;
            // 
            // tb_tien
            // 
            this.tb_tien.Location = new System.Drawing.Point(505, 175);
            this.tb_tien.Name = "tb_tien";
            this.tb_tien.Size = new System.Drawing.Size(174, 26);
            this.tb_tien.TabIndex = 15;
            // 
            // tb_mahoadon
            // 
            this.tb_mahoadon.Enabled = false;
            this.tb_mahoadon.Location = new System.Drawing.Point(505, 126);
            this.tb_mahoadon.Name = "tb_mahoadon";
            this.tb_mahoadon.Size = new System.Drawing.Size(174, 26);
            this.tb_mahoadon.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tổng tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số báo danh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(358, 330);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(102, 53);
            this.btn_capnhat.TabIndex = 18;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(562, 330);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(102, 53);
            this.btn_huy.TabIndex = 18;
            this.btn_huy.Text = "Hủy bỏ";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // FormSuaThongTinHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 669);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.cb_sbd);
            this.Controls.Add(this.tb_tien);
            this.Controls.Add(this.tb_mahoadon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaThongTinHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa thông tin hóa đơn";
            this.Load += new System.EventHandler(this.FormSuaThongTinHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_sbd;
        private System.Windows.Forms.TextBox tb_tien;
        private System.Windows.Forms.TextBox tb_mahoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_huy;
    }
}