using System;

namespace ProsjekOcjenaTryParse
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Unesite ocjenu za C: ");
			var unos = Console.ReadLine();

			var ok = int.TryParse(unos, out int ocjenaC);
			if (!ok)
			{
				Console.WriteLine("Pogrešan format broja.");
				return;
			}

			Console.Write("Unesite ocjenu za C++: ");
			unos = Console.ReadLine();

			ok = int.TryParse(unos, out int ocjenaCPlus);
			if (!ok)
			{
				Console.WriteLine("Pogrešan format broja.");
				return;
			}

			Console.Write("Unesite ocjenu za C#: ");
			unos = Console.ReadLine();

			ok = int.TryParse(unos, out int ocjenaCSharp);
			if (!ok)
			{
				Console.WriteLine("Pogrešan format broja.");
				return;
			}

			var prosjek = (ocjenaC + ocjenaCPlus + ocjenaCSharp) / 3.0;

			Console.WriteLine("Prosjek ocjena za ova tri predmeta je {0:N2}", prosjek);
		}
	}
}
