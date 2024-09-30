// Chris Cascioli
// 9/25/24
// Example of previous PE (word search)

namespace WordSearch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a 2D array of characters
			char[,] puzzle = new char[15, 10]; // Height (rows), Width (columns)

			// Fill it with random data
			Random rng = new Random();
			for (int row = 0; row < puzzle.GetLength(0); row++)
			{
				for (int col = 0; col < puzzle.GetLength(1); col++)
				{
					// Remember that the upper bound on .Next() is not inclusive!
					puzzle[row, col] = (char)rng.Next('a', 'z' + 1);
				}
			}

			// Print out the entire array
			for (int row = 0; row < puzzle.GetLength(0); row++)
			{
				for (int col = 0; col < puzzle.GetLength(1); col++)
				{
					Console.Write(puzzle[row, col] + " ");
				}
				Console.WriteLine();
			}

			// Prompt the user for a word to look for
			Console.WriteLine();
			Console.Write("Enter a word to look for: ");
			string search = Console.ReadLine()!;

			// Actually search for that word
			for (int row = 0; row < puzzle.GetLength(0); row++)
			{
				for (int col = 0; col < puzzle.GetLength(1) - search.Length + 1; col++)
				{
					// Starting "here" [row, col], match the search string
					bool match = true;
					for (int i = 0; i < search.Length; i++)
					{
						// Do we have a single character match?
						if (puzzle[row, col + i] != search[i])
						{
							match = false;
							break;
						}
					}

					// If we still have a match, the word is found!
					if (match)
					{
						Console.WriteLine("Word found!");
					}
				}

			}
		}
	}
}

