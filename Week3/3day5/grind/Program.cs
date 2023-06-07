using grind;
static class Program
{
	static void Main()
	
	{
		Kalkulator calc1 = new();
		
		int a = 1;
		int b = 2;
		int sum;
		int avg;
		calc1.SumAVG(ref a, ref b, out sum, out avg);
		
		Console.WriteLine(a + " & " + b);
		Console.WriteLine("sum : " + sum + " avg : " + avg);
		
		int diviA = 150;
		int diviB = 75;
		
		Console.WriteLine(calc1.divide(diviA, diviB));
		
		
	}
}