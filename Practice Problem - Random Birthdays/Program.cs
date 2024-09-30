namespace PracticeProblem
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.Write("How many birthdays? ");
			int numBirthdays = int.Parse(Console.ReadLine()!);
			int[] birthdays = GenerateBirthdays(numBirthdays);

			// Days in months
			int jan = 31;
			int feb = 28;
			int mar = 31;
			int apr = 30;
			int may = 31;
			int jun = 30;
			int jul = 31;
			int aug = 31;
			int sep = 30;
			int oct = 31;
			int nov = 30;
			int dec = 31;

			// Starting days
			int janStart = 0;
			int febStart = janStart + jan;
			int marStart = febStart + feb;
			int aprStart = marStart + mar;
			int mayStart = aprStart + apr;
			int junStart = mayStart + may;
			int julStart = junStart + jun;
			int augStart = julStart + jul;
			int sepStart = augStart + aug;
			int octStart = sepStart + sep;
			int novStart = octStart + oct;
			int decStart = novStart + nov;

			// Totals
			int janTotal = TotalBirthdays(birthdays, janStart, jan);
			int febTotal = TotalBirthdays(birthdays, febStart, feb);
			int marTotal = TotalBirthdays(birthdays, marStart, mar);
			int aprTotal = TotalBirthdays(birthdays, aprStart, apr);
			int mayTotal = TotalBirthdays(birthdays, mayStart, may);
			int junTotal = TotalBirthdays(birthdays, junStart, jun);
			int julTotal = TotalBirthdays(birthdays, julStart, jul);
			int augTotal = TotalBirthdays(birthdays, augStart, aug);
			int sepTotal = TotalBirthdays(birthdays, sepStart, sep);
			int octTotal = TotalBirthdays(birthdays, octStart, oct);
			int novTotal = TotalBirthdays(birthdays, novStart, nov);
			int decTotal = TotalBirthdays(birthdays, decStart, dec);

			// Print months
			Console.WriteLine("January: " + janTotal);
			Console.WriteLine("February: " + febTotal);
			Console.WriteLine("March: " + marTotal);
			Console.WriteLine("April: " + aprTotal);
			Console.WriteLine("May: " + mayTotal);
			Console.WriteLine("June: " + junTotal);
			Console.WriteLine("July: " + julTotal);
			Console.WriteLine("August: " + augTotal);
			Console.WriteLine("September: " + sepTotal);
			Console.WriteLine("October: " + octTotal);
			Console.WriteLine("November: " + novTotal);
			Console.WriteLine("December: " + decTotal);

            // Verification
            Console.WriteLine();
			int verifyTotal =
				janTotal + febTotal + marTotal +
				aprTotal + mayTotal + junTotal +
				julTotal + augTotal + sepTotal +
				octTotal + novTotal + decTotal;
            Console.WriteLine("Total: " + verifyTotal);
		}

		/// <summary>
		/// Generates the specified number of birthdays
		/// and returns an array with the results
		/// </summary>
		/// <param name="numberToGenerate">Number of birthdays to generate</param>
		/// <returns>An array where each element is the number of birthdays occuring on that day</returns>
		public static int[] GenerateBirthdays(int numberToGenerate)
		{
			// Create the array and random number generator
			int[] birthdays = new int[365];
			Random rng = new Random();

			// Generate the specified number of birthdays
			for (int i = 0; i < numberToGenerate; i++)
			{
				birthdays[rng.Next(365)]++;
			}

			return birthdays;
		}

		/// <summary>
		/// Adds up birthdays in a subset of a birthday array
		/// </summary>
		/// <param name="birthdays">Array of birthdays</param>
		/// <param name="start">Starting element</param>
		/// <param name="count">Number of elements to total</param>
		/// <returns>Total of all birthdays in the specified subset</returns>
		public static int TotalBirthdays(int[] birthdays, int start, int count)
		{
			// Running total
			int total = 0;

			// Loop through the subset
			for (int i = 0; i < count; i++)
			{
				total += birthdays[start + i];
			}

			return total;
		}
	}
}
