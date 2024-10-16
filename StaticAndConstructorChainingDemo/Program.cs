// Chris Cascioli
// 10/16/24
// Demo of more OOP topics: static keyword and chaining constructors together

namespace StaticAndConstructorChainingDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create an enemy
			Enemy badGuy1 = new Enemy(10, 10);
			Enemy badGuy2 = new Enemy(20, 5);
			Enemy badGuy3 = new Enemy(30, 8, "$");
			Enemy badGuy4 = new Enemy(4, 12, "&&&", ConsoleColor.Red);
			badGuy1.Display();
			badGuy2.Display();
			badGuy3.Display();
			badGuy4.Display();

			//Enemy.TestStaticMethod();

			// Pauses the program
			Console.ReadLine();
		}
	}
}
