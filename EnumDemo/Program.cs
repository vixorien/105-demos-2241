using System.Collections.Concurrent;

namespace EnumDemo
{
	/// <summary>
	/// An enumeration of all possible days of the week
	/// Note: This is defined OUTSIDE any class so that
	/// it is in a more "global" scope
	/// </summary>
	enum Day
	{
		Sunday,
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday
	}

	enum Toppings
	{
		Cheese = 1,
		Ham = 2,
		Sausage = 4,
		Peppers = 8,
		Pineapple = 16
	}


	internal class Program
	{
		static void Main(string[] args)
		{
			// The current day
			Day today = Day.Wednesday;

			if (today == Day.Wednesday)
			{
				Console.WriteLine("It is Wednesday my dudes");
			}
			else if (today == Day.Thursday)
			{
                Console.WriteLine("Almost Friday");
			}

            // Let's print today
            Console.WriteLine("Today is " + today);

			// Can we cast to an int?
			int todayValue = (int)today;
            Console.WriteLine("Today's value is " + todayValue);

			// Can we do math with it?
			Day tomorrow = today + 1;
            Console.WriteLine("Tomorrow is " + tomorrow);

			// What are the bounds?
			Day uhoh = Day.Saturday;
			uhoh++;
            Console.WriteLine("Uh oh: " + uhoh);

			// Can compare against numbers
			if (uhoh > Day.Saturday)
			{
				uhoh = Day.Sunday;
			}
		}
	}
}
