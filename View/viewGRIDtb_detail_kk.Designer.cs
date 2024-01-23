namespace Form_Projek_Akhir.View
{
    partial class viewGRIDtb_detail_kk
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
            this.txb_VIEW_cariDETKK = new System.Windows.Forms.TextBox();
            this.grid_VIEW_kk = new System.Windows.Forms.DataGridView();
            this.c_no_kk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nama_lengkap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_nik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_jenis_kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_tempat_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_tanggal_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_agama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_pendidikan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_jenis_pekerjaan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_status_pernikahan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_status_hubungan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_kewarganegaraan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_cari_alamat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_VIEW_kk)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(24, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "Cari";
            // 
            // txb_VIEW_cariDETKK
            // 
            this.txb_VIEW_cariDETKK.Location = new System.Drawing.Point(62, 105);
            this.txb_VIEW_cariDETKK.Name = "txb_VIEW_cariDETKK";
            this.txb_VIEW_cariDETKK.Size = new System.Drawing.Size(179, 20);
            this.txb_VIEW_cariDETKK.TabIndex = 43;
            // 
            // grid_VIEW_kk
            // 
            this.grid_VIEW_kk.AllowUserToAddRows = false;
            this.grid_VIEW_kk.AllowUserToDeleteRows = false;
            this.grid_VIEW_kk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_VIEW_kk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_no_kk,
            this.c_nama_lengkap,
            this.c_nik,
            this.c_jenis_kelamin,
            this.c_tempat_lahir,
            this.c_tanggal_lahir,
            this.c_agama,
            this.c_pendidikan,
            this.c_jenis_pekerjaan,
            this.c_status_pernikahan,
            this.c_status_hubungan,
            this.c_kewarganegaraan,
            this.c_alamat});
            this.grid_VIEW_kk.Location = new System.Drawing.Point(27, 145);
            this.grid_VIEW_kk.Name = "grid_VIEW_kk";
            this.grid_VIEW_kk.ReadOnly = true;
            this.grid_VIEW_kk.Size = new System.Drawing.Size(1047, 395);
            this.grid_VIEW_kk.TabIndex = 42;
            // 
            // c_no_kk
            // 
            this.c_no_kk.DataPropertyName = "no_kk";
            this.c_no_kk.HeaderText = "No KK";
            this.c_no_kk.Name = "c_no_kk";
            this.c_no_kk.ReadOnly = true;
            this.c_no_kk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // c_nama_lengkap
            // 
            this.c_nama_lengkap.DataPropertyName = "nama_lengkap";
            this.c_nama_lengkap.HeaderText = "Nama Lengkap";
            this.c_nama_lengkap.Name = "c_nama_lengkap";
            this.c_nama_lengkap.ReadOnly = true;
            this.c_nama_lengkap.Width = 150;
            // 
            // c_nik
            // 
            this.c_nik.DataPropertyName = "nik";
            this.c_nik.HeaderText = "NIK";
            this.c_nik.Name = "c_nik";
            this.c_nik.ReadOnly = true;
            // 
            // c_jenis_kelamin
            // 
            this.c_jenis_kelamin.DataPropertyName = "jenis_kelamin";
            this.c_jenis_kelamin.HeaderText = "Jenis Kelamin";
            this.c_jenis_kelamin.Name = "c_jenis_kelamin";
            this.c_jenis_kelamin.ReadOnly = true;
            // 
            // c_tempat_lahir
            // 
            this.c_tempat_lahir.DataPropertyName = "tempat_lahir";
            this.c_tempat_lahir.HeaderText = "Tempat Lahir";
            this.c_tempat_lahir.Name = "c_tempat_lahir";
            this.c_tempat_lahir.ReadOnly = true;
            // 
            // c_tanggal_lahir
            // 
            this.c_tanggal_lahir.DataPropertyName = "tgl_lahir";
            this.c_tanggal_lahir.HeaderText = "Tanggal Lahir";
            this.c_tanggal_lahir.Name = "c_tanggal_lahir";
            this.c_tanggal_lahir.ReadOnly = true;
            // 
            // c_agama
            // 
            this.c_agama.DataPropertyName = "agama";
            this.c_agama.HeaderText = "Agama";
            this.c_agama.Name = "c_agama";
            this.c_agama.ReadOnly = true;
            // 
            // c_pendidikan
            // 
            this.c_pendidikan.DataPropertyName = "pendidikan";
            this.c_pendidikan.HeaderText = "Pendidikan";
            this.c_pendidikan.Name = "c_pendidikan";
            this.c_pendidikan.ReadOnly = true;
            // 
            // c_jenis_pekerjaan
            // 
            this.c_jenis_pekerjaan.DataPropertyName = "jenis_pekerjaan";
            this.c_jenis_pekerjaan.HeaderText = "Jenis Pekerjaan";
            this.c_jenis_pekerjaan.Name = "c_jenis_pekerjaan";
            this.c_jenis_pekerjaan.ReadOnly = true;
            this.c_jenis_pekerjaan.Width = 150;
            // 
            // c_status_pernikahan
            // 
            this.c_status_pernikahan.DataPropertyName = "status_pernikahan";
            this.c_status_pernikahan.HeaderText = "Status Pernikahan";
            this.c_status_pernikahan.Name = "c_status_pernikahan";
            this.c_status_pernikahan.ReadOnly = true;
            this.c_status_pernikahan.Width = 150;
            // 
            // c_status_hubungan
            // 
            this.c_status_hubungan.DataPropertyName = "status_hubungan";
            this.c_status_hubungan.HeaderText = "Status Hubungan Dalam Keluarga";
            this.c_status_hubungan.Name = "c_status_hubungan";
            this.c_status_hubungan.ReadOnly = true;
            this.c_status_hubungan.Width = 200;
            // 
            // c_kewarganegaraan
            // 
            this.c_kewarganegaraan.DataPropertyName = "kewarganegaraan";
            this.c_kewarganegaraan.HeaderText = "Kewarganegaraan";
            this.c_kewarganegaraan.Name = "c_kewarganegaraan";
            this.c_kewarganegaraan.ReadOnly = true;
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
            this.label12.Location = new System.Drawing.Point(403, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(336, 22);
            this.label12.TabIndex = 50;
            this.label12.Text = "TABEL DETAIL KARTU KELUARGA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(857, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cari";
            // 
            // Txb_cari_alamat
            // 
            this.Txb_cari_alamat.Location = new System.Drawing.Point(895, 105);
            this.Txb_cari_alamat.Name = "Txb_cari_alamat";
            this.Txb_cari_alamat.Size = new System.Drawing.Size(179, 20);
            this.Txb_cari_alamat.TabIndex = 51;
            // 
            // viewGRIDtb_detail_kk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1115, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_cari_alamat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_VIEW_cariDETKK);
            this.Controls.Add(this.grid_VIEW_kk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewGRIDtb_detail_kk";
            this.Text = "viewGRIDtb_detail_kk";
            this.Load += new System.EventHandler(this.viewGRIDtb_detail_kk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_VIEW_kk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_VIEW_cariDETKK;
        private System.Windows.Forms.DataGridView grid_VIEW_kk;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_no_kk;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nama_lengkap;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_nik;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_jenis_kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_tempat_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_tanggal_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_agama;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_pendidikan;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_jenis_pekerjaan;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_status_pernikahan;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_status_hubungan;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_kewarganegaraan;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_alamat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_cari_alamat;
    }
}