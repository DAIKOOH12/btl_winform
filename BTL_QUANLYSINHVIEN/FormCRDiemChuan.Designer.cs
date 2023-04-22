namespace BTL_QUANLYSINHVIEN
{
    partial class FormCRDiemChuan
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
            this.crp_diemchuan = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp_diemchuan
            // 
            this.crp_diemchuan.ActiveViewIndex = -1;
            this.crp_diemchuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_diemchuan.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_diemchuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp_diemchuan.Location = new System.Drawing.Point(0, 0);
            this.crp_diemchuan.Name = "crp_diemchuan";
            this.crp_diemchuan.Size = new System.Drawing.Size(870, 523);
            this.crp_diemchuan.TabIndex = 0;
            // 
            // FormCRDiemChuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 523);
            this.Controls.Add(this.crp_diemchuan);
            this.Name = "FormCRDiemChuan";
            this.Text = "FormCRDiemChuan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCRDiemChuan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp_diemchuan;
    }
}