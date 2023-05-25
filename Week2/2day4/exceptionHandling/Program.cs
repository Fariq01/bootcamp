
try 
{
	int[] number = new int[] {1,2,3};
	Console.WriteLine(number[3]);
}

catch(IndexOutOfRangeException e)

{
	Console.Write("index out of range");
}

finally
{
	Console.Write("final");
}