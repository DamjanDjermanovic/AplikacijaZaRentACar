namespace TVPP2.Forme
{
    partial class FormIzvestaj
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.btnGenerisiIzvestaj = new System.Windows.Forms.Button();
            this.dgvIzvestaj = new System.Windows.Forms.DataGridView();
            this.chartRezervacije = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRezervacijePie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRezervacijePie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Izvestaj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(599, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "DO";
            // 
            // dtpKraj
            // 
            this.dtpKraj.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKraj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKraj.Location = new System.Drawing.Point(702, 15);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(400, 34);
            this.dtpKraj.TabIndex = 27;
            this.dtpKraj.Value = new System.DateTime(2024, 9, 3, 20, 53, 15, 0);
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Checked = false;
            this.dtpPocetak.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpPocetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPocetak.Location = new System.Drawing.Point(145, 17);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(400, 34);
            this.dtpPocetak.TabIndex = 26;
            this.dtpPocetak.Value = new System.DateTime(2024, 9, 3, 20, 53, 11, 0);
            // 
            // btnIzadji
            // 
            this.btnIzadji.BackColor = System.Drawing.Color.Red;
            this.btnIzadji.FlatAppearance.BorderSize = 0;
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.ForeColor = System.Drawing.Color.White;
            this.btnIzadji.Location = new System.Drawing.Point(1108, 5);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(45, 45);
            this.btnIzadji.TabIndex = 36;
            this.btnIzadji.Text = "X";
            this.btnIzadji.UseVisualStyleBackColor = false;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // btnGenerisiIzvestaj
            // 
            this.btnGenerisiIzvestaj.BackColor = System.Drawing.Color.Red;
            this.btnGenerisiIzvestaj.FlatAppearance.BorderSize = 0;
            this.btnGenerisiIzvestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerisiIzvestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerisiIzvestaj.ForeColor = System.Drawing.Color.White;
            this.btnGenerisiIzvestaj.Location = new System.Drawing.Point(18, 300);
            this.btnGenerisiIzvestaj.Name = "btnGenerisiIzvestaj";
            this.btnGenerisiIzvestaj.Size = new System.Drawing.Size(258, 45);
            this.btnGenerisiIzvestaj.TabIndex = 37;
            this.btnGenerisiIzvestaj.Text = "Generisi izvestaj";
            this.btnGenerisiIzvestaj.UseVisualStyleBackColor = false;
            this.btnGenerisiIzvestaj.Click += new System.EventHandler(this.btnGenerisiIzvestaj_Click);
            // 
            // dgvIzvestaj
            // 
            this.dgvIzvestaj.AllowUserToAddRows = false;
            this.dgvIzvestaj.AllowUserToDeleteRows = false;
            this.dgvIzvestaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIzvestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvestaj.Location = new System.Drawing.Point(282, 57);
            this.dgvIzvestaj.Name = "dgvIzvestaj";
            this.dgvIzvestaj.ReadOnly = true;
            this.dgvIzvestaj.RowHeadersWidth = 51;
            this.dgvIzvestaj.RowTemplate.Height = 24;
            this.dgvIzvestaj.Size = new System.Drawing.Size(869, 234);
            this.dgvIzvestaj.TabIndex = 38;
            // 
            // chartRezervacije
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRezervacije.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRezervacije.Legends.Add(legend3);
            this.chartRezervacije.Location = new System.Drawing.Point(282, 300);
            this.chartRezervacije.Name = "chartRezervacije";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRezervacije.Series.Add(series3);
            this.chartRezervacije.Size = new System.Drawing.Size(418, 300);
            this.chartRezervacije.TabIndex = 39;
            this.chartRezervacije.Text = "chart1";
            // 
            // chartRezervacijePie
            // 
            chartArea4.Name = "ChartArea1";
            this.chartRezervacijePie.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartRezervacijePie.Legends.Add(legend4);
            this.chartRezervacijePie.Location = new System.Drawing.Point(733, 300);
            this.chartRezervacijePie.Name = "chartRezervacijePie";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartRezervacijePie.Series.Add(series4);
            this.chartRezervacijePie.Size = new System.Drawing.Size(418, 300);
            this.chartRezervacijePie.TabIndex = 40;
            this.chartRezervacijePie.Text = "chart2";
            // 
            // FormIzvestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 612);
            this.Controls.Add(this.chartRezervacijePie);
            this.Controls.Add(this.chartRezervacije);
            this.Controls.Add(this.dgvIzvestaj);
            this.Controls.Add(this.btnGenerisiIzvestaj);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIzvestaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIzvestaj";
            this.Load += new System.EventHandler(this.FormIzvestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRezervacijePie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button btnGenerisiIzvestaj;
        private System.Windows.Forms.DataGridView dgvIzvestaj;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRezervacije;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRezervacijePie;
    }
}