// Chris Cascioli
// 10/21/24
// Example class to showcase properties

using System.Security.AccessControl;

namespace PropertyDemo
{
	internal class Car
	{
		// Fields
		private bool sunroof;
		private string make;
		private string model;
		private string color;
		private double mileage;

		// Properties

		/// <summary>
		/// Gets or sets the name of the car
		/// An example of an "auto-implemented property"
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// Gets or sets the sunroof status (an expression-bodied property)
		/// </summary>
		public bool Sunroof { get => sunroof; set => sunroof = value; }

		/// <summary>
		/// Gets or sets the make of the car
		/// </summary>
		public string Make
		{
			get { return make; }
			private set { make = value; } // Overriding access modifier
		}

		/// <summary>
		/// Gets or sets the color (as long as its not null)
		/// </summary>
		public string Color 
		{ 
			get { return color; } 
			set 
			{
				if (color != null)
				{
					color = value;
				}
			} 
		}

		/// <summary>
		/// Example of a property derived from existing fields
		/// </summary>
		public bool IsBlue { get { return color == "blue"; } }

		/// <summary>
		/// Gets or sets the mileage
		/// </summary>
		public double Mileage
		{
			get { return mileage; }
			set { mileage = value; }
		}


		// Constructor
		/// <summary>
		/// Creates a new car
		/// </summary>
		/// <param name="make">The maker of the car</param>
		/// <param name="model">The specific model</param>
		/// <param name="color">The paint color</param>
		public Car(string make, string model, string color)
		{
			// Save params into fields
			Make = make; // We can use properties throughout the class, too!
			this.model = model;
			this.color = color;

			// No mileage to start
			this.mileage = 0;
		}

		// Expression-bodied member
		public void Drive(double distance) => mileage += distance;

		// Methods
		/// <summary>
		/// Prints the car's details
		/// </summary>
		public void Print()
		{
			Console.WriteLine($"{color} {make} {model} has {mileage} miles");
		}
	}
}
