using System;

namespace ProsjekOcjena
{
	class Program
	{
		static void Main(string[] args)
		{

			try
			{
				Console.Write("Unesite ocjenu za C: ");
				var unos = Console.ReadLine();
				var ocjenaC = int.Parse(unos);

				Console.WriteLine("Unesite ocjena za C++: ");
				unos = Console.ReadLine();
				var ocjenaCPlus = int.Parse(unos);

				Console.WriteLine("Unesite ocjena za C#: ");
				unos = Console.ReadLine();
				var ocjenaCSharp = int.Parse(unos);

				var prosjek = (ocjenaC + ocjenaCPlus + ocjenaCSharp) / 3.0;

				Console.WriteLine("Prosjek ocjena za ova tri predmeta je {0:N2}", prosjek);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Dogodila se pogreška. Tekst: {0}", ex.Message);
			}


		}
	}
}
