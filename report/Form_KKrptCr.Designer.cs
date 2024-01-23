namespace Form_Projek_Akhir.report
{
    partial class Form_KKrptCr
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
            this.rpt_kk = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rpt_kk
            // 
            this.rpt_kk.ActiveViewIndex = -1;
            this.rpt_kk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpt_kk.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpt_kk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpt_kk.Location = new System.Drawing.Point(0, 0);
            this.rpt_kk.Name = "rpt_kk";
            this.rpt_kk.Size = new System.Drawing.Size(572, 261);
            this.rpt_kk.TabIndex = 0;
            this.rpt_kk.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form_KKrptCr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 261);
            this.Controls.Add(this.rpt_kk);
            this.Name = "Form_KKrptCr";
            this.Text = "Form_KKrptCr";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_KKrptCr_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpt_kk;
    }
}