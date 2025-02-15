﻿namespace OOPgyakorlas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Konyv konyv1 = new("A Kis Hereceg", "Antoine de Saint-Exupéry", 1943, 96, 2500);
			Konyv kony2 = new("Ez még készül", "Én");

            Console.WriteLine(konyv1.ToString() + "\n" + kony2.ToString());

			konyv1.Kedvezmeny(20);
			konyv1.Arnoveles(1000);

			Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyoldalMaradt(20));

			Film film1 = new("Halálos Iramben", "Rob Cohen", 101, "akció film", true);
			Film film2 = new("Még nem tudom a címét", "Én");

            Console.WriteLine(film1.ToString() + "\n" + film2.ToString());

			film1.Jatszas();
			film1.MufajModositas("vígjáték");
			film1.HosszNovelese(30);

            Console.WriteLine("\n" + film1.ToString());

			Karakter karakter1 = new("Trevor", 30, 100, 100);
			Karakter karakter2 = new("Nem tudom", 60);

            Console.WriteLine(karakter1.ToString() + "\n" + karakter2.ToString());

			karakter1.Tamadas();
			karakter1.Gyogyulas(30);
			karakter1.Szintlepes(50, 20);

            Console.WriteLine("\n" + karakter1.ToString());

			Urhajo urhajo1 = new("Appolo 20", 500, 10, 100);
			Urhajo urhajo2 = new("Szputnyik 5", 10);

            Console.WriteLine(urhajo1.ToString() + "\n" + urhajo2.ToString());

			KemKuldetes kuldetes1 = new("A007", "USA", 3, 60);
			KemKuldetes kuldetes2 = new("B007", "Kuba");

            Console.WriteLine(kuldetes1.ToString() + "\n" + kuldetes2.ToString());

			kuldetes1.KuldetesInditasa();
			kuldetes1.VeszelySzintNovelese(2);
			kuldetes1.SikerEselyNovelese(10);

            Console.WriteLine("\n" + kuldetes1.ToString());



        }
	}
}
