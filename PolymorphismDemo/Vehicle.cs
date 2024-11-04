// Chris Cascioli
// 11/4/24
// Simple parent class

namespace PolymorphismDemo
{
	internal class Vehicle
	{
		// Fields
		protected string name;

		// Properties
		public string Name { get { return name; } }

		// Constructor
		/// <summary>
		/// Creates a new vehicle with a specific name
		/// </summary>
		/// <param name="name">The vehicle's name</param>
		public Vehicle(string name)
		{
			this.name = name;
			Console.WriteLine("VEHICLE constructor");
		}

		// Methods

		/// <summary>
		/// Causes the vehicle to "drive"
		/// </summary>
		public virtual void Drive()
		{
            Console.WriteLine($"Vehicle {name} is driving!");
		}

		/// <summary>
		/// Returns a string representation of the object
		/// </summary>
		/// <returns>The string version</returns>
		public override string ToString()
		{
			return $"Vehicle named {name}";
		}
	}
}
