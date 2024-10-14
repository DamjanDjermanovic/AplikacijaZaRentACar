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
using TVPP2.Klase;

namespace TVPP2.Forme
{
    public partial class FormDodajRezervaciju : Form
    {
        private BazaPodataka bazaPodataka = new BazaPodataka();

        public FormDodajRezervaciju()
        {
            InitializeComponent(); 
        }

        private void FormDodajRezervaciju_Load(object sender, EventArgs e)
        {
            UcitajVozila();
            UcitajRezervacije();
            UcitajKlijente();
            PostaviMinMaxVrednosti();
        }

        private void PostaviMinMaxVrednosti()
        {
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
        private void UcitajVozila()
        {
            string query = "SELECT Vozilo.*, Kategorija.naziv AS Kategorija FROM Vozilo " +
                           "INNER JOIN Kategorija ON Vozilo.id_kategorije = Kategorija.id_kategorije";
            DataTable dtVozila = bazaPodataka.IzvrsiUpit(query);
            dgvVozila.DataSource = dtVozila;
            dgvVozila.Columns["id_vozila"].Visible = false;
            dgvVozila.Columns["id_kategorije"].Visible = false;
        }

        private void UcitajRezervacije()
        {
            string query = "SELECT Rezervacija.*, Vozilo.naziv AS VoziloNaziv FROM Rezervacija " +
                           "INNER JOIN Vozilo ON Rezervacija.id_vozila = Vozilo.id_vozila";
            DataTable dtRezervacije = bazaPodataka.IzvrsiUpit(query);
            dgvRezervacije.DataSource = dtRezervacije;
            dgvRezervacije.Columns["id_vozila"].Visible = false;
            dgvRezervacije.Columns["id_rezervacija"].Visible = false;
            dgvRezervacije.Columns["id_klijenta"].Visible = false;
        }
        private void UcitajKlijente()
        {
            string query = "SELECT * FROM Klijent";
            DataTable dtKlijenti = bazaPodataka.IzvrsiUpit(query);
            dgvKlijenti.DataSource = dtKlijenti;
            dgvKlijenti.Columns["id_klijenta"].Visible = false;
        }


        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormPocetna());
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            if (dgvVozila.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite vozilo.");
                return;
            }

            if (dgvKlijenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite klijenta.");
                return;
            }

            DataGridViewRow selektovaniVoziloRed = dgvVozila.SelectedRows[0];
            int idVozila = Convert.ToInt32(selektovaniVoziloRed.Cells["id_vozila"].Value);
            int cenaPoSatu = Convert.ToInt32(selektovaniVoziloRed.Cells["cena_po_satu"].Value);
            string kategorijaVozila = selektovaniVoziloRed.Cells["Kategorija"].Value.ToString();

            DataGridViewRow selektovaniKlijentRed = dgvKlijenti.SelectedRows[0];
            int idKlijenta = Convert.ToInt32(selektovaniKlijentRed.Cells["id_klijenta"].Value);
            string kategorijaVozaca = selektovaniKlijentRed.Cells["vozacka_kategorija"].Value.ToString();

            if (!MozeRezervisatiVozilo(kategorijaVozaca, kategorijaVozila))
            {
                MessageBox.Show("Vozač nema odgovarajuću kategoriju za ovo vozilo.");
                return;
            }

            if (dtpKraj.Value <= dtpPocetak.Value)
            {
                MessageBox.Show("Krajnji datum mora biti posle početnog.");
                return;
            }

            DateTime pocetak = dtpPocetak.Value;
            DateTime kraj = dtpKraj.Value;

            string query = $@"
                                SELECT COUNT(*) 
                                FROM Rezervacija 
                                WHERE id_vozila = {idVozila} 
                                AND (
                                    (datumVreme_pocetka <= #{pocetak.ToString("MM/dd/yyyy HH:mm:ss")}# AND datumVreme_kraja > #{pocetak.ToString("MM/dd/yyyy HH:mm:ss")}#)
                                    OR 
                                    (datumVreme_pocetka < #{kraj.ToString("MM/dd/yyyy HH:mm:ss")}# AND datumVreme_kraja >= #{kraj.ToString("MM/dd/yyyy HH:mm:ss")}#)
                                    OR
                                    (datumVreme_pocetka >= #{pocetak.ToString("MM/dd/yyyy HH:mm:ss")}# AND datumVreme_kraja <= #{kraj.ToString("MM/dd/yyyy HH:mm:ss")}#)
                                )";

            int existingReservations = Convert.ToInt32(bazaPodataka.IzvrsiSkalarUpit(query));

            if (existingReservations > 0)
            {
                MessageBox.Show("Izabrano vozilo je već rezervisano u tom vremenskom periodu. Molimo odaberite drugi period ili vozilo.");
                return;
            }

            TimeSpan razlikaVremena = kraj - pocetak;
            int ukupniSati = (int)Math.Ceiling(razlikaVremena.TotalHours);
            int ukupnaCena = ukupniSati * cenaPoSatu;

            string insertQuery = "INSERT INTO Rezervacija (id_vozila, id_klijenta, datumVreme_pocetka, datumVreme_kraja, cena) " +
                                 "VALUES (?, ?, ?, ?, ?)";

            OleDbParameter[] insertParameters = new OleDbParameter[]
            {
                new OleDbParameter("@id_vozila", OleDbType.Integer) { Value = idVozila },
                new OleDbParameter("@id_klijenta", OleDbType.Integer) { Value = idKlijenta },
                new OleDbParameter("@datumVreme_pocetka", OleDbType.Date) { Value = dtpPocetak.Value },
                new OleDbParameter("@datumVreme_kraja", OleDbType.Date) { Value = dtpKraj.Value },
                new OleDbParameter("@cena", OleDbType.Currency) { Value = ukupnaCena }
            };

            try
            {
                bazaPodataka.IzvrsiKomandu(insertQuery, insertParameters);
                MessageBox.Show("Rezervacija je uspešno dodata.");
                UcitajRezervacije();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dodavanja rezervacije: " + ex.Message);
            }
        }



        private bool MozeRezervisatiVozilo(string kategorijaVozaca, string kategorijaVozila)
        {
            string[] dozvoljeneKategorije = { "A", "B", "C", "D", "E" };

            int indeksVozaca = Array.IndexOf(dozvoljeneKategorije, kategorijaVozaca.ToUpper());
            int indeksVozila = Array.IndexOf(dozvoljeneKategorije, kategorijaVozila.ToUpper());

            return indeksVozaca >= indeksVozila;
        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormDodajKlijenta());
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (dgvRezervacije.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite rezervaciju za brisanje.");
                return;
            }

            DataGridViewRow selektovaniRed = dgvRezervacije.SelectedRows[0];
            int idRezervacije = Convert.ToInt32(selektovaniRed.Cells["id_rezervacija"].Value);

            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da izbrišete ovu rezervaciju?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Rezervacija WHERE id_rezervacija = ?";
                    OleDbParameter[] parameters = new OleDbParameter[]
                    {
                        new OleDbParameter("@id_rezervacija", OleDbType.Integer) { Value = idRezervacije }
                    };

                    bazaPodataka.IzvrsiKomandu(query, parameters);

                    dgvRezervacije.Rows.RemoveAt(selektovaniRed.Index);

                    MessageBox.Show("Rezervacija je uspešno obrisana.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška prilikom brisanja rezervacije: " + ex.Message);
                }
            }
        }
    }
}
