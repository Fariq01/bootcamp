// using Debugging;
using System.Diagnostics;

class Program
{
	static void Main()
	
	{
		string a = "Hello";
		string b = "There";
		string c = "World";
		
		// dijalankan di debug
		Debug.WriteLine(a + b);
		
		// dijalan kan saat udah di release
		Trace.WriteLine(a + c);
		
		
	}
}