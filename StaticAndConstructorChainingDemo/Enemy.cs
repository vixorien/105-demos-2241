
namespace StaticAndConstructorChainingDemo
{
	internal class Enemy
	{
		// Fields
		private string sprite;
		private ConsoleColor color;
		private int x;
		private int y;

		// A static field
		// - There's just ONE of these in memory
		// - "It belongs to the class, not an object"
		private static int enemyCount;

		// Constructors
		
		/// <summary>
		/// Creates a basic enemy at the given position
		/// </summary>
		/// <param name="x">Distance from left</param>
		/// <param name="y">Distance from top</param>
		public Enemy(int x, int y) 
			: this(x, y, "@", ConsoleColor.White)
		{
		}

		/// <summary>
		/// Creates a customized enemy
		/// </summary>
		/// <param name="x">Distance from left</param>
		/// <param name="y">Distance from top</param>
		/// <param name="sprite">The visuals of this enemy</param>
		public Enemy(int x, int y, string sprite)
			: this(x, y, sprite, ConsoleColor.White)
		{
		}

		/// <summary>
		/// Creates a customized enemy
		/// </summary>
		/// <param name="x">Distance from left</param>
		/// <param name="y">Distance from top</param>
		/// <param name="sprite">The visuals of this enemy</param>
		/// <param name="color">Color of this enemy</param>
		public Enemy(int x, int y, string sprite, ConsoleColor color)
		{
			// Save params into fields
			this.x = x;
			this.y = y;
			this.sprite = sprite;
			this.color = color;

			enemyCount++;
            Console.WriteLine("Enemy count: " + enemyCount);
		}


		// Methods

		/// <summary>
		/// Draws the enemy at its position
		/// </summary>
		public void Display()
		{
			// Move the cursor in the console
			Console.CursorLeft = x;
			Console.CursorTop = y;

			// Display this enemy
			Console.ForegroundColor = color;
            Console.Write(sprite);
		}

		/// <summary>
		/// Example static method
		/// </summary>
		public static void TestStaticMethod()
		{
            Console.WriteLine("Enemy count: " + enemyCount);
		}

	}
}
