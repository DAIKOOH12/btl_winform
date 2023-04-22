namespace BTL_QUANLYSINHVIEN
{
    partial class FormCRCanBo
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
            this.crp_canbo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crp_canbo
            // 
            this.crp_canbo.ActiveViewIndex = -1;
            this.crp_canbo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crp_canbo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crp_canbo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crp_canbo.Location = new System.Drawing.Point(0, 0);
            this.crp_canbo.Name = "crp_canbo";
            this.crp_canbo.Size = new System.Drawing.Size(825, 495);
            this.crp_canbo.TabIndex = 0;
            // 
            // FormCRCanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 495);
            this.Controls.Add(this.crp_canbo);
            this.Name = "FormCRCanBo";
            this.Text = "FormCRCanBo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCRCanBo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crp_canbo;
    }
}