namespace BTL_QUANLYSINHVIEN
{
    partial class FormCRLop
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
            this.crp_lop = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp_lop
            // 
            this.crp_lop.ActiveViewIndex = -1;
            this.crp_lop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_lop.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_lop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp_lop.Location = new System.Drawing.Point(0, 0);
            this.crp_lop.Name = "crp_lop";
            this.crp_lop.Size = new System.Drawing.Size(800, 450);
            this.crp_lop.TabIndex = 0;
            // 
            // FormCRLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crp_lop);
            this.Name = "FormCRLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCRLop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCRLop_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp_lop;
    }
}