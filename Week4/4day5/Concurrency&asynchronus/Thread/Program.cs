using System;
using System.Threading;
using System.Diagnostics;
using ThreadC;

static class Program

{
	static void Main()
	
	{
		//Pake thread
		Stopwatch stopwatch = new();
		DailyTask dt = new();
		Thread thread1 = new(dt.Study);
		Thread thread2 = new(dt.Cleaning);
		thread1.Name = "Study Thread";
		thread2.Name = "Cleaning Thread";
		
		stopwatch.Start();
		
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} started.");
		thread1.Start();
		
		//Gk dipake karena main thread di block, aktif tapi gk jalanin tasknya
		//mending pake async.await
		Thread.Sleep(5000);
		thread2.Start();
		
		stopwatch.Stop();
		
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} Finished.");
		Console.WriteLine($"Program complete. Elapsed time: {stopwatch.ElapsedMilliseconds}ms");
	}
}