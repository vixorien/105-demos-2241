// Chris Cascioli
// 11/25/24
// Demo of C#'s generic dictionary class

using System.Diagnostics;

namespace DictionaryDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a dictionary that maps strings to other strings
			Dictionary<string, string> dict = new Dictionary<string, string>();

			// Add several pieces of data using the .Add() method
			dict.Add("Bob", "123 Fake St.");
			dict.Add("Pam", "456 Over There");
			// dict.Add("Pam", "32 Square Rd"); // Keys MUST be unique

			// Can also use assignment notation to add data
			dict["Larry"] = "78 Circle Place"; // Adding since "Larry" is a new key
			dict["Larry"] = "36 Circle Place"; // Just an assignment (overwriting Larry's data)

			// Place more data into the dictionary
			for (int i = 0; i < 1000000; i++)
			{
				dict.Add("Person" + i, i + " Lomb Memorial Dr.");
			}

            Console.WriteLine("Count: " + dict.Count);

            // Get some data
            Console.WriteLine("Larry's address: " + dict["Larry"]);

			// What happens if the key is not present?
			if (dict.ContainsKey("Steve"))
			{
				// This pattern (containskey + get) requires TWO lookups
				// from the dictionary
				Console.WriteLine("Steve's address: " + dict["Steve"]);
			}
			else
			{
                Console.WriteLine("We are steve-less");
			}

			// An alternative mechanism for checking and getting data
			string larryAddress = null!;
			if (dict.TryGetValue("Larry", out larryAddress!))
			{
                Console.WriteLine("Larry is here: " + larryAddress);
			}
            Console.WriteLine();

			// === TIMING ===
			Stopwatch stopwatch = new Stopwatch();

			// Start the timing
			stopwatch.Start();

			// Do something
			for (int i = 0; i < 10000; i++)
			{ }

			// End the timing
			stopwatch.Stop();
            Console.WriteLine("Loop: " + stopwatch.Elapsed.TotalMilliseconds + "ms");

			// RESTART the stopwatch (not just Start again)
			stopwatch.Restart();

			if (dict.ContainsKey("Jan")) { }

			stopwatch.Stop();
			Console.WriteLine("Dictionary Look-up: " + stopwatch.Elapsed.TotalMilliseconds + "ms");

		}
	}
}
