namespace PolymorphismDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a simple vehicle
			Vehicle car = new Vehicle("Carl");
			car.Drive();
            Console.WriteLine();

			// Create a child class object
			Firetruck ft = new Firetruck("Freddy");
			ft.Drive();
			ft.ShootWater();
            Console.WriteLine();
			
			// Can we store a child object in a parent context?
			Vehicle vehicleContext = new Firetruck("Does this work?");
			vehicleContext.Drive();
			//vehicleContext.ShootWater(); // Invalid syntax


			// How do I get my stuff back?!?!
			Firetruck backToFiretruck = (Firetruck)vehicleContext;
			backToFiretruck.ShootWater();

			// Shortcut for the above cast + call
			((Firetruck)vehicleContext).ShootWater();
            Console.WriteLine();

			// Can we cast something that was NEVER a firetruck?
			if (car is Firetruck)
			{
				// We know this won't work here!
				Firetruck uhoh = (Firetruck)car;
			}
			else
			{
                Console.WriteLine("Cannot cast car to a firetruck");
			}

			// Alternative to the "is" operator: "as" operator
			Firetruck maybe = (car as Firetruck)!;
			if (maybe != null)
			{
				maybe.ShootWater();
			}
            Console.WriteLine();

            // ToString example
            Console.WriteLine(car);
            Console.WriteLine(ft);
            Console.WriteLine(ft.ToString());
			
		}
	}
}
