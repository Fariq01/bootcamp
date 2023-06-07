using System;
// using System.Collections.Generic;

namespace grind
{
	public class Kalkulator
	{
		
		
		//ref out
		
		public void SumAVG(ref int a, ref int b, out int sum, out int avg)
		
		{
			a = 50;
			b = 70;
			sum = a + b;
			avg = sum/2;
		}
		
		// in
		
		public int divide(in int a, in int b)
		
		{
			// a = 10;
			// b = 2;
			int result;
			return result = a/b;
		}
	}
}