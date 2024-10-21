// Chris Cascioli
// 10/21/24
// Demo of properties in C#

namespace PropertyDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a car for testing
			Car myFirstCar = new Car("VW", "Jetta", "Blue");
			myFirstCar.Print();

            Console.WriteLine("Make: " + myFirstCar.Make);

			// Change the mileage
			myFirstCar.Mileage = 10;
			myFirstCar.Mileage += 5;
			myFirstCar.Mileage++;
            Console.WriteLine("Mileage: " + myFirstCar.Mileage);

		}
	}
}
