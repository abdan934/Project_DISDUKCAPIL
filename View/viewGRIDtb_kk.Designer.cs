namespace Form_Projek_Akhir.View
{
    partial class viewGRIDtb_kk
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
            this.label13 = new System.Windows.Forms.Label();
            this.txb_VIEW_cariKK = new System.Windows.Forms.TextBox();
            this.grid_VIEW_kk = new System.Windows.Forms.DataGridView();
            this.c_no_kk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_VIEW_kk)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(311, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "Cari";
            // 
            // txb_VIEW_cariKK
            // 
            this.txb_VIEW_cariKK.Location = new System.Drawing.Point(349, 79);
            this.txb_VIEW_cariKK.Name = "txb_VIEW_cariKK";
            this.txb_VIEW_cariKK.Size = new System.Drawing.Size(119, 20);
            this.txb_VIEW_cariKK.TabIndex = 47;
            // 
            // grid_VIEW_kk
            // 
            this.grid_VIEW_kk.AllowUserToAddRows = false;
            this.grid_VIEW_kk.AllowUserToDeleteRows = false;
            this.grid_VIEW_kk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_VIEW_kk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_no_kk,
            this.c_alamat});
            this.grid_VIEW_kk.Location = new System.Drawing.Point(313, 105);
            this.grid_VIEW_kk.Name = "grid_VIEW_kk";
            this.grid_VIEW_kk.ReadOnly = true;
            this.grid_VIEW_kk.Size = new System.Drawing.Size(546, 443);
            this.grid_VIEW_kk.TabIndex = 46;
            // 
            // c_no_kk
            // 
            this.c_no_kk.DataPropertyName = "no_kk";
            this.c_no_kk.HeaderText = "Nomor Kartu Keluarga";
            this.c_no_kk.Name = "c_no_kk";
            this.c_no_kk.ReadOnly = true;
            this.c_no_kk.Width = 200;
            // 
            // c_alamat
            // 
            this.c_alamat.DataPropertyName = "alamat";
            this.c_alamat.HeaderText = "Alamat";
            this.c_alamat.Name = "c_alamat";
            this.c_alamat.ReadOnly = true;
            this.c_alamat.Width = 300;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(456, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(261, 22);
            this.label12.TabIndex = 49;
            this.label12.Text = "TABEL KARTU KELUARGA";
            // 
            // viewGRIDtb_kk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1173, 707);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_VIEW_cariKK);
            this.Controls.Add(this.grid_VIEW_kk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewGRIDtb_kk";
            this.Text = "viewGRIDtb_kk";
            this.Load += new System.EventHandler(this.viewGRIDtb_kk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_VIEW_kk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_VIEW_cariKK;
        private System.Windows.Forms.DataGridView grid_VIEW_kk;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_no_kk;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_alamat;
        private System.Windows.Forms.Label label12;




    }
}