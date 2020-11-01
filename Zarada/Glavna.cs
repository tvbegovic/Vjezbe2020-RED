using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zarada
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

		public double Zarada(double brojSati, double cijenaSata = 40.0, double porez = 0.2)
		{
			if (brojSati < 0)
				throw new ArgumentException("Broj sati mora biti > 0");
			if (cijenaSata < 10)
				throw new ArgumentException("Cijena sata mora biti >= 10");
			if(porez < 0.1 || porez > 0.4)
			{
				throw new ArgumentOutOfRangeException("Porez moram biti između 10% i 40%");
			}
			return brojSati * cijenaSata * (1 - porez);
		}


		private void btnIzracunaj_Click(object sender, EventArgs e)
		{
			try
			{
				var ok = double.TryParse(txtBrojSati.Text, out double brojSati);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format broja sati");
					return;
				}
				ok = double.TryParse(txtCijenaSata.Text, out double cijena);
				if(!ok)
				{
					MessageBox.Show("Pogrešan format cijene");
					return;
				}
				ok = double.TryParse(txtPorez.Text, out double porez);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format poreza");
					return;
				}
				porez /= 100;
				lblZarada1.Text = Zarada(brojSati, cijena, porez).ToString("N2");
				lblZarada2.Text = Zarada(brojSati, porez: porez).ToString("N2");
				lblZarada3.Text = Zarada(brojSati, cijenaSata: cijena).ToString("N2");
				lblZarada4.Text = Zarada(brojSati).ToString("N2");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Pogreška. Tekst: {ex.Message}");
			}
		}
	}
}
