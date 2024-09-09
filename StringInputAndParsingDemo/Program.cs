// Chris Cascioli
// 9/9/24
// Demo of strings, console input and parsing from strings to numbers

namespace StringInputAndParsingDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create several strings
			string name = "Chris";
			string food = "sandwich";

            // Combine and print the strings in several ways
            Console.WriteLine(name);
            Console.WriteLine(name + food);
            Console.WriteLine(name + " ate a " + food + " for dinner last night");
            
			// Using an "interpolated string"
			Console.WriteLine($"{name} ate a {food} for dinner last night");

			// Look at what a string really is...
			string letters = "abcdefg";
            Console.WriteLine($"There are {letters.Length} letters");

            Console.WriteLine("The first letter is " + letters[0]);
			Console.WriteLine("The second letter is " + letters[1]);
            Console.WriteLine();

            // String methods
            Console.WriteLine(name.ToUpper());
			Console.WriteLine(name.ToLower());
            Console.WriteLine(name);

			// String are immutable!
			name = "Bob"; // This 
			name = "Jim";
			name += "m";
			name += "mmmm";
            Console.WriteLine(name);

            // Get info about strings
            Console.WriteLine("Starts with 'Jim'? " + name.StartsWith("Jim"));
			Console.WriteLine("Ends with 'Bob'? " + name.EndsWith("Bob"));
            Console.WriteLine("Index of 'm': " + name.IndexOf("m"));
			Console.WriteLine("Contains 'om': " + name.Contains("om"));
            Console.WriteLine();

			// Manipulate the string
			string sentence = "Hey there, it's Monday (unfortunately)";
			string day = sentence.Substring(16);
			string day2 = sentence.Substring(16, 6);
            Console.WriteLine(day);
            Console.WriteLine(day2);

			// Special characters (escape characters)
			string twoLines = "Almost done?\nGetting there...";
			string tab1 = "First\t\t\tSecond";
			string tab2 = "Hi\t\t\tthere";
			string quotes = "I want \"quotes\" in my string";

            Console.WriteLine(twoLines);
			Console.WriteLine(tab1);
			Console.WriteLine(tab2);
            Console.WriteLine(quotes);
            Console.WriteLine();

			// Numeric formatting and strings
			int number = 7654;
			double price = 123.4567;

            Console.WriteLine(number);
            Console.WriteLine(price);

			// Integer formatting options
            Console.WriteLine($"{number:N}");
			Console.WriteLine($"{number:N5}");
			Console.WriteLine($"{number:C}");
			Console.WriteLine($"{number:B}");

			// Double formatting options
			Console.WriteLine($"{price:N}");
			Console.WriteLine($"{price:N5}");
			Console.WriteLine($"{price:C}");
            Console.WriteLine();

            // === Console Input ===
            Console.Write("Enter your name: ");
			string username = Console.ReadLine()!;

            Console.Write("Enter your age: ");
			string ageString = Console.ReadLine()!;
            Console.WriteLine();

			// === Convert from string to number ===
			// === PARSING ===

			// int age = (int)ageString; // Cannot just cast

			int age = int.Parse(ageString);
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine($"Half your age is {age/2}");

		}
	}
}
