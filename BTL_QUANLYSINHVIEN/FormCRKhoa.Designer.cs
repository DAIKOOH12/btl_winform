namespace BTL_QUANLYSINHVIEN
{
    partial class FormCRKhoa
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
            this.ctr_khoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crp_TkeKhoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ctr_khoa
            // 
            this.ctr_khoa.ActiveViewIndex = -1;
            this.ctr_khoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctr_khoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctr_khoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctr_khoa.Location = new System.Drawing.Point(0, 0);
            this.ctr_khoa.Name = "ctr_khoa";
            this.ctr_khoa.Size = new System.Drawing.Size(1534, 842);
            this.ctr_khoa.TabIndex = 0;
            // 
            // crp_TkeKhoa
            // 
            this.crp_TkeKhoa.ActiveViewIndex = -1;
            this.crp_TkeKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_TkeKhoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_TkeKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp_TkeKhoa.Location = new System.Drawing.Point(0, 0);
            this.crp_TkeKhoa.Name = "crp_TkeKhoa";
            this.crp_TkeKhoa.Size = new System.Drawing.Size(1534, 842);
            this.crp_TkeKhoa.TabIndex = 1;
            // 
            // FormCRKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1534, 842);
            this.Controls.Add(this.crp_TkeKhoa);
            this.Controls.Add(this.ctr_khoa);
            this.Name = "FormCRKhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCRKhoa";
            this.Load += new System.EventHandler(this.FormCRKhoa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ctr_khoa;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp_TkeKhoa;
    }
}