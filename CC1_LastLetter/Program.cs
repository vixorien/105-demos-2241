// Chris Cascioli
// 9/18/24
// Demo of Coding Challenge 1 - LastLetter

using System.Net.Mail;

namespace CC1_LastLetter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Prompt
            Console.Write("Please enter a sentence: ");
			string sentence = Console.ReadLine()!;

			// Run the function and print the result
			char letter = LastLetter(sentence);
			Console.WriteLine($"The letter '{letter}' is closest to the end");
		}

		/// <summary>
		/// Determines which character in a string is closest to the
		/// end of the alphabet
		/// </summary>
		/// <param name="sentence">The input string</param>
		/// <returns>
		/// The letter closest to the end of the alphabet, 
		/// or '?' if the string is empty
		/// </returns>
		public static char LastLetter(string sentence)
		{
			// Validation first
			if (sentence.Length == 0)
			{
				return '?';
			}

			// Ensure we're in a uniform case
			sentence = sentence.ToUpper();

			// Determine which letter is closest to the end
			// - Track which is the current candidate
			// - Check each letter in the sentence
			char bestLetter = '?';
			for (int i = 0; i < sentence.Length; i++)
			{
				// Compare current letter with "best" letter
				char currentLetter = sentence[i];
				if (currentLetter > bestLetter)
				{
					bestLetter = currentLetter;
				}
			}

			// Return that data
			return bestLetter;
		}
	}
}
