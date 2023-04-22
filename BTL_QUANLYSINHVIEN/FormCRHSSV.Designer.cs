namespace BTL_QUANLYSINHVIEN
{
    partial class FormCRHSSV
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
            this.crp_hssv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp_hssv
            // 
            this.crp_hssv.ActiveViewIndex = -1;
            this.crp_hssv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_hssv.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_hssv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp_hssv.Location = new System.Drawing.Point(0, 0);
            this.crp_hssv.Name = "crp_hssv";
            this.crp_hssv.Size = new System.Drawing.Size(1171, 692);
            this.crp_hssv.TabIndex = 0;
            // 
            // FormCRHSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 692);
            this.Controls.Add(this.crp_hssv);
            this.Name = "FormCRHSSV";
            this.Text = "FormCRHSSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCRHSSV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp_hssv;
    }
}