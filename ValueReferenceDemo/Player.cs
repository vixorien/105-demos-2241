// Chris Cascioli
// 10/18/24
// Quick example of a reference type

using System.Security.Cryptography;

namespace ValueReferenceDemo
{
	internal class Player
	{
		// Fields
		private string name;

		// Constructor
		/// <summary>
		/// Creates a player with the given name
		/// </summary>
		/// <param name="name">Player's name</param>
		public Player(string name)
		{
			this.name = name;
		}

		// Methods

		/// <summary>
		/// Prints the player's data
		/// </summary>
		public void Print()
		{
            Console.WriteLine(name);
		}

		/// <summary>
		/// Updates the player's name
		/// </summary>
		/// <param name="name">New name</param>
		public void ChangeName(string name)
		{
			this.name = name;
		}
	}
}
