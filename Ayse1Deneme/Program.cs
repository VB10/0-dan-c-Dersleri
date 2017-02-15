using System;

namespace Ayse1Deneme
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int x=0;
			Console.WriteLine(" 1-Toplama \n 2-Çıkarma \n 3-Çarpma \n 4-Bölme");
			Console.Write("Seçiminizi giriniz:");
			x = Convert.ToInt32(Console.ReadLine());
			calculator(x);

		}
		public static int result(int veli, int ayşe,string islem)
		{
			if (islem=="toplama")
			{
				return veli + ayşe;
			}
			else if (islem=="cikarma")
			{
				return veli - ayşe;
			}
			else if (islem == "carpma")
			{
				return veli * ayşe;
			}
			else if (islem == "bolme")
			{
				return veli / ayşe;
			}

			return 1;
		}

		public static void calculator(int x)
		{
			int sayi1, sayi2;

			if (x > 4 && x < 1)
			{
				Console.WriteLine("Hatali değer");
			}
			else
			{
				int islem_sonucu;
				Console.Write("Sayi 1:");
				sayi1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Sayi 2:");
				sayi2 = Convert.ToInt32(Console.ReadLine());

				if (x == 1)
				{
					
					islem_sonucu=result(sayi1, sayi2,"toplama");
				}
				else if (x == 2)
				{
					islem_sonucu = result(sayi1, sayi2, "cikarma");
				}
				else if (x == 3)
				{
					islem_sonucu = result(sayi1, sayi2, "carpma");
				}
				else
				{
					islem_sonucu = result(sayi1, sayi2, "bolme");
				}

				Console.WriteLine("Cevap:" + islem_sonucu);
			}



		}
	}
}
