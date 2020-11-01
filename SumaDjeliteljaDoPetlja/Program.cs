using System;

namespace SumaDjeliteljaDoPetlja
{
	class Program
	{
		static void Main(string[] args)
		{
			var nastavi = true;
			do
			{
				Console.Write("Unesite broj (1-100.000): ");
				var unos = Console.ReadLine();
				if(string.IsNullOrEmpty(unos))
				{
					nastavi = false;
				}
				else
				{
					var ok = int.TryParse(unos, out int broj);
					if (!ok)
					{
						Console.WriteLine("Pogrešan format broja");
						continue;
					}
					if (broj < 1 || broj > 100000)
					{
						Console.WriteLine("Broj je izvan raspona");
						continue;
					}

					long suma = 0;
					for (int i = 1; i < broj; i++)
					{
						if (i % 3 == 0 || i % 5 == 0)
							suma += i;
					}

					Console.WriteLine("Suma brojeva djeljivih s 3 ili 5 između 1 i {0} je {1:N0}", broj, suma); 
				}

			} while (nastavi);
		}
	}
}
