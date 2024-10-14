namespace TVPP2
{
    partial class FormPocetna
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
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.dgvVozilaKategorije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMinCena = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMaxCena = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKategorija = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.btnPrimeniFIlter = new System.Windows.Forms.Button();
            this.btnIzbrisiFilter = new System.Windows.Forms.Button();
            this.btnDodajRezervaciju = new System.Windows.Forms.Button();
            this.btnDodajKategoriju = new System.Windows.Forms.Button();
            this.btnIzvestaj = new System.Windows.Forms.Button();
            this.lblAnimacija = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilaKategorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCena)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.BackColor = System.Drawing.Color.Red;
            this.btnDodajVozilo.FlatAppearance.BorderSize = 0;
            this.btnDodajVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajVozilo.ForeColor = System.Drawing.Color.White;
            this.btnDodajVozilo.Location = new System.Drawing.Point(679, 414);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(515, 80);
            this.btnDodajVozilo.TabIndex = 5;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = false;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // dgvVozilaKategorije
            // 
            this.dgvVozilaKategorije.AllowUserToAddRows = false;
            this.dgvVozilaKategorije.AllowUserToDeleteRows = false;
            this.dgvVozilaKategorije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVozilaKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozilaKategorije.Location = new System.Drawing.Point(12, 67);
            this.dgvVozilaKategorije.Name = "dgvVozilaKategorije";
            this.dgvVozilaKategorije.ReadOnly = true;
            this.dgvVozilaKategorije.RowHeadersWidth = 51;
            this.dgvVozilaKategorije.RowTemplate.Height = 24;
            this.dgvVozilaKategorije.Size = new System.Drawing.Size(1230, 223);
            this.dgvVozilaKategorije.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "RENT A CAR PONUDA";
            // 
            // nudMinCena
            // 
            this.nudMinCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinCena.Location = new System.Drawing.Point(18, 385);
            this.nudMinCena.Name = "nudMinCena";
            this.nudMinCena.Size = new System.Drawing.Size(244, 34);
            this.nudMinCena.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtriraj po ceni po satu:";
            // 
            // nudMaxCena
            // 
            this.nudMaxCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxCena.Location = new System.Drawing.Point(324, 385);
            this.nudMaxCena.Name = "nudMaxCena";
            this.nudMaxCena.Size = new System.Drawing.Size(244, 34);
            this.nudMaxCena.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(318, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Do:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(14, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Filtriraj po kategoriji:";
            // 
            // cmbKategorija
            // 
            this.cmbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKategorija.FormattingEnabled = true;
            this.cmbKategorija.Location = new System.Drawing.Point(324, 605);
            this.cmbKategorija.Name = "cmbKategorija";
            this.cmbKategorija.Size = new System.Drawing.Size(244, 37);
            this.cmbKategorija.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Filtriraj po datumu:";
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Checked = false;
            this.dtpPocetak.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpPocetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPocetak.Location = new System.Drawing.Point(168, 495);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(400, 34);
            this.dtpPocetak.TabIndex = 13;
            this.dtpPocetak.Value = new System.DateTime(2024, 9, 3, 20, 53, 11, 0);
            this.dtpPocetak.ValueChanged += new System.EventHandler(this.dtpPocetak_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Od:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(14, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 32);
            this.label8.TabIndex = 15;
            this.label8.Text = "Do:";
            // 
            // dtpKraj
            // 
            this.dtpKraj.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKraj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKraj.Location = new System.Drawing.Point(168, 541);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(400, 34);
            this.dtpKraj.TabIndex = 16;
            this.dtpKraj.Value = new System.DateTime(2024, 9, 3, 20, 53, 15, 0);
            // 
            // btnPrimeniFIlter
            // 
            this.btnPrimeniFIlter.BackColor = System.Drawing.Color.Red;
            this.btnPrimeniFIlter.FlatAppearance.BorderSize = 0;
            this.btnPrimeniFIlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeniFIlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeniFIlter.ForeColor = System.Drawing.Color.White;
            this.btnPrimeniFIlter.Location = new System.Drawing.Point(20, 658);
            this.btnPrimeniFIlter.Name = "btnPrimeniFIlter";
            this.btnPrimeniFIlter.Size = new System.Drawing.Size(270, 50);
            this.btnPrimeniFIlter.TabIndex = 19;
            this.btnPrimeniFIlter.Text = "Primeni filter";
            this.btnPrimeniFIlter.UseVisualStyleBackColor = false;
            this.btnPrimeniFIlter.Click += new System.EventHandler(this.btnPrimeniFIlter_Click);
            // 
            // btnIzbrisiFilter
            // 
            this.btnIzbrisiFilter.BackColor = System.Drawing.Color.Red;
            this.btnIzbrisiFilter.FlatAppearance.BorderSize = 0;
            this.btnIzbrisiFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisiFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiFilter.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisiFilter.Location = new System.Drawing.Point(298, 658);
            this.btnIzbrisiFilter.Name = "btnIzbrisiFilter";
            this.btnIzbrisiFilter.Size = new System.Drawing.Size(270, 50);
            this.btnIzbrisiFilter.TabIndex = 20;
            this.btnIzbrisiFilter.Text = "Izbrisi filtere";
            this.btnIzbrisiFilter.UseVisualStyleBackColor = false;
            this.btnIzbrisiFilter.Click += new System.EventHandler(this.btnIzbrisiFilter_Click);
            // 
            // btnDodajRezervaciju
            // 
            this.btnDodajRezervaciju.BackColor = System.Drawing.Color.Red;
            this.btnDodajRezervaciju.FlatAppearance.BorderSize = 0;
            this.btnDodajRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRezervaciju.ForeColor = System.Drawing.Color.White;
            this.btnDodajRezervaciju.Location = new System.Drawing.Point(679, 303);
            this.btnDodajRezervaciju.Name = "btnDodajRezervaciju";
            this.btnDodajRezervaciju.Size = new System.Drawing.Size(515, 80);
            this.btnDodajRezervaciju.TabIndex = 21;
            this.btnDodajRezervaciju.Text = "Dodaj rezervaciju";
            this.btnDodajRezervaciju.UseVisualStyleBackColor = false;
            this.btnDodajRezervaciju.Click += new System.EventHandler(this.btnDodajRezervaciju_Click);
            // 
            // btnDodajKategoriju
            // 
            this.btnDodajKategoriju.BackColor = System.Drawing.Color.Red;
            this.btnDodajKategoriju.FlatAppearance.BorderSize = 0;
            this.btnDodajKategoriju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajKategoriju.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajKategoriju.ForeColor = System.Drawing.Color.White;
            this.btnDodajKategoriju.Location = new System.Drawing.Point(679, 518);
            this.btnDodajKategoriju.Name = "btnDodajKategoriju";
            this.btnDodajKategoriju.Size = new System.Drawing.Size(515, 80);
            this.btnDodajKategoriju.TabIndex = 22;
            this.btnDodajKategoriju.Text = "Dodaj kategoriju";
            this.btnDodajKategoriju.UseVisualStyleBackColor = false;
            this.btnDodajKategoriju.Click += new System.EventHandler(this.btnDodajKategoriju_Click);
            // 
            // btnIzvestaj
            // 
            this.btnIzvestaj.BackColor = System.Drawing.Color.Red;
            this.btnIzvestaj.FlatAppearance.BorderSize = 0;
            this.btnIzvestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzvestaj.ForeColor = System.Drawing.Color.White;
            this.btnIzvestaj.Location = new System.Drawing.Point(679, 628);
            this.btnIzvestaj.Name = "btnIzvestaj";
            this.btnIzvestaj.Size = new System.Drawing.Size(515, 80);
            this.btnIzvestaj.TabIndex = 23;
            this.btnIzvestaj.Text = "Izvestaj";
            this.btnIzvestaj.UseVisualStyleBackColor = false;
            this.btnIzvestaj.Click += new System.EventHandler(this.btnIzvestaj_Click);
            // 
            // lblAnimacija
            // 
            this.lblAnimacija.AutoSize = true;
            this.lblAnimacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimacija.ForeColor = System.Drawing.Color.Red;
            this.lblAnimacija.Location = new System.Drawing.Point(768, 20);
            this.lblAnimacija.Name = "lblAnimacija";
            this.lblAnimacija.Size = new System.Drawing.Size(326, 32);
            this.lblAnimacija.TabIndex = 3;
            this.lblAnimacija.Text = "RENT A CAR PONUDA";
            // 
            // FormPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 720);
            this.Controls.Add(this.btnIzvestaj);
            this.Controls.Add(this.btnDodajKategoriju);
            this.Controls.Add(this.btnDodajRezervaciju);
            this.Controls.Add(this.btnIzbrisiFilter);
            this.Controls.Add(this.btnPrimeniFIlter);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbKategorija);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMaxCena);
            this.Controls.Add(this.nudMinCena);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.dgvVozilaKategorije);
            this.Controls.Add(this.lblAnimacija);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilaKategorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxCena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.DataGridView dgvVozilaKategorije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMinCena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMaxCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKategorija;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.Button btnPrimeniFIlter;
        private System.Windows.Forms.Button btnIzbrisiFilter;
        private System.Windows.Forms.Button btnDodajRezervaciju;
        private System.Windows.Forms.Button btnDodajKategoriju;
        private System.Windows.Forms.Button btnIzvestaj;
        private System.Windows.Forms.Label lblAnimacija;
    }
}

