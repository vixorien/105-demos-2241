

namespace OperatorOverloadingDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Testing some bags of money
			BagOfMoney heavyBag = new BagOfMoney(123, 52, 93, 12);
			BagOfMoney emptyBag = new BagOfMoney();

			// Print for testing
			heavyBag.Print();
			emptyBag.Print();

            // After fighting the boss, we loot another bag
            Console.WriteLine();
            Console.WriteLine("-- After boss battle --");
			BagOfMoney loot = new BagOfMoney(12, 7, 3, 1);

			// Combine them together?
			BagOfMoney total = heavyBag + loot;
			total.Print();

			total += loot;
			total = total + 12;
			total = 7 + total;

			Console.WriteLine("Printing after several operators: ");
			total.Print();

            // What about conversions?
            Console.WriteLine();
            Console.WriteLine("-- Data conversion --");

			int totalValue = (int)total;
            Console.WriteLine("Total value in copper: " + totalValue);
		}
	}
}
