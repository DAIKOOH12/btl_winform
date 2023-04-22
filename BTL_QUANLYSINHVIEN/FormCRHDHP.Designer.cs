namespace BTL_QUANLYSINHVIEN
{
    partial class FormCRHDHP
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
            this.crp_hdhp = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp_hdhp
            // 
            this.crp_hdhp.ActiveViewIndex = -1;
            this.crp_hdhp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_hdhp.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_hdhp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp_hdhp.Location = new System.Drawing.Point(0, 0);
            this.crp_hdhp.Name = "crp_hdhp";
            this.crp_hdhp.Size = new System.Drawing.Size(985, 535);
            this.crp_hdhp.TabIndex = 0;
            // 
            // FormCRHDHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 535);
            this.Controls.Add(this.crp_hdhp);
            this.Name = "FormCRHDHP";
            this.Text = "FormCRHDHP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCRHDHP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp_hdhp;
    }
}