// Chris Cascioli
// 11/15/24
// Example of using an interface to guarantee class behavior

namespace InterfaceDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create objects that are not related
			Player p1 = new Player("Steve");
			Enemy e1 = new Enemy();
			Enemy e2 = new Enemy();

			// If these all implement the same interface,
			// they count as that interface's type
			List<IDamageable> targets = new List<IDamageable>();
			targets.Add(p1);
			targets.Add(e1);
			targets.Add(e2);

			// Deal damage to everything
			foreach (IDamageable target in targets)
			{
				target.TakeDamage(4);
			}

			// See if the damage was recorded
            Console.WriteLine(p1);
		}
	}
}
