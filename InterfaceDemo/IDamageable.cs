// Chris Cascioli
// 11/15/24
// Example of an interface

namespace InterfaceDemo
{
	/// <summary>
	/// Contains the public methods and/or properties necessary
	/// for objects in our game to be "damageable"
	/// </summary>
	internal interface IDamageable
	{
		/// <summary>
		/// Any classes implementing IDamageable 
		/// must have at least a get block in 
		/// a CurrentDamage property
		/// </summary>
		int CurrentDamage { get; }

		/// <summary>
		/// Causes an amount of damage to be
		/// added to the object
		/// </summary>
		/// <param name="amount">Incoming damage</param>
		void TakeDamage(int amount);
	}
}
