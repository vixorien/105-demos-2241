// Chris Cascioli
// 10/18/24
// Demo of value and reference types and their differences

namespace ValueReferenceDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Value types and assignments
			int a = 10;
			int b = a;
			b += 5;
            Console.WriteLine("-- Value types --");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine();

			// Reference types and assignments
			Player p1 = new Player("Bob");
			Player p2 = p1;
			p2.ChangeName("Steve");
            Console.WriteLine("-- Reference types --");
			p1.Print();
			p2.Print();
            Console.WriteLine();

			// Strings (reference types that act like value types)
			string name1 = "Joe";
			string name2 = name1;
			name2 = "Steve";
            Console.WriteLine("-- Strings --");
            Console.WriteLine(name1);
            Console.WriteLine(name2);
            Console.WriteLine();

			// Arrays 
			int[] a1 = new int[10];
			a1[0] = 99;

			int[] a2 = a1;
			a2[0] = -3;

            Console.WriteLine("-- Arrays --");
            Console.WriteLine(a1[0]);
            Console.WriteLine(a2[0]);
            Console.WriteLine();

            // Passing by value example
            Console.WriteLine("-- Pass by Value --");
			int val = 5;
			PassByValue(val);
            Console.WriteLine(val);
            Console.WriteLine();

            // Passing by reference example
            Console.WriteLine("-- Pass by Ref --");
			PassByReference(p1);
			p1.Print();
            Console.WriteLine();

            // Passing value types like references
            Console.WriteLine("-- out param --");
			int example = 55;
			OutParamExample(out example);
            Console.WriteLine("'out param' results: " + example);
            Console.WriteLine();

            // TryParse
            Console.WriteLine("-- TryParse --");
			int result = 0;
			if (int.TryParse("1234", out result))
			{
                Console.WriteLine("Success! " + result);
			}
		}

		static void OutParamExample(out int passByReference)
		{
			passByReference = 100;
		}


		/// <summary>
		/// Value types are "passed by value" (copied)
		/// </summary>
		/// <param name="param">The data to pass in</param>
		static void PassByValue(int param)
		{
			param += 100;
		}

		/// <summary>
		/// Reference types are "passed by reference" (NOT copied)
		/// </summary>
		/// <param name="p">Player data</param>
		static void PassByReference(Player p)
		{
			p.ChangeName("Ralph");
		}
	}
}
