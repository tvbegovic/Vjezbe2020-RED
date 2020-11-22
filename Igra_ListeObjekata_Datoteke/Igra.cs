using System;
using System.Collections.Generic;
using System.Text;

namespace Igra_ListeObjekata_Datoteke
{
	public class Igra
	{
		private string naziv, opis, vrsta, izdavac;
		private decimal cijena;
		private DateTime datumIzdavanja;

		public string Naziv { 
			get => naziv; 
			set {
				if(string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Naziv ne smije biti prazan");
				}
				naziv = value;
			} 
		}
		public string Opis { get => opis; set => opis = value; }
		public string Vrsta
		{
			get => vrsta;
			set
			{
				if (string.IsNullOrEmpty(value))
					throw new ArgumentException("Vrsta mora biti unesena");
				vrsta = value;
			}
		}
		public string Izdavac { get => izdavac; set => izdavac = value; }
		public decimal Cijena { get => cijena; 
			set 
			{ 
				if(value < 0)
					throw new ArgumentException("Cijena mora biti pozitivna");
				cijena = value; 
			} 
		}
		public DateTime DatumIzdavanja
		{
			get => datumIzdavanja;
			set
			{
				if(datumIzdavanja > DateTime.Now)
					throw new ArgumentException("Datum izdavanja ne smije biti u budućnosti");
				datumIzdavanja = value;
			}
		}

		//Prva verzija unosa u klasu - funkcija koja unosi sve podatke odjednom
		public void UnesiPodatke(string naziv, string opis, string vrsta, string izdavac, decimal cijena, DateTime datumIzdavanja)
		{
			if (string.IsNullOrEmpty(naziv))
				throw new ArgumentException("Naziv ne smije biti prazan");
			this.naziv = naziv;
			this.opis = opis;
			if(string.IsNullOrEmpty(vrsta))
			{
				throw new ArgumentException("Vrsta mora biti unesena");
			}
			this.vrsta = vrsta;
			this.izdavac = izdavac;
			if(cijena < 0)
			{
				throw new ArgumentException("Cijena mora biti pozitivna");
			}
			this.cijena = cijena;
			if(datumIzdavanja > DateTime.Now)
			{
				throw new ArgumentException("Datum izdavanja ne smije biti u budućnosti");
			}
			this.datumIzdavanja = datumIzdavanja;
		}
	}
}
