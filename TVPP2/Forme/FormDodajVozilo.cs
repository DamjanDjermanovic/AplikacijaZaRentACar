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
    public partial class FormDodajVozilo : Form
    {
        private BazaPodataka bazaPodataka = new BazaPodataka();

        public FormDodajVozilo()
        {
            InitializeComponent();
        }

        private void FormDodajVozilo_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Kategorija";
            DataTable dtKategorije = bazaPodataka.IzvrsiUpit(query);
            cmbKategorija.DataSource = dtKategorije;
            cmbKategorija.DisplayMember = "naziv";
            cmbKategorija.ValueMember = "id_kategorije";
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormPocetna());
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNaziv.Text) ||
                string.IsNullOrWhiteSpace(tbModel.Text) ||
                string.IsNullOrWhiteSpace(tbGodinaProizvodnje.Text) ||
                string.IsNullOrWhiteSpace(tbCenaPoSatu.Text) ||
                string.IsNullOrWhiteSpace(tbMarka.Text) ||
                cmbKategorija.SelectedIndex == -1)
            {
                MessageBox.Show("Sva polja moraju biti popunjena.");
                return;
            }

            if (!int.TryParse(tbGodinaProizvodnje.Text, out int godinaProizvodnje) ||
                godinaProizvodnje < 1990 || godinaProizvodnje > DateTime.Now.Year)
            {
                MessageBox.Show("Godina proizvodnje mora biti između 1990 i trenutne godine.");
                return;
            }

            if (!int.TryParse(tbCenaPoSatu.Text, out int cenaPoSatu) || cenaPoSatu <= 0)
            {
                MessageBox.Show("Cena po satu mora biti pozitivan broj.");
                return;
            }

            int idKategorije = Convert.ToInt32(cmbKategorija.SelectedValue);

            string query = "INSERT INTO Vozilo (naziv, model, godina_proizvodnje, cena_po_satu, id_kategorije, marka) " +
                           "VALUES (?, ?, ?, ?, ?, ?)";

            OleDbParameter[] parameters = new OleDbParameter[]
            {
                new OleDbParameter("@naziv", OleDbType.VarChar) { Value = tbNaziv.Text },
                new OleDbParameter("@model", OleDbType.VarChar) { Value = tbModel.Text },
                new OleDbParameter("@godina_proizvodnje", OleDbType.Integer) { Value = godinaProizvodnje },
                new OleDbParameter("@cena_po_satu", OleDbType.Integer) { Value = cenaPoSatu },
                new OleDbParameter("@id_kategorije", OleDbType.Integer) { Value = idKategorije },
                new OleDbParameter("@marka", OleDbType.VarChar) { Value = tbMarka.Text }
            };

            try
            {
                bazaPodataka.IzvrsiKomandu(query, parameters);
                MessageBox.Show("Vozilo je uspešno dodato.");
                Globalne.ZameniFormu(this, new FormPocetna());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dodavanja vozila: " + ex.Message);
            }
        }

    }
}
