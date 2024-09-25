// Chris Cascioli
// 9/23/24
// Examples of multidimensional arrays and generating random numbers

namespace RandomAnd2DArrayDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// === "Find duplicates" from the last PE ===
			Console.WriteLine("Finding duplicates");

			// Create a literal array of names
			string[] names = { "Bob", "Jim", "Larry", "Jim", "Jim" };

			// Loop through the array
			for (int i = 0; i < names.Length; i++)
			{
				// For each element, check the other elements
				for (int j = i + 1; j < names.Length; j++)
				{
					// If it's the same name, we have a duplicate!
					if (names[i] == names[j])
					{
                        Console.WriteLine(names[i] + " is a duplicate");
						break;
					}
				}
			}
            Console.WriteLine();


			// === Arrays of Objects ===

			// Creates a new array of strings
			string[] places = new string[5];

			// Causes a "null reference exception"
			// Console.WriteLine(places[0].ToUpper());


			// === Multidimensional arrays ===

			// Create a 2D array
			int[,] grid = new int[5, 7];
            Console.WriteLine("Length of our 2D array: " + grid.Length);
			Console.WriteLine("Length of first dimension: " + grid.GetLength(0));
			Console.WriteLine("Length of second dimension: " + grid.GetLength(1));

			// Loop through and set all values
			for (int row = 0; row < grid.GetLength(0); row++)
			{
				for (int col = 0; col < grid.GetLength(1); col++)
				{
					grid[row, col] = 3;
				}
			}

			// Test out some other dimensions
			int[,,] threeD = new int[4, 5, 6];
			int[,,,,,,] sevenD = new int[4, 4, 4, 4, 4, 4, 4];

			// Literal 2D array
			int[,] literal = {
				{ 4, 5, 6 },
				{ 22, 7, -1 }
			};

            Console.WriteLine();


			// === Jagged Arrays ===
			int[][] jagged = new int[5][]; // Create the "outer" array first

			// Individually create "inner" arrays
			jagged[0] = new int[7];
			jagged[1] = new int[4];
			jagged[2] = new int[22];
			// Etc.


			// === Random Numbers ===

			// Step 1: Create a Random Number Generator object
			Random rng = new Random();

			Console.WriteLine("Random integers: ");
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(rng.Next());
			}
            Console.WriteLine();

            Console.WriteLine("Random ints from 0 - 10 (exclusive): ");
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(rng.Next(10));
			}

			// Inclusive lower bound, exclusive upper bound
			int between5and15 = rng.Next(5, 15);

			// Random doubles
			double randDouble = rng.NextDouble(); // 0.0 (inclusive) - 1.0 (exclusive)
			double double5and15 = rng.NextDouble() * 10 + 5; // 5.0 - 15.0
		}
	}
}
