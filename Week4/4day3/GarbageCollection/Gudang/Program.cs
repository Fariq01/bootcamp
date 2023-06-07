using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Program
{
	static void Main()
	{
		
		string filePath = "text.txt";
		string filePath2 = "C:/c#masterrace/bootcamp/text.txt";

		List<string> files = new List<string>();

		using (StreamReader reader = new StreamReader(filePath))
		{
			string file;
			while ((file = reader.ReadLine()) != null)
			{
				files.Add(file);
			}
		}

		foreach (string file in files)
		{
			Console.WriteLine(file);
		}
		
		Console.ReadKey();
		
	}
}







