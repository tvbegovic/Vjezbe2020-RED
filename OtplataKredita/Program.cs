using System;

namespace OtplataKredita
{
	class Program
	{
		public static void IzracunParametara(double iznos, double stopa, int brojGodina, out double anuitet, out double iznosKamata)
		{
			if(iznos < 0 || stopa < 0 || brojGodina < 0)
			{
				throw new ArgumentException("Iznos, stopa i broj godina moraju biti pozitivni brojevi");
			} 
			if(stopa < 2 || stopa > 15)
			{
				throw new ArgumentOutOfRangeException("Stopa nije u rasponu 2-15");
			}
			if(brojGodina < 3 || brojGodina > 30)
			{
				throw new ArgumentOutOfRangeException("Broj godina treba biti u rasponu 3-30");
			}
			var r = Kamatnjak(stopa);
			var n = brojGodina * 12;
			anuitet = iznos * Math.Pow(r, n) * (r - 1) / (Math.Pow(r, n) - 1);
			iznosKamata = anuitet * n - iznos;
		}

		public static double Kamatnjak(double stopa)
		{
			return Math.Pow(1 + stopa / 100, 1 / 12.0);
			//return 1 + (stopa / 12.0) / 100;
		}


		static void Main(string[] args)
		{
			var nastavi = true;
			do
			{
				try
				{
					Console.Write("Iznos: ");
					var unos = Console.ReadLine();
					if (string.IsNullOrEmpty(unos))
					{
						nastavi = false;
					}
					else
					{
						var ok = double.TryParse(unos, out double glavnica);
						if (!ok)
						{
							Console.WriteLine("Pogrešan format");
							continue;
						}
						Console.Write("Stopa (%): ");
						unos = Console.ReadLine();
						ok = double.TryParse(unos, out double stopa);
						if (!ok)
						{
							Console.WriteLine("Pogrešan format");
							continue;
						}
						Console.Write("Broj godina: ");
						unos = Console.ReadLine();
						ok = int.TryParse(unos, out int godine);
						if (!ok)
						{
							Console.WriteLine("Pogrešan format");
							continue;
						}
						IzracunParametara(glavnica, stopa, godine, out double anuitet, out double iznosKamata);
						Console.WriteLine("Za zadani iznos kredita {0:N2}, godišnju kamatnu stopu {1} i broj godina otplate {2} anuitet je {3:N2} a ukupno plaćena kamata {4:N2}",
							glavnica, stopa, godine, anuitet, iznosKamata);
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Dogodila se pogreška. Tekst: {0}", ex.Message);
				}

			} while (nastavi);
		}
	}
}
