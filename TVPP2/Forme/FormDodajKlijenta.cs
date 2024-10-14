using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVPP2.Klase;

namespace TVPP2.Forme
{
    public partial class FormDodajKlijenta : Form
    {
        private BazaPodataka bazaPodataka = new BazaPodataka();
        public FormDodajKlijenta()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormDodajRezervaciju());
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbIme.Text))
            {
                MessageBox.Show("Ime je obavezno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbPrezime.Text))
            {
                MessageBox.Show("Prezime je obavezno.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbKategorija.SelectedItem == null)
            {
                MessageBox.Show("Kategorija je obavezna.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbTelefon.Text))
            {
                MessageBox.Show("Telefon je obavezan.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbAdresa.Text))
            {
                MessageBox.Show("Adresa je obavezna.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ime = tbIme.Text.Trim();
            string prezime = tbPrezime.Text.Trim();
            string kategorija = cmbKategorija.SelectedItem.ToString();
            string telefon = tbTelefon.Text.Trim();
            string adresa = tbAdresa.Text.Trim();

            if (KlijentVecPostoji(telefon, adresa))
            {
                MessageBox.Show("Klijent sa istim telefonom i adresom već postoji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = $"INSERT INTO Klijent (ime, prezime, adresa, telefon, vozacka_kategorija) " +
                           $"VALUES ('{ime}', '{prezime}', '{adresa}', '{telefon}', '{kategorija}')";

            try
            {
                bazaPodataka.IzvrsiKomandu(query);
                MessageBox.Show("Klijent je uspešno dodat.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Globalne.ZameniFormu(this, new FormDodajRezervaciju());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom dodavanja klijenta: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool KlijentVecPostoji(string telefon, string adresa)
        {
            string query = $"SELECT COUNT(*) FROM Klijent WHERE telefon = '{telefon}' AND adresa = '{adresa}'";
            int brojPostojecih = Convert.ToInt32(bazaPodataka.IzvrsiSkalarUpit(query));

            return brojPostojecih > 0;
        }

        private void FormDodajKlijenta_Load(object sender, EventArgs e)
        {
            cmbKategorija.Items.Add("A");
            cmbKategorija.Items.Add("B");
            cmbKategorija.Items.Add("C");
            cmbKategorija.Items.Add("D");
            cmbKategorija.Items.Add("E");

            cmbKategorija.SelectedIndex = 0;
        }
    }
}
