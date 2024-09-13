// Chris Cascioli
// 9/13/24
// Demo of methods, method overloading and XML comments

namespace MethodDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
            // Ask the user for a number
			int age = GetUserInt();
			int fav = GetUserInt();
			int level = GetUserInt("What level is your character? ");

			bool overlap = CircleOverlap(0, 0, 5, 3, 4, 3);
		}

		// Methods
		// - Named blocks of code
		// - Useful for...
		//   - Promoting code reuse (reusability)
		//   - Modularity

		// Method syntax
		// - Access modifier ("public" for now)
		// - Static keyword (optional, but necessary for us right now)
		// - Return type (a data type or "void")
		// - Identifier (name)
		// - Parameters (zero or more)

		/// <summary>
		/// Gets an integer from the user
		/// </summary>
		/// <returns>The integer parsed from the user's input</returns>
		public static int GetUserInt()
		{
			return GetUserInt("Enter a number: ");
		}

		/// <summary>
		/// Gets an integer from the user
		/// </summary>
		/// <param name="prompt">Custom prompt to print</param>
		/// <returns>The integer parsed from the user's input</returns>
		public static int GetUserInt(string prompt)
		{
			Console.Write(prompt);
			return int.Parse(Console.ReadLine()!);
		}

		/// <summary>
		/// Gets a double from the user
		/// </summary>
		/// <param name="prompt">Custom prompt to print</param>
		/// <returns>The double parsed from the user's input</returns>
		public static double GetUserDouble(string prompt)
		{
			Console.Write(prompt);
			return double.Parse(Console.ReadLine()!);
		}

		/// <summary>
		/// Calculates the area of a circle
		/// </summary>
		/// <param name="radius">Radius of the circle</param>
		/// <returns>Area calculated as PI * r * r</returns>
		public static double CalcCircleArea(double radius)
		{
			return Math.PI * Math.Pow(radius, 2);
		}

		/// <summary>
		/// Determines if two circles overlap
		/// </summary>
		/// <param name="x1">Circle 1's x position</param>
		/// <param name="y1">Circle 1's y position</param>
		/// <param name="r1">Circle 1's radius</param>
		/// <param name="x2">Circle 2's x position</param>
		/// <param name="y2">Circle 2's y position</param>
		/// <param name="r2">Circle 2's radius</param>
		/// <returns>True if circles overlap, false otherwise</returns>
		public static bool CircleOverlap(
			double x1, double y1, double r1, // Circle 1
			double x2, double y2, double r2) // Circle 2
		{
			// Calc the distance between circle centers
			double xDiff = x1 - x2;
			double yDiff = y1 - y2;
			double dist = Math.Sqrt(xDiff * xDiff + yDiff * yDiff);

			return r1 + r2 > dist;
		}

	}
}
