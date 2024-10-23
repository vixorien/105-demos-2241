// Chris Cascioli
// 10/23/24
// Represents a collection of mixed coinage

using System.Collections.Concurrent;

namespace OperatorOverloadingDemo
{
	internal class BagOfMoney
	{
		// Fields
		private int copper;
		private int silver; // Worth 10 copper
		private int gold;   // Worth 10 silver
		private int platinum; // Worth 10 gold

		// Properties
		public int Copper { get { return copper; } set { copper = value; } }
		public int Silver { get { return silver; } set { silver = value; } }
		public int Gold { get { return gold; } set { gold = value; } }
		public int Platinum { get { return platinum; } set { platinum = value; } }

		// Constructors

		/// <summary>
		/// Inits an empty bag of money
		/// </summary>
		public BagOfMoney() : this(0, 0, 0, 0) { }

		/// <summary>
		/// Inits a new bag of money with various coins
		/// </summary>
		/// <param name="copper">Amount of copper coins</param>
		/// <param name="silver">Amount of silver coins</param>
		/// <param name="gold">Amount of gold coins</param>
		/// <param name="platinum">Amount of platinum coins</param>
		public BagOfMoney(int copper, int silver, int gold, int platinum)
		{
			Copper = copper;
			Silver = silver;
			Gold = gold;
			Platinum = platinum;
		}

		// Methods

		/// <summary>
		/// Prints the contents of the bag
		/// </summary>
		public void Print()
		{
            Console.WriteLine($"Bag contains {platinum}p, {gold}g, {silver}s, {copper}c");
		}


		// Overloaded Operators

		/// <summary>
		/// Combines bags of money by adding their individual coins
		/// </summary>
		/// <param name="bagLeft">Left hand operand</param>
		/// <param name="bagRight">Right hand operand</param>
		/// <returns>A new bag with the total</returns>
		public static BagOfMoney operator +(BagOfMoney bagLeft, BagOfMoney bagRight)
		{
			return new BagOfMoney(
				bagLeft.Copper + bagRight.Copper,
				bagLeft.Silver + bagRight.Silver,
				bagLeft.Gold + bagRight.Gold,
				bagLeft.Platinum + bagRight.Platinum);
		}

		public static BagOfMoney operator +(BagOfMoney bag, int number)
		{
			return new BagOfMoney(
				bag.Copper + number,
				bag.Silver,
				bag.Gold,
				bag.Platinum);
		}

		public static BagOfMoney operator +(int number, BagOfMoney bag)
		{
			// Taking a shortcut here and just using the other operator overload
			return bag + number;
		}

		public static BagOfMoney operator ++(BagOfMoney bag)
		{
			// Could just do "return bag + 1" since we've defined that above

			return new BagOfMoney(
				bag.Copper + 1,
				bag.Silver,
				bag.Gold,
				bag.Platinum);
		}

		// What happens when we explicitly cast from bagofmoney to int?
		// Could also do implicit if we wanted
		public static explicit operator int(BagOfMoney bag)
		{
			return 
				bag.Copper +
				bag.Silver * 10 +
				bag.Gold * 100 +
				bag.platinum * 1000;
		}
	}
}
