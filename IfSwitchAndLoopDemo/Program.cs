// Chris Cascioli
// 9/11/24
// Examples of conditional statements (ifs and switches), as well
// as the three basic loop types in C#

using System.Linq.Expressions;

namespace IfSwitchAndLoopDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// === Console Colors ===
			Console.WriteLine("Default color");

			// Changing the color
			Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This is now green");

			Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Back to the default");

			// Changing background color
			Console.ForegroundColor = ConsoleColor.Red;
			Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("This is now ugly");

			// Reset
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
			Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Something");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("]");
            Console.WriteLine();

			// === OPERATORS ===

			// Relational operators
			int result = 2 + 2;
			bool test = 5 < 10;
			bool theSame = 99 == 99;

			// Boolean operators
			bool itWorked = true && true;
			bool nope = true && false;
			bool flip = !true;
			bool another = !(5 < 10);
			bool bigOne = 5 < 10 && 99 != 98;

			// Bitwise operators
			bool singleAnd = true & false;
			bool doubleAnd = true && false;

			// Short circuiting example
			if (true || PrintAndReturnFalse())
			{
                Console.WriteLine("I am in the if");
			}

            // === If Statements ===

            // Grab some user input to check
            Console.Write("Enter your D&D class: ");
			string charClass = Console.ReadLine()!.Trim().ToLower();

			Console.Write("Enter your level: ");
			int level = int.Parse(Console.ReadLine()!);

			// Lone code block
			{
				int innerScope = 10;
                Console.WriteLine("I'm in the code block: " + level);
			}
			// Console.WriteLine(innerScope); // Outside the scope

			// Testing "single statement" ifs
			if (level == 1)
				Console.WriteLine("Welcome to D&D");
			Console.WriteLine("Will I print?");

			// Print messages based on class
			if (charClass == "fighter")
			{
                Console.WriteLine("You like to hit things");

				if (level == 1)
				{
                    Console.WriteLine("Good choice!");
				}
			}
			else if (charClass == "rogue")
			{
                Console.WriteLine("Sneaky stabby");
			}
			else if (charClass == "wizard")
			{
				Console.WriteLine("What up, nerd?");
			}
			else
			{
                Console.WriteLine("Not yet implemented!");
			}

			// === Switch ===
			// A mechanism for checking a variable and running different code

			switch (charClass)
			{
				case "monk":
				case "barbarian":
				case "fighter": Console.WriteLine("Hit things!"); break;
				case "rogue": Console.WriteLine("Stabby"); break;
				case "wizard": Console.WriteLine("Books!"); break;
				default: Console.WriteLine("None of the above"); break;
			}
            Console.WriteLine();

			// === LOOPS ===

			// While loop
			int count = 0;		// 1: Create a Loop Control Variable (LCV)
			while (count <= 10) // 2: Condition based on LCV
			{
                Console.WriteLine(count);   // 3: Code to repeat
				count++;					// 4: Change/update LCV
			}

			// Do/while
			int userNum = -1;
			do
			{
                Console.Write("Enter a number 0 - 50: ");
				userNum = int.Parse(Console.ReadLine()!);
			}
			while (userNum < 0 || userNum > 50);

			// For loop
			for (int i = 0; i < 10; i++)
			{
                Console.WriteLine(i);
			}

			// Another (weird) for loop
			for (string input = ""; input.Length < 3; input = Console.ReadLine()!)
			{
                Console.WriteLine("Enter a word with 3 or more letters");
			}
		}

		static bool PrintAndReturnFalse()
		{
            Console.WriteLine("I am in the method!");
			return false;
		}
	}
}
