namespace Form_Projek_Akhir.View
{
    partial class form_Kk
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
            this.label12 = new System.Windows.Forms.Label();
            this.label_no_kk = new System.Windows.Forms.Label();
            this.txb_no_kk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_alamat = new System.Windows.Forms.TextBox();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.grid_kk = new System.Windows.Forms.DataGridView();
            this.c_no_kk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_cari = new System.Windows.Forms.TextBox();
            this.txb_nama_suami = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_kk)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(502, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 22);
            this.label12.TabIndex = 35;
            this.label12.Text = "Form Tambah KK";
            // 
            // label_no_kk
            // 
            this.label_no_kk.AutoSize = true;
            this.label_no_kk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_no_kk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_no_kk.Location = new System.Drawing.Point(316, 52);
            this.label_no_kk.Name = "label_no_kk";
            this.label_no_kk.Size = new System.Drawing.Size(39, 12);
            this.label_no_kk.TabIndex = 36;
            this.label_no_kk.Text = "No KK";
            // 
            // txb_no_kk
            // 
            this.txb_no_kk.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_no_kk.Location = new System.Drawing.Point(374, 52);
            this.txb_no_kk.Name = "txb_no_kk";
            this.txb_no_kk.Size = new System.Drawing.Size(261, 25);
            this.txb_no_kk.TabIndex = 37;
            this.txb_no_kk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_no_kk_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(311, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "Alamat";
            // 
            // txb_alamat
            // 
            this.txb_alamat.AcceptsReturn = true;
            this.txb_alamat.Location = new System.Drawing.Point(374, 100);
            this.txb_alamat.Multiline = true;
            this.txb_alamat.Name = "txb_alamat";
            this.txb_alamat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_alamat.Size = new System.Drawing.Size(485, 100);
            this.txb_alamat.TabIndex = 39;
            // 
            // button_simpan
            // 
            this.button_simpan.BackColor = System.Drawing.Color.DarkBlue;
            this.button_simpan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Location = new System.Drawing.Point(592, 217);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(85, 29);
            this.button_simpan.TabIndex = 40;
            this.button_simpan.Text = "SIMPAN";
            this.button_simpan.UseVisualStyleBackColor = false;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_hapus
            // 
            this.button_hapus.BackColor = System.Drawing.Color.Red;
            this.button_hapus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.Location = new System.Drawing.Point(774, 217);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(85, 29);
            this.button_hapus.TabIndex = 41;
            this.button_hapus.Text = "HAPUS";
            this.button_hapus.UseVisualStyleBackColor = false;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_ubah
            // 
            this.button_ubah.BackColor = System.Drawing.Color.Lime;
            this.button_ubah.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ubah.Location = new System.Drawing.Point(683, 217);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(85, 29);
            this.button_ubah.TabIndex = 42;
            this.button_ubah.Text = "UBAH";
            this.button_ubah.UseVisualStyleBackColor = false;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // grid_kk
            // 
            this.grid_kk.AllowUserToAddRows = false;
            this.grid_kk.AllowUserToDeleteRows = false;
            this.grid_kk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_kk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_no_kk,
            this.c_alamat});
            this.grid_kk.Location = new System.Drawing.Point(313, 252);
            this.grid_kk.Name = "grid_kk";
            this.grid_kk.ReadOnly = true;
            this.grid_kk.Size = new System.Drawing.Size(546, 443);
            this.grid_kk.TabIndex = 43;
            this.grid_kk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_kk_CellClick);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(312, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "Cari";
            // 
            // txb_cari
            // 
            this.txb_cari.Location = new System.Drawing.Point(350, 226);
            this.txb_cari.Name = "txb_cari";
            this.txb_cari.Size = new System.Drawing.Size(119, 20);
            this.txb_cari.TabIndex = 44;
            this.txb_cari.TextChanged += new System.EventHandler(this.txb_cari_TextChanged);
            // 
            // txb_nama_suami
            // 
            this.txb_nama_suami.Enabled = false;
            this.txb_nama_suami.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nama_suami.Location = new System.Drawing.Point(641, 52);
            this.txb_nama_suami.Name = "txb_nama_suami";
            this.txb_nama_suami.Size = new System.Drawing.Size(218, 25);
            this.txb_nama_suami.TabIndex = 46;
            // 
            // form_Kk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1173, 707);
            this.Controls.Add(this.txb_nama_suami);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_cari);
            this.Controls.Add(this.grid_kk);
            this.Controls.Add(this.button_ubah);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.txb_alamat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_no_kk);
            this.Controls.Add(this.label_no_kk);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Kk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_Kk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_Kk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_kk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_no_kk;
        private System.Windows.Forms.TextBox txb_no_kk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_alamat;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.DataGridView grid_kk;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_no_kk;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_alamat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_cari;
        private System.Windows.Forms.TextBox txb_nama_suami;
    }
}