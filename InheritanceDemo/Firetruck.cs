// Chris Cascioli
// 10/30/24
// Example of a child (or derived) class

namespace InheritanceDemo
{
	internal class Firetruck : Vehicle
	{
		// Fields
		private bool siren;
		private double ladderLength;

		// Properties
		public bool Siren { get { return siren; } set { siren = value; } }

		// Constructor

		/// <summary>
		/// Creates a new firetruck
		/// </summary>
		/// <param name="make">Manufacturer</param>
		/// <param name="model">Specific model</param>
		/// <param name="ladderLength">Length of the ladder</param>
		public Firetruck(string make, string model, double ladderLength) 
			: base(make, model)
		{
			this.siren = false;
			this.ladderLength = ladderLength;
		}

		// Method

		/// <summary>
		/// Simulates the firetruck shooting water
		/// </summary>
		public void ShootWater()
		{
			Console.WriteLine($"Firetruck {make} {model} shoots water");
		}
	}
}
