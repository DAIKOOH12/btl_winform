namespace BTL_QUANLYSINHVIEN
{
    partial class FormSuaThongTinNganh
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_manganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tennganh = new System.Windows.Forms.TextBox();
            this.cb_makhoa = new System.Windows.Forms.ComboBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ngành";
            // 
            // tb_manganh
            // 
            this.tb_manganh.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_manganh.Enabled = false;
            this.tb_manganh.Location = new System.Drawing.Point(256, 93);
            this.tb_manganh.Name = "tb_manganh";
            this.tb_manganh.Size = new System.Drawing.Size(149, 26);
            this.tb_manganh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã khoa";
            // 
            // tb_tennganh
            // 
            this.tb_tennganh.Location = new System.Drawing.Point(256, 137);
            this.tb_tennganh.Name = "tb_tennganh";
            this.tb_tennganh.Size = new System.Drawing.Size(149, 26);
            this.tb_tennganh.TabIndex = 1;
            // 
            // cb_makhoa
            // 
            this.cb_makhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_makhoa.FormattingEnabled = true;
            this.cb_makhoa.Location = new System.Drawing.Point(256, 191);
            this.cb_makhoa.Name = "cb_makhoa";
            this.cb_makhoa.Size = new System.Drawing.Size(149, 28);
            this.cb_makhoa.TabIndex = 2;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_capnhat.Location = new System.Drawing.Point(174, 267);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(98, 32);
            this.btn_capnhat.TabIndex = 3;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.BackColor = System.Drawing.Color.Peru;
            this.btn_huy.Location = new System.Drawing.Point(307, 267);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(98, 32);
            this.btn_huy.TabIndex = 3;
            this.btn_huy.Text = "Hủy bỏ";
            this.btn_huy.UseVisualStyleBackColor = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // FormSuaThongTinNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.cb_makhoa);
            this.Controls.Add(this.tb_tennganh);
            this.Controls.Add(this.tb_manganh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaThongTinNganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật thông tin ngành";
            this.Load += new System.EventHandler(this.FormSuaThongTinNganh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_manganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_tennganh;
        private System.Windows.Forms.ComboBox cb_makhoa;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_huy;
    }
}