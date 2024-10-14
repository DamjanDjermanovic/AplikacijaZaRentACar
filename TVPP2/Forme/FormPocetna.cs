using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVPP2.Forme;
using TVPP2.Klase;

namespace TVPP2
{
    public partial class FormPocetna : Form
    {
        private BazaPodataka bazaPodataka = new BazaPodataka();
        public FormPocetna()
        {
            InitializeComponent();
            
        }
        private void FormPocetna_Load(object sender, EventArgs e)
        {
            UcitajVozila();
            UcitajKategorije();
            PostaviMinMaxVrednosti();
            //PrikaziAnimacijuNajpopularnijegVozila();
        }

        private void UcitajVozila()
        {
            string query = "SELECT Vozilo.*, Kategorija.naziv AS Kategorija FROM(Vozilo INNER JOIN Kategorija ON Vozilo.id_kategorije = Kategorija.id_kategorije)";
            DataTable dt = bazaPodataka.IzvrsiUpit(query);
            dgvVozilaKategorije.DataSource = dt;
        }

        private void UcitajKategorije()
        {
            string query = "SELECT * FROM Kategorija";
            DataTable dtKategorije = bazaPodataka.IzvrsiUpit(query);
            cmbKategorija.DataSource = dtKategorije;
            cmbKategorija.DisplayMember = "naziv";
            cmbKategorija.ValueMember = "id_kategorije";
        }

        private void PostaviMinMaxVrednosti()
        {
            string queryMin = "SELECT MIN(cena_po_satu) FROM Vozilo";
            string queryMax = "SELECT MAX(cena_po_satu) FROM Vozilo";

            decimal minCena = Convert.ToDecimal(bazaPodataka.IzvrsiSkalarUpit(queryMin));
            decimal maxCena = Convert.ToDecimal(bazaPodataka.IzvrsiSkalarUpit(queryMax));

            nudMinCena.Minimum = minCena;
            nudMinCena.Maximum = maxCena;
            nudMinCena.Value = minCena;

            nudMaxCena.Minimum = minCena;
            nudMaxCena.Maximum = maxCena;
            nudMaxCena.Value = maxCena;

            DateTime trenutniDatumVreme = DateTime.Now;

            dtpPocetak.MinDate = trenutniDatumVreme;
            dtpPocetak.Value = trenutniDatumVreme;

            dtpKraj.MinDate = trenutniDatumVreme.AddHours(1);
            dtpKraj.Value = trenutniDatumVreme.AddHours(1);
        }

        private void dtpPocetak_ValueChanged(object sender, EventArgs e)
        {
            dtpKraj.MinDate = dtpPocetak.Value.AddHours(1);

            if (dtpKraj.Value < dtpKraj.MinDate)
            {
                dtpKraj.Value = dtpKraj.MinDate;
            }
        }

        private void PrimeniFilter()
        {
            if (dtpPocetak.Value > dtpKraj.Value)
            {
                MessageBox.Show("Datum i vreme početka mora biti pre datuma i vremena kraja.", "Greška u datumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudMinCena.Value > nudMaxCena.Value)
            {
                MessageBox.Show("Minimalna cena ne može biti veća od maksimalne cene.", "Greška u ceni", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nudMinCena.Value < nudMinCena.Minimum || nudMaxCena.Value > nudMaxCena.Maximum)
            {
                MessageBox.Show($"Cena mora biti u opsegu od {nudMinCena.Minimum} do {nudMaxCena.Maximum}.", "Greška u ceni", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "SELECT Vozilo.*, Kategorija.naziv AS Kategorija FROM Vozilo " +
                           "INNER JOIN Kategorija ON Vozilo.id_kategorije = Kategorija.id_kategorije WHERE 1=1";

            if (cmbKategorija.SelectedValue != null)
            {
                int idKategorije = Convert.ToInt32(cmbKategorija.SelectedValue);
                query += $" AND Vozilo.id_kategorije = {idKategorije}";
            }

            if (nudMinCena.Value > nudMinCena.Minimum)
            {
                query += $" AND Vozilo.cena_po_satu >= {nudMinCena.Value}";
            }
            if (nudMaxCena.Value < nudMaxCena.Maximum)
            {
                query += $" AND Vozilo.cena_po_satu <= {nudMaxCena.Value}";
            }

            if (dtpPocetak.Value != dtpPocetak.MinDate || dtpKraj.Value != dtpKraj.MaxDate)
            {
                query += $" AND Vozilo.id_vozila NOT IN (SELECT id_vozila FROM Rezervacija WHERE " +
                         $"(datumVreme_pocetka <= #{dtpKraj.Value.ToString("yyyy-MM-dd HH:mm:ss")}# " +
                         $"AND datumVreme_kraja >= #{dtpPocetak.Value.ToString("yyyy-MM-dd HH:mm:ss")}#))";
            }

            DataTable dt = bazaPodataka.IzvrsiUpit(query);
            dgvVozilaKategorije.DataSource = dt;
        }

        private void btnPrimeniFIlter_Click(object sender, EventArgs e)
        {
            PrimeniFilter();
        }

        private void btnIzbrisiFilter_Click(object sender, EventArgs e)
        {
            UcitajVozila();
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormDodajRezervaciju());
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormDodajVozilo());
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormDodajKategoriju());
        }

        private void btnIzvestaj_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormIzvestaj());
        }
        private string NajpopularnijeVozilo()
        {
            string query = @"
        SELECT TOP 1 
            v.id_vozila, 
            v.naziv, 
            v.marka, 
            v.model, 
            COUNT(r.id_rezervacija) AS broj_rezervacija
        FROM 
            Vozilo v
        JOIN 
            Rezervacija r ON v.id_vozila = r.id_vozila
        GROUP BY 
            v.id_vozila, v.naziv, v.marka, v.model
        ORDER BY 
            broj_rezervacija DESC;
    ";


            DataTable dt = bazaPodataka.IzvrsiUpit(query);


            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["naziv"].ToString();
            }

            return null;
        }

        private async void PrikaziAnimacijuNajpopularnijegVozila()
        {
            string najpopularnijeVozilo = NajpopularnijeVozilo();

            if (najpopularnijeVozilo != null)
            {
                while (true)
                {
                    lblAnimacija.Text = $"Najpopularnije vozilo: {najpopularnijeVozilo}";

                    for (int i = 0; i < 5; i++)
                    {
                        lblAnimacija.ForeColor = Color.Blue;
                        await Task.Delay(500);
                        lblAnimacija.ForeColor = Color.Yellow;
                        await Task.Delay(500);
                    }
                }
            }
        }

    }
}
