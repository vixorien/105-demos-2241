// Chris Cascioli
// 11/6/24
// Example of an abstract parent class

namespace AbstractDemo
{
	/// <summary>
	/// Classes with one or more abstract members (such
	/// as methods or properties) must themselves be abstract
	/// </summary>
	internal abstract class Shape
	{
		// Fields
		private ConsoleColor color;

		// Properties
		public ConsoleColor Color { get { return color; } }

		// Constructor

		/// <summary>
		/// Creates a shape of the specified color
		/// </summary>
		/// <param name="color">Color used when drawing</param>
		public Shape(ConsoleColor color)
		{
			this.color = color;
		}

		// Methods

		/// <summary>
		/// Calculates the area of a shape
		/// </summary>
		/// <returns>The shape's area</returns>
		public abstract double GetArea();

		/// <summary>
		/// Prints the shape to the console
		/// </summary>
		public abstract void Print();

		/// <summary>
		/// Just an example of a regular method 
		/// </summary>
		public void RegularOldMethod()
		{
            Console.WriteLine("I am a regular method in an abstract class");
		}
	}
}
