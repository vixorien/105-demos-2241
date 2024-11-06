namespace AbstractDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create various objects
			Circle c = new Circle(4.0, ConsoleColor.Blue);
			c.Print();
            Console.WriteLine("Area: " + c.GetArea());

			// What about polymorphic behavior?
			Shape s = new Circle(5.0, ConsoleColor.Green);
			s.Print();
            Console.WriteLine("Area: " + s.GetArea());

			// Cannot instantiate abstract classes
			// Shape uhoh = new Shape(ConsoleColor.Red);
		}
	}
}
