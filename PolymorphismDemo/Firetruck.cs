// Chris Cascioli
// 11/4/24
// Example child class

namespace PolymorphismDemo
{
	internal class Firetruck : Vehicle
	{
		// Constructor
		/// <summary>
		/// Creates a firetruck with a specific name
		/// </summary>
		/// <param name="name">Name of the firetruck</param>
		public Firetruck(string name)
			: base(name)
		{
            Console.WriteLine("FIRETRUCK constructor");
		}

		// Methods

		/// <summary>
		/// Simulates shooting water
		/// </summary>
		public void ShootWater()
		{
            Console.WriteLine($"Firetruck {name} sprays water!");
		}

		/// <summary>
		/// A firetruck-specific version of drive
		/// </summary>
		public override void Drive()
		{
            Console.WriteLine($"Firetruck {name} is flying down the street with its siren blaring!");
		}

		/// <summary>
		/// A further-overridden version of the method
		/// </summary>
		/// <returns>Firetruck specific string</returns>
		public override string ToString()
		{
			return base.ToString() + " is definitely a firetruck!";
		}
	}
}
