using System;
using System.IO;

static class Program
{
	static void Main()
	{
		
		string filePath = "file2.txt";
		
		// StreamWriter file1 = new StreamWriter(File.Create(filePath));
		
		using(StreamWriter writer = new StreamWriter(File.Open(filePath, FileMode.Append)))
		
		{
			writer.Write("Hello");
			writer.Write(123131);
		}

		using(StreamReader reader = new StreamReader(File.Open(filePath, FileMode.Open)))
		{
			string input = reader.ReadLine();
			Console.WriteLine(input);
		}
		
		using (Strea)
		{
			
		}
	}
}