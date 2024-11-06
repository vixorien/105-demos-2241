// Chris Cascioli
// 11/6/24
// Example of a child class derived from an abstract parent

namespace AbstractDemo
{
	internal class Circle : Shape
	{
		// Fields
		private double radius;

		// Properties
		public double Radius { get { return radius; } }

		// Constructor

		/// <summary>
		/// Creates a new circle
		/// </summary>
		/// <param name="radius">Size</param>
		/// <param name="color">Color</param>
		public Circle(double radius, ConsoleColor color)
			: base(color)
		{
			this.radius = radius;
		}

		// Methods

		/// <summary>
		/// Calculates the area of a circle
		/// </summary>
		/// <returns>Area of this circle</returns>
		public override double GetArea()
		{
			return Math.PI * radius * radius;
		}
		
		/// <summary>
		/// Prints this shape using its color
		/// </summary>
		public override void Print()
		{
			Console.ForegroundColor = Color;
            Console.WriteLine("O");
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}
