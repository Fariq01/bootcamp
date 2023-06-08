using System;
using System.Collections.Generic;

namespace tl
{
	public class Trafficlight
	{
		public async void trafflight()
		{
			while(true)
			{
				Console.WriteLine("RED");
                Task myTask = Task.Run(() => Task.Delay(1000));
                Console.WriteLine("GREEN");
				Task myTask2 = Task.Run(() => Task.Delay(1000));
				Console.WriteLine("YELLOW");
                await Task.WhenAll(myTask, myTask2);
            }
		}
	}
}