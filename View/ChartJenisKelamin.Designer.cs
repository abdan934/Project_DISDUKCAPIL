namespace Form_Projek_Akhir.View
{
    partial class ChartJenisKelamin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart_Jk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.jml_perem = new System.Windows.Forms.Label();
            this.jml_laki = new System.Windows.Forms.Label();
            this.tot_pend = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart_anak = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_total_penduduk = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.penduduk = new System.Windows.Forms.Label();
            this.lbl_anak = new System.Windows.Forms.Label();
            this.lbl_rw02 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Jk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_anak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_total_penduduk)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Jk
            // 
            this.chart_Jk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            chartArea1.Name = "ChartArea1";
            this.chart_Jk.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 15;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            legend1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart_Jk.Legends.Add(legend1);
            this.chart_Jk.Location = new System.Drawing.Point(1, -3);
            this.chart_Jk.Name = "chart_Jk";
            this.chart_Jk.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "total_ktp";
            this.chart_Jk.Series.Add(series1);
            this.chart_Jk.Size = new System.Drawing.Size(687, 659);
            this.chart_Jk.TabIndex = 0;
            this.chart_Jk.Tag = "";
            this.chart_Jk.Text = "Penduduk Berdasarkan Jenis Kelamin";
            title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            title1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Total Jenis Kelamin";
            this.chart_Jk.Titles.Add(title1);
            // 
            // jml_perem
            // 
            this.jml_perem.AutoSize = true;
            this.jml_perem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jml_perem.Location = new System.Drawing.Point(648, 106);
            this.jml_perem.Name = "jml_perem";
            this.jml_perem.Size = new System.Drawing.Size(64, 16);
            this.jml_perem.TabIndex = 8;
            this.jml_perem.Text = "tot_perm";
            // 
            // jml_laki
            // 
            this.jml_laki.AutoSize = true;
            this.jml_laki.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jml_laki.Location = new System.Drawing.Point(648, 90);
            this.jml_laki.Name = "jml_laki";
            this.jml_laki.Size = new System.Drawing.Size(54, 16);
            this.jml_laki.TabIndex = 6;
            this.jml_laki.Text = "tot_laki";
            // 
            // tot_pend
            // 
            this.tot_pend.AutoSize = true;
            this.tot_pend.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_pend.Location = new System.Drawing.Point(684, 198);
            this.tot_pend.Name = "tot_pend";
            this.tot_pend.Size = new System.Drawing.Size(15, 16);
            this.tot_pend.TabIndex = 10;
            this.tot_pend.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Penduduk";
            // 
            // chart_anak
            // 
            this.chart_anak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            chartArea2.Name = "ChartArea1";
            this.chart_anak.ChartAreas.Add(chartArea2);
            legend2.AutoFitMinFontSize = 15;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            legend2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart_anak.Legends.Add(legend2);
            this.chart_anak.Location = new System.Drawing.Point(708, -3);
            this.chart_anak.Name = "chart_anak";
            this.chart_anak.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "total_anak";
            this.chart_anak.Series.Add(series2);
            this.chart_anak.Size = new System.Drawing.Size(451, 325);
            this.chart_anak.TabIndex = 11;
            this.chart_anak.Tag = "";
            this.chart_anak.Text = "Penduduk Anak";
            title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            title2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Total Anak";
            this.chart_anak.Titles.Add(title2);
            // 
            // chart_total_penduduk
            // 
            this.chart_total_penduduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            chartArea3.Name = "ChartArea1";
            this.chart_total_penduduk.ChartAreas.Add(chartArea3);
            legend3.AutoFitMinFontSize = 15;
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            legend3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart_total_penduduk.Legends.Add(legend3);
            this.chart_total_penduduk.Location = new System.Drawing.Point(732, 340);
            this.chart_total_penduduk.Name = "chart_total_penduduk";
            this.chart_total_penduduk.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "total_penduduk";
            this.chart_total_penduduk.Series.Add(series3);
            this.chart_total_penduduk.Size = new System.Drawing.Size(427, 328);
            this.chart_total_penduduk.TabIndex = 12;
            this.chart_total_penduduk.Tag = "";
            this.chart_total_penduduk.Text = "Total Penduduk";
            title3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            title3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Total Penduduk";
            this.chart_total_penduduk.Titles.Add(title3);
            // 
            // penduduk
            // 
            this.penduduk.AutoSize = true;
            this.penduduk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penduduk.Location = new System.Drawing.Point(1130, 413);
            this.penduduk.Name = "penduduk";
            this.penduduk.Size = new System.Drawing.Size(15, 16);
            this.penduduk.TabIndex = 13;
            this.penduduk.Text = "0";
            // 
            // lbl_anak
            // 
            this.lbl_anak.AutoSize = true;
            this.lbl_anak.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anak.Location = new System.Drawing.Point(1130, 70);
            this.lbl_anak.Name = "lbl_anak";
            this.lbl_anak.Size = new System.Drawing.Size(15, 16);
            this.lbl_anak.TabIndex = 15;
            this.lbl_anak.Text = "0";
            // 
            // lbl_rw02
            // 
            this.lbl_rw02.AutoSize = true;
            this.lbl_rw02.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rw02.Location = new System.Drawing.Point(1130, 429);
            this.lbl_rw02.Name = "lbl_rw02";
            this.lbl_rw02.Size = new System.Drawing.Size(15, 16);
            this.lbl_rw02.TabIndex = 16;
            this.lbl_rw02.Text = "0";
            // 
            // ChartJenisKelamin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1157, 668);
            this.Controls.Add(this.lbl_rw02);
            this.Controls.Add(this.lbl_anak);
            this.Controls.Add(this.penduduk);
            this.Controls.Add(this.chart_total_penduduk);
            this.Controls.Add(this.chart_anak);
            this.Controls.Add(this.tot_pend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jml_perem);
            this.Controls.Add(this.jml_laki);
            this.Controls.Add(this.chart_Jk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChartJenisKelamin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartJenisKelamin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChartJenisKelamin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Jk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_anak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_total_penduduk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Jk;
        private System.Windows.Forms.Label jml_perem;
        private System.Windows.Forms.Label jml_laki;
        private System.Windows.Forms.Label tot_pend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_anak;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_total_penduduk;
        private System.Windows.Forms.Label penduduk;
        private System.Windows.Forms.Label lbl_anak;
        private System.Windows.Forms.Label lbl_rw02;
    }
}