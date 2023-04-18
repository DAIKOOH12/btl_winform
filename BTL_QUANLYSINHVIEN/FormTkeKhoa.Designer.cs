namespace BTL_QUANLYSINHVIEN
{
    partial class FormTkeKhoa
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
            this.cb_loai = new System.Windows.Forms.ComboBox();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_loai
            // 
            this.cb_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_loai.FormattingEnabled = true;
            this.cb_loai.Location = new System.Drawing.Point(295, 89);
            this.cb_loai.Name = "cb_loai";
            this.cb_loai.Size = new System.Drawing.Size(160, 28);
            this.cb_loai.TabIndex = 6;
            this.cb_loai.SelectedIndexChanged += new System.EventHandler(this.cb_loai_SelectedIndexChanged);
            // 
            // btn_xuat
            // 
            this.btn_xuat.Location = new System.Drawing.Point(508, 118);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(137, 35);
            this.btn_xuat.TabIndex = 5;
            this.btn_xuat.Text = "Xuất";
            this.btn_xuat.UseVisualStyleBackColor = true;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn loại thống kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập thông tin";
            // 
            // tb_info
            // 
            this.tb_info.Enabled = false;
            this.tb_info.Location = new System.Drawing.Point(295, 159);
            this.tb_info.Name = "tb_info";
            this.tb_info.Size = new System.Drawing.Size(160, 26);
            this.tb_info.TabIndex = 7;
            // 
            // FormTkeKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 435);
            this.Controls.Add(this.tb_info);
            this.Controls.Add(this.cb_loai);
            this.Controls.Add(this.btn_xuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTkeKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTkeKhoa";
            this.Load += new System.EventHandler(this.FormTkeKhoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_loai;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_info;
    }
}