namespace BTL_QUANLYSINHVIEN
{
    partial class FormCRHocSinh
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
            this.crp_hocsinh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp_hocsinh
            // 
            this.crp_hocsinh.ActiveViewIndex = -1;
            this.crp_hocsinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_hocsinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_hocsinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp_hocsinh.Location = new System.Drawing.Point(0, 0);
            this.crp_hocsinh.Name = "crp_hocsinh";
            this.crp_hocsinh.Size = new System.Drawing.Size(1226, 658);
            this.crp_hocsinh.TabIndex = 0;
            // 
            // FormCRHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 658);
            this.Controls.Add(this.crp_hocsinh);
            this.Name = "FormCRHocSinh";
            this.Text = "FormCRHocSinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCRHocSinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp_hocsinh;
    }
}