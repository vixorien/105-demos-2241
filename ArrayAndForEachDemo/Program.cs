// Chris Cascioli
// 9/20/24
// Demo of arrays in C# and the foreach loop

using System.Collections.Concurrent;

namespace ArrayAndForEachDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create several arrays
			int[] numbers = new int[5];

			// Filling arrays with data
			numbers[0] = 99;
			numbers[1] = -4;
			numbers[2] = 12345;
			numbers[3] = 54;
			numbers[4] = 1;
			numbers[^1] = 3; // This syntax allows us to access the array backwards

			// Use a literal array
			int[] grades = { 98, 72, 100, 62, 81 };
			string[] names = { "Bob", "Joe", "Larry" };

			// Print our arrays
			PrintArray(numbers);
			PrintArray(grades);

			// Any negatives?
			Console.Write("Any negatives in the first array? ");
			Console.WriteLine(AnyNegatives(numbers));
		}

		/// <summary>
		/// Prints the elements of an array
		/// </summary>
		/// <param name="array">The array to print</param>
		public static void PrintArray(int[] array)
		{
            Console.WriteLine($"Array with {array.Length} elements");

			// Loop and print with a basic for loop
			//for (int i = 0; i < array.Length; i++)
			//{
			//	Console.WriteLine(array[i]);
			//}

			// Same as above, but with a foreach
			foreach (int element in array)
			{
                Console.WriteLine(element);
			}


            Console.WriteLine();
		}

		/// <summary>
		/// Determines if any elements of an array are negative
		/// </summary>
		/// <param name="array">Array to check</param>
		/// <returns>True if at least one element is negative, false otherwise</returns>
		public static bool AnyNegatives(int[] array)
		{
			// Loop and check each element
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] < 0)
				{
					return true;
				}
			}

			return false;
		}
	}
}
