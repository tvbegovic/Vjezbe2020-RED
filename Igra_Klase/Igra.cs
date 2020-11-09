using System;
using System.Collections.Generic;
using System.Text;

namespace Igra_Klase
{
	public class Igra
	{
		private string naziv, opis, vrsta, izdavac;
		private decimal cijena;
		private DateTime datumIzdavanja;

		public void UnesiPodatke(string naziv, string opis, string vrsta, string izdavac, decimal cijena, DateTime datumIzdavanja)
		{
			this.naziv = naziv;
			this.opis = opis;
			this.vrsta = vrsta;
			this.izdavac = izdavac;
			this.cijena = cijena;
			this.datumIzdavanja = datumIzdavanja;
		}
	}
}
