using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace delegateSpace;
	public delegate void delMethod();
	public delegate (T1, T2) delGenMethod <T1, T2> (T1 a, T2 b);
	
	public class delegateClass
	{
		
		public void run()
			
		{
			Console.WriteLine("Running ...");
		}
	}
	
	public class delegateGenericClass<T1, T2>
	
	{
		public void run (T1 a, T2 b)
		
		{			
			Console.WriteLine(a, b);
		}
		
		
	}
	
	
	
	


