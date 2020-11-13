using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igra_Klase
{
	public partial class Glavna : Form
	{
		public Glavna()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnUnesi_Click(object sender, EventArgs e)
		{
			try
			{
				var ok = decimal.TryParse(txtCijena.Text, out decimal cijena);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format cijene");
					return;
				}
				ok = DateTime.TryParse(txtDatumIzdavanja.Text, out DateTime datum);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format datuma");
					return;
				}

				//U prvoj verziji smo slali podatke preko metode UnesiPodatke
				//var igra = new Igra();
				//igra.UnesiPodatke(txtNaziv.Text, txtOpis.Text, txtVrsta.Text, txtIzdavac.Text, cijena, datum);

				//Druga verzija - properties
				var igra = new Igra();
				igra.Naziv = txtNaziv.Text;
				igra.Opis = txtOpis.Text;
				igra.Vrsta = txtVrsta.Text;
				igra.Izdavac = txtIzdavac.Text;
				igra.Cijena = cijena;
				igra.DatumIzdavanja = datum;

				//Alternativa - Simplificarano kreiranje novog objekta i automatska dodjela
				igra = new Igra
				{
					Naziv = txtNaziv.Text,
					Opis = txtOpis.Text,
					Vrsta = txtVrsta.Text,
					Izdavac = txtIzdavac.Text,
					Cijena = cijena,
					DatumIzdavanja = datum
				};

				MessageBox.Show("Uspješno ste unijeli podatke");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}");
			}
		}
	}
}
