using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskC
{
    public class TraffictLight
    {		
		public async Task TraffLight()
		{
			Console.WriteLine("RED");
			Console.WriteLine("YELLOW");
			Console.WriteLine("GREEN");	
		}
		
		public async Task Go()
		{	
			Console.WriteLine("Wait");
			await Task.Delay(2000);
			await TraffLight();
			await Task.Delay(2000);
			Console.WriteLine("Go!");	
		}
			
	}
}