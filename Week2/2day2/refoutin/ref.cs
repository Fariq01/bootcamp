using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace refoutin;

	public class ref1
	
	{
		int number = 10;
		PrintDouble(int number);
		
		public void PrintDouble(in int x)
    	{
        	Console.WriteLine(x * 2); 
        	x = 20;   //Error, Please read the error                       
    	}
	}

 
	
