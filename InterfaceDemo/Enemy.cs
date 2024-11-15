// Chris Cascioli
// 11/15/24
// Simple enemy class to showcase an interface

namespace InterfaceDemo
{
	internal class Enemy : IDamageable
	{
		// Fields
		private int damage;

		/// <summary>
		/// Gets the amount of damage on the object
		/// </summary>
		public int CurrentDamage { get { return damage; } }

		// Constructor
		public Enemy()
		{
			damage = 0;
		}

		/// <summary>
		/// Marks some damage on the enemy
		/// </summary>
		/// <param name="amount">Incoming damage</param>
		public void TakeDamage(int amount)
		{
			if (amount > 0)
			{
				damage += amount;
			}
		}
	}
}
