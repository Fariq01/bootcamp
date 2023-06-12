using TaskC;
static class Program

{
	static async Task Main()
	
	{
		TraffictLight tf1 = new();
		
		Task task1 = Task.Run( () => tf1.Go());
		await task1;
		
		// Console.ReadKey();
		
		
		
	}
}