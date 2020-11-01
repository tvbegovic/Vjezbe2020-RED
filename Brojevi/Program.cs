using System;
using System.Net.Sockets;

namespace Brojevi
{
	class Program
	{
		static void Main(string[] args)
		{
			var nastavi = true;
			do
			{
				Console.Write("Unesite broj elemenata niza (1-100.000): ");
				var unos = Console.ReadLine();
				if(string.IsNullOrEmpty(unos))
				{
					nastavi = false;
				}
				else
				{
					var ok = int.TryParse(unos, out int n);
					if(!ok)
					{
						Console.WriteLine("Pogrešan format");
						continue;
					}
					if(n < 1 || n > 100000)
					{
						Console.WriteLine("Broj je izvan raspona");
						continue;
					}
					int[] brojevi = new int[n];
					var i = 0;
					while(i< n)
					{
						Console.Write("Unesite {0}. element: ", i + 1);
						unos = Console.ReadLine();
						ok = int.TryParse(unos, out brojevi[i]);
						if(!ok)
						{
							Console.WriteLine("Pogrešan format");
							continue;
						}
						i++;
					}
					Console.Write("Unijeli ste polje: ");
					Console.WriteLine();
					foreach (var broj in brojevi)
					{
						Console.Write("{0} ", broj);
					}
					long suma = 0;
					int max = int.MinValue, min = int.MaxValue;
					foreach (var broj in brojevi)
					{
						suma += broj;
						if (broj < min)
							min = broj;
						if (broj > max)
							max = broj;
					}
					var prosjek = suma * 1.0 / n;
					Console.WriteLine("Suma elemenata polja je {0:N0}", suma);
					Console.WriteLine("Prosjek elemenata polja je {0:N2}", prosjek);
					Console.WriteLine("Najveći element polja je {0:N0}", max);
					Console.WriteLine("Najmanji element polja je {0:N0}", min);

				}

			} while (nastavi);
		}
	}
}
