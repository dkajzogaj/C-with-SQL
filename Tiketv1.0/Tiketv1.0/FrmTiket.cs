using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiketv1._0.Models;
using Tiketv1._0.Repositories;

namespace Tiketv1._0
{
    public partial class FrmTiket : Form
    {
        public FrmTiket()
        {
            InitializeComponent();
            DB.SetConfiguration("dkajzogaj20_DB", "dkajzogaj20", "9v@*Njw#");
        }

        private Gost gost;

        private FrmTiket(Gost odabraniGost)
        {
            InitializeComponent();
            gost = odabraniGost;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowGosti();

            var gosti = ImeRepository.DohvatiImena();
            cboIme.DataSource = gosti;
        }

        public void ShowGosti()
        {
            List<Gost> gosti = GostRepository.GetGosti();
            dgvGosti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGosti.DataSource = gosti;

            //Prikaz stupaca po redu
            dgvGosti.Columns["Id"].DisplayIndex = 0;
            dgvGosti.Columns["Ime"].DisplayIndex = 1;
            dgvGosti.Columns["Prezime"].DisplayIndex = 2;
            dgvGosti.Columns["OIB"].DisplayIndex = 3;
            dgvGosti.Columns["VrstaSmjestaja"].DisplayIndex = 4;
            dgvGosti.Columns["BrojOsobaUSmjestaju"].DisplayIndex = 5;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            List<Gost> gosti = GostRepository.GetGosti();

            if (dgvGosti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali Gosta", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int indeks = dgvGosti.SelectedRows[0].Index;

                Gost odabraniGost = dgvGosti.CurrentRow.DataBoundItem as Gost;

                if (odabraniGost != null)
                {
                    int id = Convert.ToInt32(dgvGosti[0, indeks].Value);

                    string sql = $"DELETE FROM Gosti WHERE Id = {id}";

                    DB.OpenConnection();
                    DB.ExecuteCommand(sql);
                    DB.CloseConnection();
                    MessageBox.Show("Uspješno obrisan gost");
                }
            }
            ShowGosti();
            var gosti2 = ImeRepository.DohvatiImena();
            cboIme.DataSource = gosti2;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodajiPromjeni frmDodajiPromjeni = new FrmDodajiPromjeni();
            Hide();
            frmDodajiPromjeni.ShowDialog();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Gost odabraniGost = dgvGosti.CurrentRow.DataBoundItem as Gost;
            if (odabraniGost != null)
            {
                FrmDodajiPromjeni frmDodajiPromjeni = new FrmDodajiPromjeni();
                Hide();
                frmDodajiPromjeni.ShowDialog();
            }
        }


        private void cboIme_SelectedIndexChanged(object sender, EventArgs e)
        {
                var trenutnoIme = cboIme.SelectedItem as Gost;
                txtPrikazGosta.Text = trenutnoIme.Ime + " " + trenutnoIme.Prezime;
                txtOIB.Text = trenutnoIme.OIB.ToString();
                txtVrsta.Text = trenutnoIme.VrstaSmjestaja;
                txtPozicija.Text = trenutnoIme.PozicijaSmjestaja.ToString();
        }

        private void dgvGosti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                int indeks = dgvGosti.SelectedRows[0].Index;
                string Ime = Convert.ToString(dgvGosti[1, indeks].Value);
                string Prezime = Convert.ToString(dgvGosti[2, indeks].Value);
                int OIB = Convert.ToInt32(dgvGosti[3, indeks].Value);
                string Vrsta = Convert.ToString(dgvGosti[4, indeks].Value);
                int Pozicija = Convert.ToInt32(dgvGosti[5, indeks].Value);


                txtPrikazGosta.Text = Ime + " " + Prezime;
                txtOIB.Text = OIB.ToString();
                txtVrsta.Text = Vrsta;
                txtPozicija.Text = Pozicija.ToString();
            }

        private void btnObrisi2_Click(object sender, EventArgs e)
        {
            if (txtPrikazGosta.Text == "" || txtPrikazGosta.Text == "" || txtPozicija.Text == "" || txtVrsta.Text == "")
            {
                MessageBox.Show("Niste odabrali Gosta", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (txtOIB.Text != "" && txtPrikazGosta.Text != "" && txtPozicija.Text != "" && txtVrsta.Text != "")
                {
                    int id = Int32.Parse(txtOIB.Text);

                    string sql = $"DELETE FROM Gosti WHERE OIB = {id}";

                    DB.OpenConnection();
                    DB.ExecuteCommand(sql);
                    DB.CloseConnection();
                    MessageBox.Show("Uspješno obrisan gost");
                }
            }
            ShowGosti();
            var gosti = ImeRepository.DohvatiImena();
            cboIme.DataSource = gosti;
        }

        private void FrmTiket_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
