namespace Form_Projek_Akhir.View
{
    partial class viewGRIDtb_ktp
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
            this.grid_VIEW_ktp = new System.Windows.Forms.DataGridView();
            this.c_nik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nama_lengkap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_tempat_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_tgl_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_jenis_kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_agama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_status_perkawinan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_pekerjaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_kewarganegaraan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_VIEW_cariKTP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_VIEW_ktp)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_VIEW_ktp
            // 
            this.grid_VIEW_ktp.AllowUserToAddRows = false;
            this.grid_VIEW_ktp.AllowUserToDeleteRows = false;
            this.grid_VIEW_ktp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_VIEW_ktp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_nik,
            this.c_nama_lengkap,
            this.c_tempat_lahir,
            this.c_tgl_lahir,
            this.c_jenis_kelamin,
            this.c_alamat,
            this.c_agama,
            this.c_status_perkawinan,
            this.c_pekerjaan,
            this.c_kewarganegaraan,
            this.c_foto});
            this.grid_VIEW_ktp.Location = new System.Drawing.Point(37, 141);
            this.grid_VIEW_ktp.Name = "grid_VIEW_ktp";
            this.grid_VIEW_ktp.ReadOnly = true;
            this.grid_VIEW_ktp.Size = new System.Drawing.Size(1047, 395);
            this.grid_VIEW_ktp.TabIndex = 37;
            // 
            // c_nik
            // 
            this.c_nik.DataPropertyName = "nik";
            this.c_nik.HeaderText = "NIK";
            this.c_nik.MaxInputLength = 20;
            this.c_nik.Name = "c_nik";
            this.c_nik.ReadOnly = true;
            // 
            // c_nama_lengkap
            // 
            this.c_nama_lengkap.DataPropertyName = "nama_lengkap";
            this.c_nama_lengkap.HeaderText = "Nama Lengkap";
            this.c_nama_lengkap.Name = "c_nama_lengkap";
            this.c_nama_lengkap.ReadOnly = true;
            // 
            // c_tempat_lahir
            // 
            this.c_tempat_lahir.DataPropertyName = "tempat_lahir";
            this.c_tempat_lahir.HeaderText = "Tempat Lahir";
            this.c_tempat_lahir.Name = "c_tempat_lahir";
            this.c_tempat_lahir.ReadOnly = true;
            // 
            // c_tgl_lahir
            // 
            this.c_tgl_lahir.DataPropertyName = "tgl_lahir";
            this.c_tgl_lahir.HeaderText = "Tanggal Lahir";
            this.c_tgl_lahir.Name = "c_tgl_lahir";
            this.c_tgl_lahir.ReadOnly = true;
            // 
            // c_jenis_kelamin
            // 
            this.c_jenis_kelamin.DataPropertyName = "jenis_kelamin";
            this.c_jenis_kelamin.HeaderText = "Jenis Kelamin";
            this.c_jenis_kelamin.Name = "c_jenis_kelamin";
            this.c_jenis_kelamin.ReadOnly = true;
            // 
            // c_alamat
            // 
            this.c_alamat.DataPropertyName = "alamat";
            this.c_alamat.HeaderText = "Alamat";
            this.c_alamat.Name = "c_alamat";
            this.c_alamat.ReadOnly = true;
            // 
            // c_agama
            // 
            this.c_agama.DataPropertyName = "agama";
            this.c_agama.HeaderText = "Agama";
            this.c_agama.Name = "c_agama";
            this.c_agama.ReadOnly = true;
            // 
            // c_status_perkawinan
            // 
            this.c_status_perkawinan.DataPropertyName = "status_perkawinan";
            this.c_status_perkawinan.HeaderText = "Status Perkawinan";
            this.c_status_perkawinan.Name = "c_status_perkawinan";
            this.c_status_perkawinan.ReadOnly = true;
            // 
            // c_pekerjaan
            // 
            this.c_pekerjaan.DataPropertyName = "pekerjaan";
            this.c_pekerjaan.HeaderText = "Pekerjaan";
            this.c_pekerjaan.Name = "c_pekerjaan";
            this.c_pekerjaan.ReadOnly = true;
            // 
            // c_kewarganegaraan
            // 
            this.c_kewarganegaraan.DataPropertyName = "kewarganegaraan";
            this.c_kewarganegaraan.HeaderText = "Kewarganegaraan";
            this.c_kewarganegaraan.Name = "c_kewarganegaraan";
            this.c_kewarganegaraan.ReadOnly = true;
            // 
            // c_foto
            // 
            this.c_foto.DataPropertyName = "foto";
            this.c_foto.HeaderText = "Foto";
            this.c_foto.Name = "c_foto";
            this.c_foto.ReadOnly = true;
            this.c_foto.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(37, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Cari";
            // 
            // txb_VIEW_cariKTP
            // 
            this.txb_VIEW_cariKTP.Location = new System.Drawing.Point(82, 111);
            this.txb_VIEW_cariKTP.Name = "txb_VIEW_cariKTP";
            this.txb_VIEW_cariKTP.Size = new System.Drawing.Size(179, 20);
            this.txb_VIEW_cariKTP.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(379, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(419, 28);
            this.label11.TabIndex = 38;
            this.label11.Text = "TABEL KARTU TANDA PENDUDUK";
            // 
            // viewGRIDtb_ktp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1157, 668);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grid_VIEW_ktp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_VIEW_cariKTP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewGRIDtb_ktp";
            this.Text = "viewGRIDtb_ktp";
            this.Load += new System.EventHandler(this.viewGRIDtb_ktp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_VIEW_ktp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_VIEW_ktp;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nik;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nama_lengkap;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_tempat_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_tgl_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_jenis_kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_agama;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_status_perkawinan;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_pekerjaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_kewarganegaraan;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_foto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_VIEW_cariKTP;
        private System.Windows.Forms.Label label11;
    }
}