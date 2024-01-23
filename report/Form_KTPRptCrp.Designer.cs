namespace Form_Projek_Akhir.report
{
    partial class Form_KTPRptCrp
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
            this.ktp_crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ktp_crv
            // 
            this.ktp_crv.ActiveViewIndex = -1;
            this.ktp_crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ktp_crv.Cursor = System.Windows.Forms.Cursors.Default;
            this.ktp_crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ktp_crv.Location = new System.Drawing.Point(0, 0);
            this.ktp_crv.Name = "ktp_crv";
            this.ktp_crv.Size = new System.Drawing.Size(605, 261);
            this.ktp_crv.TabIndex = 0;
            this.ktp_crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.ktp_crv.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Form_KTPRptCrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 261);
            this.Controls.Add(this.ktp_crv);
            this.Name = "Form_KTPRptCrp";
            this.Text = "Form_KTPRptCrp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_KTPRptCrp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ktp_crv;

    }
}