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
    public partial class FormDodajKategoriju : Form
    {
        private BazaPodataka bazaPodataka = new BazaPodataka();
        private string[] dozvoljeneKategorije = new string[]
        {
            "a",
            "b",
            "c",
            "d",
            "e"
        };
        public FormDodajKategoriju()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Globalne.ZameniFormu(this, new FormPocetna());
        }

        private void FormDodajKategoriju_Load(object sender, EventArgs e)
        {
            string query = "SELECT naziv FROM Kategorija";
            DataTable dtPostojeceKategorije = bazaPodataka.IzvrsiUpit(query);

            var postojeceKategorije = dtPostojeceKategorije.AsEnumerable()
                .Select(row => row.Field<string>("naziv")).ToList();

            var dostupneKategorije = dozvoljeneKategorije.Except(postojeceKategorije).ToList();

            cmbKategorija.DataSource = dostupneKategorije;
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (cmbKategorija.SelectedIndex == -1 || string.IsNullOrWhiteSpace(tbOpis.Text))
            {
                MessageBox.Show("Morate izabrati kategoriju i uneti opis.");
                return;
            }

            string nazivKategorije = cmbKategorija.SelectedItem.ToString();
            string opis = tbOpis.Text;

            string query = "INSERT INTO Kategorija (naziv, opis) VALUES (?, ?)";

            OleDbParameter[] parameters = new OleDbParameter[]
            {
                new OleDbParameter("@naziv", OleDbType.VarChar) { Value = nazivKategorije },
                new OleDbParameter("@opis", OleDbType.VarChar) { Value = opis }
            };

            try
            {
                bazaPodataka.IzvrsiKomandu(query, parameters);
                MessageBox.Show("Kategorija je uspešno dodata.");
                Globalne.ZameniFormu(this, new FormPocetna());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dodavanja kategorije: " + ex.Message);
            }
        }
    }
}
