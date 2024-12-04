// Chris Cascioli
// 12/4/24
// Example of basic and stream-based file io

namespace TextFileIODemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Define the file and data to work with
			string filepath = "..\\..\\..\\myFile.txt";
			string contents = "Hello I am in the file";

			// Super duper easy mode
			//File.WriteAllText(filepath, contents);

			// Easy reading
			//string fromFile = File.ReadAllText(filepath);
			//Console.WriteLine(fromFile);


			// Reading and writing data with streams

			// StreamWriters can create files for us and open them for writing
			StreamWriter output = new StreamWriter(filepath);

			// Write some data
			for (int i = 0; i < 10; i++)
			{
				output.WriteLine("First line");
				output.WriteLine("Second line");
				output.WriteLine("Third line");
				output.WriteLine("Fourth line");
			}

			output.Close();
			
			// Reading data with a streamreader
			StreamReader input = null!;
			try
			{
				input = new StreamReader(filepath);

				// Read data from the file
				string line = null!;
				while ((line = input.ReadLine()!) != null)
				{
					Console.WriteLine(line);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Error reading file: " + e.Message);
			}
			finally
			{
                Console.WriteLine("FINALLY!");
				
				if (input != null)
				{
					input.Close();
				}
			}

			// All done
			Console.WriteLine("Done!");
		}
	}
}
