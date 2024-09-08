// Chris Cascioli
// 9/6/24
// Looking at binary literals and type casting

namespace BinaryAndCastingDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Declare some literal values
			int ex1 = 1234; // 1,234 does not work!
			int ex2 = 1_234; // _ acts like a comma
			int ex3 = 1_2_3_4; // Gross, but it works
			// The underscores do not change the meaning

			// Print the numbers for testing
			Console.WriteLine("Integer literals");
            Console.WriteLine(ex1);
            Console.WriteLine(ex2);
            Console.WriteLine(ex3);
            Console.WriteLine();

			// Attempt to type out binary
			int notBinary = 010101; // What number is this?
            Console.WriteLine(notBinary); // 10,101

			// Is there a way to type out a binary literal?
			int bin1 = 0b010101; // Binary: 010101
			int bin2 = 0b01;
			int bin3 = 0b_1010_1101_0101;

            Console.WriteLine("Binary literals");
            Console.WriteLine(bin1);
			Console.WriteLine(bin2);
			Console.WriteLine(bin3);
            Console.WriteLine();

			// Create binary for the following numbers:
			// 17
			int bin17 = 0b_0001_0001;
            Console.WriteLine("17? " + bin17);

			// 255
			int bin255 = 0b_1111_1111;
            Console.WriteLine("255? " + bin255);

			// 1492
			int bin1492 = 0b_0101_1101_0100;
            Console.WriteLine("1492? " + bin1492);


			// === Casting ===
			int i = 10;
			double pi = 3.14159;
			
			double x = 44; // Is this a cast?  Yes, implicit!
			int y = (int)pi; // Explicit cast
			int z = (int)4.999; // Explicit cast

            Console.WriteLine("Pi cast to int: " + y);
            Console.WriteLine("4.999 cast to int: " + z);

			// Loss of data example
			int big = 1234567;
			short small = (short)big;
            Console.WriteLine(big + " as a short is " + small);
		}
	}
}
