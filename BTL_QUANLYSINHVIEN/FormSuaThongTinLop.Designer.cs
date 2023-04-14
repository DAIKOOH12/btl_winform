namespace BTL_QUANLYSINHVIEN
{
    partial class FormSuaThongTinLop
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_malop = new System.Windows.Forms.TextBox();
            this.tb_tenlop = new System.Windows.Forms.TextBox();
            this.cb_manganh = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã ngành";
            // 
            // tb_malop
            // 
            this.tb_malop.Enabled = false;
            this.tb_malop.Location = new System.Drawing.Point(267, 116);
            this.tb_malop.Name = "tb_malop";
            this.tb_malop.Size = new System.Drawing.Size(171, 26);
            this.tb_malop.TabIndex = 1;
            // 
            // tb_tenlop
            // 
            this.tb_tenlop.Location = new System.Drawing.Point(267, 158);
            this.tb_tenlop.Name = "tb_tenlop";
            this.tb_tenlop.Size = new System.Drawing.Size(171, 26);
            this.tb_tenlop.TabIndex = 1;
            // 
            // cb_manganh
            // 
            this.cb_manganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_manganh.FormattingEnabled = true;
            this.cb_manganh.Location = new System.Drawing.Point(267, 203);
            this.cb_manganh.Name = "cb_manganh";
            this.cb_manganh.Size = new System.Drawing.Size(171, 28);
            this.cb_manganh.TabIndex = 2;
            this.cb_manganh.SelectedIndexChanged += new System.EventHandler(this.cb_manganh_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_save.Location = new System.Drawing.Point(180, 283);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 38);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Cập nhật";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cancel.Location = new System.Drawing.Point(330, 283);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(108, 38);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Hủy bỏ";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FormSuaThongTinLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_manganh);
            this.Controls.Add(this.tb_tenlop);
            this.Controls.Add(this.tb_malop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSuaThongTinLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSuaThongTinLop";
            this.Load += new System.EventHandler(this.FormSuaThongTinLop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_malop;
        private System.Windows.Forms.TextBox tb_tenlop;
        private System.Windows.Forms.ComboBox cb_manganh;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}