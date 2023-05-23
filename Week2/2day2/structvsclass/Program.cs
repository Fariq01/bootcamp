using System;
using System.Diagnostics;

class PointClass
{
	public int X;
	public int Y;

	public PointClass(int x, int y)
	{
		X = x;
		Y = y;
	}
}

struct PointStruct
{
	public int X;
	public int Y;

	public PointStruct(int x, int y)
	{
		X = x;
		Y = y;
	}
}

struct ReferenceStruct

//reference dibungkus value(struct) ttp reference
//note : kalo value dibungkus reference(class) jadi reference

{
	//reference data type
	public string a;
	public string b;
	
	public ReferenceStruct(string a, string b)
	
	{
		this.a = a;
		this.b = b;
	}
		
}

class Program
{
	static void Main()
	{
		
		
		ReferenceStruct refStruct1 = new ReferenceStruct("a", "b");
		ReferenceStruct refStruct2 = refStruct1;
		
		refStruct2.a = "xx";
		refStruct2.b = "yy";
		
		Console.WriteLine($"refStruct1: a = {refStruct1.a}, b = {refStruct1.b}");
		Console.WriteLine($"refStruct2: a = {refStruct2.a}, b = {refStruct2.b}");
		
		Console.WriteLine();
		
		PointClass pointClass1 = new PointClass(1, 2);
		PointClass pointClass2 = pointClass1;

		pointClass2.X = 5;
		pointClass2.Y = 10;

		Console.WriteLine("Class:");
		Console.WriteLine($"pointClass1: X = {pointClass1.X}, Y = {pointClass1.Y}");
		Console.WriteLine($"pointClass2: X = {pointClass2.X}, Y = {pointClass2.Y}");

		
		PointStruct pointStruct1 = new PointStruct(1, 2);
		PointStruct pointStruct2 = pointStruct1;

		pointStruct2.X = 3;
		pointStruct2.Y = 6;

		Console.WriteLine("\nStruct:");
		Console.WriteLine($"pointStruct1: X = {pointStruct1.X}, Y = {pointStruct1.Y}");
		Console.WriteLine($"pointStruct2: X = {pointStruct2.X}, Y = {pointStruct2.Y}");

		
		int iterations = 10000000;

		Stopwatch sw = new Stopwatch();

		
		sw.Start();
		for (int i = 0; i < iterations; i++)
		{
			PointClass temp = new PointClass(i, i);
		}
		sw.Stop();
		Console.WriteLine($"\nPerforma Class: {sw.ElapsedMilliseconds} ms");

		
		sw.Restart();
		for (int i = 0; i < iterations; i++)
		{
			PointStruct temp = new PointStruct(i, i);
		}
		sw.Stop();
		Console.WriteLine($"Performa Struct: {sw.ElapsedMilliseconds} ms");
	}
}