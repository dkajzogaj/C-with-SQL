using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiketv1._0.Models;
using Tiketv1._0.Repositories;

namespace Tiketv1._0
{
    public partial class FrmDodajiPromjeni : Form
    {
        FrmTiket pocetnaForma = new FrmTiket();
        public FrmDodajiPromjeni()
        {
            InitializeComponent();
        }

        private void FrmDodajiPromjeni_Load(object sender, EventArgs e)
        {
            var gosti = ImeRepository.DohvatiImena();
            cboIzmjena.DataSource = gosti;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtIme.Text == "" || txtPrezime.Text == "" || txtOIB.Text == "" || txtVrsta.Text == "" || txtBroj.Text == "" || TxtPozicija.Text == "")
            {
                MessageBox.Show("Niste unijeli sve podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string Ime = txtIme.Text.ToString();
                string Prezime = txtPrezime.Text.ToString();
                int OIB = Int32.Parse(txtOIB.Text);
                string Vrsta = txtVrsta.Text.ToString();
                int Broj = Int32.Parse(txtBroj.Text);
                int Pozicija = Int32.Parse(TxtPozicija.Text);

                string sql = $"INSERT INTO Gosti (Ime, Prezime, OIB, VrstaSmjestaja, BrojOsobaUSmjestaju, PozicijaSmjestaja) VALUES ('{Ime}', '{Prezime}', {OIB}, '{Vrsta}', {Broj}, {Pozicija})";

                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
            }
            Close();
            pocetnaForma.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trenutnoIme = cboIzmjena.SelectedItem as Gost;
            txtImeI.Text = trenutnoIme.Ime;
            txtPrezimeI.Text = trenutnoIme.Prezime;
            txtOIBI.Text = trenutnoIme.OIB.ToString();
            txtVrstaI.Text = trenutnoIme.VrstaSmjestaja;
            txtBrojI.Text = trenutnoIme.BrojOsobaUSmjestaju.ToString();
            txtPozicijaI.Text = trenutnoIme.PozicijaSmjestaja.ToString();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (txtImeI.Text == "" || txtPrezimeI.Text == "" || txtOIBI.Text == "" || txtVrstaI.Text == "" || txtBrojI.Text == "" || txtPozicijaI.Text == "")
            {
                MessageBox.Show("Niste unijeli sve podatke", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var trenutnoIme = cboIzmjena.SelectedItem as Gost;
                string ImeI = txtImeI.Text.ToString();
                string PrezimeI = txtPrezimeI.Text.ToString();
                int OIBI = Int32.Parse(txtOIBI.Text);
                string VrstaI = txtVrstaI.Text.ToString();
                int BrojI = Int32.Parse(txtBrojI.Text);
                int PozicijaI = Int32.Parse(txtPozicijaI.Text);

                string sql = $"Update Gosti  SET Ime = '{ImeI}', Prezime = '{PrezimeI}', OIB = {OIBI}, VrstaSmjestaja = '{VrstaI}', BrojOsobaUSmjestaju =  {BrojI}, PozicijaSmjestaja = {PozicijaI} WHERE Id = {trenutnoIme.Id} ";

                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
            }
            Close();
            pocetnaForma.Show();

        }

        private void FrmDodajiPromjeni_FormClosing(object sender, FormClosingEventArgs e)
        {
            pocetnaForma.Show();
        }
    }
}
