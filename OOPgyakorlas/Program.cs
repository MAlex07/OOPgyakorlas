namespace OOPgyakorlas
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

		}
	}
}
