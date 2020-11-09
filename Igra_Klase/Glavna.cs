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
			var ok = decimal.TryParse(txtCijena.Text, out decimal cijena);
			if(!ok)
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
			var igra = new Igra();
			igra.UnesiPodatke(txtNaziv.Text, txtOpis.Text, txtVrsta.Text, txtIzdavac.Text, cijena, datum);
			MessageBox.Show("Uspješno ste unijeli podatke");
		}
	}
}
