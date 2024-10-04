// Chris Cascioli
// 10/4/24
// Demo of object oriented programming

namespace OOPDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a car object
			Car firstCar = new Car("VW", "Jetta", "Blue", 20);

			// Test it out!
			firstCar.Report();

			// NOT THIS!!!
			// Car.Report(); // Report is NOT STATIC

			string input = null!;
			while (input != "quit")
			{
				Console.WriteLine("\nWhat would you like to do? ['drive', 'fill tank', 'report', 'quit']");
				Console.Write("> ");
				input = Console.ReadLine()!.ToLower();

				switch (input)
				{
					case "drive":
						Console.Write("How far are you driving? ");
						double distToDrive = double.Parse(Console.ReadLine()!);
						firstCar.Drive(distToDrive);
						break;

					case "fill tank":
						firstCar.FillGasTank();
						break;

					case "report":
						firstCar.Report();
						break;

					case "quit":
						Console.WriteLine("Thanks for driving!");
						break;

					default:
						Console.WriteLine("That is not a valid command");
						break;
				}
			}

		}
	}
}
