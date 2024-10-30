// Chris Cascioli
// 10/30/24
// Demo of inheritance (parent/child classes)

namespace InheritanceDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Vehicle v = new Vehicle("VW", "Jetta");
			v.Drive(5);

			Firetruck f = new Firetruck("Bob's Firetrucks & More", "FT2000", 10);
			f.Drive(10);
			f.ShootWater();
		}
	}
}
