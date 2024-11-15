// Chris Cascioli
// 11/15/24
// Simple player class to showcase an interface

namespace InterfaceDemo
{
	internal class Player : IDamageable
	{
		// Fields
		private string name;
		private int damage;

		/// <summary>
		/// Gets the amount of damage on the object
		/// </summary>
		public int CurrentDamage { get { return damage; } }

		// Constructor
		public Player(string name)
		{
			this.name = name;
			this.damage = 0;
		}

		/// <summary>
		/// Marks some damage on the player
		/// </summary>
		/// <param name="amount">Incoming damage</param>
		public void TakeDamage(int amount)
		{
			if (amount > 0)
			{
				damage += amount;
			}
		}

		// Methods
		public override string ToString()
		{
			return $"Player {name} has taken {damage} damage";
		}

	}
}
