using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igra_ListeObjekata_Datoteke
{
	public partial class Glavna : Form
	{
		public Glavna()
		{
			InitializeComponent();
		}

		List<Igra> igre = new List<Igra>();

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
				
				var igra = new Igra
				{
					Naziv = txtNaziv.Text,
					Opis = txtOpis.Text,
					Vrsta = txtVrsta.Text,
					Izdavac = txtIzdavac.Text,
					Cijena = cijena,
					DatumIzdavanja = datum
				};

				igre.Add(igra);
				AzurirajListBox();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}");
			}
		}

		void AzurirajListBox()
		{
			lstIgre.DataSource = null;
			lstIgre.DataSource = igre;
			lstIgre.DisplayMember = "Naziv";
		}

		private void btnUkloni_Click(object sender, EventArgs e)
		{
			var index = lstIgre.SelectedIndex;
			if(index >= 0)
			{
				igre.RemoveAt(index);
				AzurirajListBox();
			}
		}
	}
}
