using System;

namespace Inicijali
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Unesite vaše ime: ");
			var ime = Console.ReadLine();
			Console.Write("Unesite vaše prezime: ");
			var prezime = Console.ReadLine();
			if(string.IsNullOrEmpty(ime) || string.IsNullOrEmpty(prezime))
			{
				Console.WriteLine("Ime i prezime moraju imati bar jedno slovo");
				return;
			}
			Console.WriteLine("Vaši inicijali su: {0}. {1}.", ime.Substring(0, 1), prezime.Substring(0, 1));
		}
	}
}
