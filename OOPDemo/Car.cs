// Chris Cascioli
// 10/4/24
// Example of a class

namespace OOPDemo
{
	internal class Car
	{
		// Fields
		private string make;
		private string model;
		private string color;
		private double mileage;
		private double milesPerGallon;
		private double gas;
		private const double GasTankMaximum = 10;

		// Constructors
		public Car(string make, string model, string color, double milesPerGallon)
		{
			this.make = make;
			this.model = model;
			this.color = color;
			this.milesPerGallon = milesPerGallon;
			mileage = 0;
			gas = 0;
		}

		// Methods
		public void FillGasTank()
		{
			gas = GasTankMaximum;
			Console.WriteLine("Gas tank has been filled");
		}

		public void CheckGasTank()
		{
			Console.WriteLine($"You have {gas} gallons of gas left.");
		}


		public void Drive(double distance)
		{
			// Make sure we can do anything
			if (distance <= 0)
			{
				Console.WriteLine("That was a short trip!");
				return;
			}
			else if (gas == 0)
			{
				Console.WriteLine("You have no gas!");
				return;
			}

			// How much gas will this require?
			double gasRequired = distance / milesPerGallon;

			// Do we have enough?
			if (gasRequired > gas)
			{
				// Nope!  How far will we get?
				double distBeforeEmpty = gas * milesPerGallon;
				mileage += distBeforeEmpty;
				gas = 0;

				Console.WriteLine($"You don't have enough gas to drive {distance} miles.");
				Console.WriteLine($"You drove {distBeforeEmpty} miles before running out of gas!");
			}
			else if (gasRequired == gas)
			{
				// We have EXACTLY enough gas
				mileage += distance;
				gas -= gasRequired;
				Console.WriteLine($"You've driven {distance} miles, but now you're out of gas!");
			}
			else
			{
				// We have more than enough gas
				mileage += distance;
				gas -= gasRequired;
				Console.WriteLine($"You've driven {distance} miles");
				CheckGasTank();
			}
		}

		public void Report()
		{
			Console.WriteLine($"You are driving a {color} {make} {model}");
			Console.WriteLine($"It gets {milesPerGallon} mpg");
			Console.WriteLine($"You have driven a total of {mileage} miles so far");
			CheckGasTank();
		}

	}
}
