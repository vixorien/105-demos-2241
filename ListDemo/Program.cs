// Chris Cascioli
// 9/25/24
// Demo of C#'s List class

namespace ListDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a list of strings
			List<string> names = new List<string>();

			// Start with the stats
			PrintStats(names);

			// Add a single element and print stats again
			names.Add("Bob");
			PrintStats(names);

			// Add more stuff
			names.Add("Jim");
			names.Add("Pam");
			names.Add("Jan");
			names.Add("Steve");
			PrintStats(names);
			PrintList(names);

			// Insert data "anywhere"
			names.Insert(0, "Larry");
			names.Insert(3, "Joe");
			names.Insert(3, "Tom");
			PrintStats(names);
			PrintList(names);

			// Remove data
			names.Remove("Tom");
			names.RemoveAt(1);
			PrintStats(names);
			PrintList(names);

			// Foreach loops and altering collections
			foreach (string s in names)
			{
				if (s == "Joe")
				{
					// CANNOT ALTER A COLLECTION WHILE
					// FOREACH'ING THROUGH IT!
					//names.Add("Bill");
				}
			}
		}

		public static void PrintList(List<string> list)
		{
            Console.WriteLine("=== CONTENTS ===");
			for (int i = 0; i < list.Count; i++)
			{
			   Console.WriteLine(list[i]);
			}
            Console.WriteLine();
		}

		public static void PrintStats(List<string> list)
		{
            Console.WriteLine("=== STATS ===");
            Console.WriteLine("Count: " + list.Count);
            Console.WriteLine("Capacity: " + list.Capacity);
            Console.WriteLine();
		}
	}
}
