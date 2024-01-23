namespace Form_Projek_Akhir.View
{
    partial class CRUDUser
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
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.carinama = new System.Windows.Forms.Label();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pw_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cek_btn = new System.Windows.Forms.Button();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_dgv = new System.Windows.Forms.DataGridView();
            this.c_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_pw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.user_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cari_txt
            // 
            this.cari_txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari_txt.Location = new System.Drawing.Point(461, 303);
            this.cari_txt.Margin = new System.Windows.Forms.Padding(2);
            this.cari_txt.MaxLength = 35;
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(322, 27);
            this.cari_txt.TabIndex = 22;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // carinama
            // 
            this.carinama.AutoSize = true;
            this.carinama.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carinama.ForeColor = System.Drawing.Color.White;
            this.carinama.Location = new System.Drawing.Point(386, 310);
            this.carinama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carinama.Name = "carinama";
            this.carinama.Size = new System.Drawing.Size(80, 16);
            this.carinama.TabIndex = 21;
            this.carinama.Text = "Cari Nama";
            // 
            // hapus_btn
            // 
            this.hapus_btn.FlatAppearance.BorderSize = 0;
            this.hapus_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.hapus_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.hapus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.Location = new System.Drawing.Point(645, 242);
            this.hapus_btn.Margin = new System.Windows.Forms.Padding(2);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(88, 33);
            this.hapus_btn.TabIndex = 20;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.FlatAppearance.BorderSize = 0;
            this.ubah_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ubah_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ubah_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubah_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah_btn.Location = new System.Drawing.Point(541, 242);
            this.ubah_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(88, 33);
            this.ubah_btn.TabIndex = 19;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = true;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.simpan_btn.FlatAppearance.BorderSize = 0;
            this.simpan_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.simpan_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.simpan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpan_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan_btn.Location = new System.Drawing.Point(439, 242);
            this.simpan_btn.Margin = new System.Windows.Forms.Padding(2);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(88, 33);
            this.simpan_btn.TabIndex = 18;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = false;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(385, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password";
            // 
            // pw_txt
            // 
            this.pw_txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_txt.Location = new System.Drawing.Point(517, 211);
            this.pw_txt.Margin = new System.Windows.Forms.Padding(2);
            this.pw_txt.MaxLength = 35;
            this.pw_txt.Name = "pw_txt";
            this.pw_txt.Size = new System.Drawing.Size(266, 27);
            this.pw_txt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username";
            // 
            // cek_btn
            // 
            this.cek_btn.FlatAppearance.BorderSize = 0;
            this.cek_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cek_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.cek_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cek_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cek_btn.Location = new System.Drawing.Point(722, 148);
            this.cek_btn.Margin = new System.Windows.Forms.Padding(2);
            this.cek_btn.Name = "cek_btn";
            this.cek_btn.Size = new System.Drawing.Size(73, 30);
            this.cek_btn.TabIndex = 14;
            this.cek_btn.Text = "Cek";
            this.cek_btn.UseVisualStyleBackColor = true;
            this.cek_btn.Click += new System.EventHandler(this.cek_btn_Click);
            // 
            // user_txt
            // 
            this.user_txt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_txt.Location = new System.Drawing.Point(522, 150);
            this.user_txt.Margin = new System.Windows.Forms.Padding(2);
            this.user_txt.MaxLength = 15;
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(196, 27);
            this.user_txt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(525, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "DATA USER";
            // 
            // user_dgv
            // 
            this.user_dgv.AllowUserToAddRows = false;
            this.user_dgv.AllowUserToDeleteRows = false;
            this.user_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_username,
            this.c_pw,
            this.c_id_user});
            this.user_dgv.Location = new System.Drawing.Point(388, 334);
            this.user_dgv.Margin = new System.Windows.Forms.Padding(2);
            this.user_dgv.Name = "user_dgv";
            this.user_dgv.ReadOnly = true;
            this.user_dgv.RowTemplate.Height = 24;
            this.user_dgv.Size = new System.Drawing.Size(395, 352);
            this.user_dgv.TabIndex = 25;
            this.user_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_dgv_CellClick);
            // 
            // c_username
            // 
            this.c_username.DataPropertyName = "username";
            this.c_username.HeaderText = "USERNAME";
            this.c_username.MinimumWidth = 8;
            this.c_username.Name = "c_username";
            this.c_username.ReadOnly = true;
            this.c_username.Width = 200;
            // 
            // c_pw
            // 
            this.c_pw.DataPropertyName = "pw";
            this.c_pw.HeaderText = "PASSWORD";
            this.c_pw.Name = "c_pw";
            this.c_pw.ReadOnly = true;
            this.c_pw.Width = 150;
            // 
            // c_id_user
            // 
            this.c_id_user.DataPropertyName = "id_user";
            this.c_id_user.HeaderText = "ID";
            this.c_id_user.Name = "c_id_user";
            this.c_id_user.ReadOnly = true;
            this.c_id_user.Visible = false;
            // 
            // id_user_txt
            // 
            this.id_user_txt.Location = new System.Drawing.Point(617, 182);
            this.id_user_txt.Name = "id_user_txt";
            this.id_user_txt.Size = new System.Drawing.Size(29, 20);
            this.id_user_txt.TabIndex = 26;
            this.id_user_txt.Visible = false;
            // 
            // CRUDUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1173, 707);
            this.Controls.Add(this.id_user_txt);
            this.Controls.Add(this.user_dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cari_txt);
            this.Controls.Add(this.carinama);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.ubah_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pw_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cek_btn);
            this.Controls.Add(this.user_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CRUDUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUDUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CRUDUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Label carinama;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pw_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cek_btn;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView user_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_pw;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_id_user;
        private System.Windows.Forms.TextBox id_user_txt;
    }
}