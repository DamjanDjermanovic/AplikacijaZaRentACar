using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TVPP2.Klase;

namespace TVPP2.Forme
{
    public partial class FormIzvestaj : Form
    {
        private BazaPodataka bazaPodataka = new BazaPodataka();
        public FormIzvestaj()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormPocetna());
        }

        private void PostaviMinMaxVrednosti()
        {
            string queryMinDatum = "SELECT MIN(datumVreme_pocetka) FROM Rezervacija";
            string queryMaxDatum = "SELECT MAX(datumVreme_kraja) FROM Rezervacija";

            DateTime minDatum = (DateTime)bazaPodataka.IzvrsiSkalarUpit(queryMinDatum);
            DateTime maxDatum = (DateTime)bazaPodataka.IzvrsiSkalarUpit(queryMaxDatum);

            dtpPocetak.MinDate = minDatum;
            dtpPocetak.MaxDate = maxDatum;
            dtpPocetak.Value = minDatum;

            dtpKraj.MinDate = minDatum;
            dtpKraj.MaxDate = maxDatum;
            dtpKraj.Value = maxDatum;
        }


        private void dtpPocetak_ValueChanged(object sender, EventArgs e)
        {
            dtpKraj.MinDate = dtpPocetak.Value.AddHours(1);

            if (dtpKraj.Value < dtpKraj.MinDate)
            {
                dtpKraj.Value = dtpKraj.MinDate;
            }
        }

        private void btnGenerisiIzvestaj_Click(object sender, EventArgs e)
        {
            
            DateTime pocetniDatum = dtpPocetak.Value;
            DateTime krajnjiDatum = dtpKraj.Value;

            if (pocetniDatum > krajnjiDatum)
            {
                MessageBox.Show("Početni datum ne može biti posle krajnjeg datuma.");
                return;
            }

            string query = @"
                SELECT TOP 1 v.naziv, COUNT(r.id_rezervacija) AS brojRezervacija
                FROM (Vozilo v 
                INNER JOIN Rezervacija r ON v.id_vozila = r.id_vozila)
                GROUP BY v.naziv
                ORDER BY brojRezervacija DESC";


            OleDbParameter[] parameters = new OleDbParameter[]
            {
                new OleDbParameter("@datumVreme_pocetka", OleDbType.Date) { Value = pocetniDatum },
                new OleDbParameter("@datumVreme_kraja", OleDbType.Date) { Value = krajnjiDatum }
            };

            DataTable dtIzvestaj = bazaPodataka.IzvrsiUpit(query, parameters);
            dgvIzvestaj.DataSource = dtIzvestaj;

            PopuniChartRezervacije(dtIzvestaj);
            PopuniChartRezervacijePie(dtIzvestaj);
            
        }

        private void PopuniChartRezervacije(DataTable dtIzvestaj)
        {
            chartRezervacije.Series.Clear();
            chartRezervacije.Series.Add("Broj rezervacija");

            foreach (DataRow row in dtIzvestaj.Rows)
            {
                string kategorija = row["naziv"].ToString();
                int brojRezervacija = Convert.ToInt32(row["brojRezervacija"]);

                chartRezervacije.Series["Broj rezervacija"].Points.AddXY(kategorija, brojRezervacija);
            }
        }

        private void PopuniChartRezervacijePie(DataTable dtIzvestaj)
        {
            chartRezervacijePie.Series.Clear();
            Series series = chartRezervacijePie.Series.Add("Procenat rezervacija");
            series.ChartType = SeriesChartType.Pie;

            foreach (DataRow row in dtIzvestaj.Rows)
            {
                string kategorija = row["naziv"].ToString();
                int brojRezervacija = Convert.ToInt32(row["brojRezervacija"]);

                series.Points.AddXY(kategorija, brojRezervacija);
            }

            series.IsValueShownAsLabel = true;
        }


        private void FormIzvestaj_Load(object sender, EventArgs e)
        {
            PostaviMinMaxVrednosti();
        }
    }
}
