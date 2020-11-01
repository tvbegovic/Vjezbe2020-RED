using System;

namespace DatumiRodenja
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Unesite datum rođenja osobe 1: ");
			var unos = Console.ReadLine();
			var ok = DateTime.TryParse(unos, out DateTime datum1);
			if(!ok)
			{
				Console.WriteLine("Neispravan format datuma.");
				return;
			}
			Console.Write("Unesite datum rođenja osobe 2:");
			unos = Console.ReadLine();
			ok = DateTime.TryParse(unos, out DateTime datum2);
			if (!ok)
			{
				Console.WriteLine("Neispravan format datuma.");
				return;
			}
			if(datum1 < datum2)
			{
				Console.WriteLine("Osoba 1 je starija od osobe 2 za {0} dana.", (datum2 - datum1).TotalDays);
			}
			else if(datum2 < datum1)
			{
				Console.WriteLine("Osoba 2 je starija od osobe 1 za {0} dana.", (datum1 - datum2).TotalDays);
			}
			else
			{
				Console.WriteLine("Obje osobe su rođene istog datuma");
			}
			
			if(datum1.DayOfYear < datum2.DayOfYear)
			{
				Console.WriteLine("Osoba 1 slavi rođendan prije osobe 2");
			}
			else if(datum2.DayOfYear < datum1.DayOfYear)
			{
				Console.WriteLine("Osoba 2 slavi rođendan prije osobe 1");
			}
			else
			{
				Console.WriteLine("Osobe imaju rođendan na isti dan");
			}
		}
	}
}
