// Chris Cascioli
// 11/20/24
// Demo of exceptions and try/catch blocks

namespace ExceptionDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Catch some exceptions thrown in our own code (on purpose)
			try
			{
				DoubleMyPositiveNumber(5);
				DoubleMyPositiveNumber(-2);
			}
			catch(Exception e)
			{
                Console.WriteLine("Problem doubling a number: " + e.Message);
			}


			try
			{
				// Get some input from the user and perform a division
				Console.Write("Enter a number: ");
				int input = int.Parse(Console.ReadLine()!);
				int result = 10 / input;
				Console.WriteLine("Result is " + result);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Can't do that! " + e.Message);
			}
			catch (FormatException e)
			{
                Console.WriteLine("Problem parsing: " + e.Message);
			}

			// === Testing the speed of if statements ===
            Console.WriteLine("Press any key to run 1000000 if statements");
			Console.ReadLine();

			int num = -1;
			for (int i = 0; i < 1000000; i++)
			{
				if (num != 0)
				{
					int x = 10 / num;
				}
			}

			Console.WriteLine("Press any key to cause 1000000 exceptions");
			Console.ReadLine();

			for (int i = 0; i < 1000000; i++)
			{
				try
				{
					int result = i / 0;
				}
				catch { }
			}

			// Program is over
			Console.WriteLine("We did it!");
		}

		/// <summary>
		/// This method doubles a number, but only 
		/// if it's positive.  It is not designed to
		/// work with negative numbers!
		/// </summary>
		/// <param name="number">Input</param>
		/// <returns>The number doubled (if its positive)</returns>
		/// <exception cref="Exception">When the param is negative</exception>
		static int DoubleMyPositiveNumber(int number)
		{
			if (number < 0)
			{
				throw new Exception("Can't work with negative numbers!");
			}

			return number * 2;
		}
	}
}
