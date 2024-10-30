// Chris Cascioli
// 10/30/24
// Example of a base (parent) class

namespace InheritanceDemo
{
	internal class Vehicle
	{
		// Fields
		protected string make;
		protected string model;
		protected double mileage;

		// Properties
		public string Make { get { return make; } }
		public string Model { get { return model; } }
		public double Mileage { get { return mileage; } }

		// Constructor

		/// <summary>
		/// Creates a new vehicle
		/// </summary>
		/// <param name="make">The manufacturer of the vehicle</param>
		/// <param name="model">The specific model</param>
		public Vehicle(string make, string model)
		{
			this.make = make;
			this.model = model;
			this.mileage = 0;
		}

		// Methods

		/// <summary>
		/// Causes the vehicle to drive, increasing its mileage
		/// </summary>
		/// <param name="distance">Distance to go this trip</param>
		public void Drive(double distance)
		{
			this.mileage += distance;
            Console.WriteLine($"Vehicle {make} {model} has driven {distance} miles");
		}
	}
}
