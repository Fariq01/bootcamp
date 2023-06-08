using tl;

static class Program
{
	static async Task Main()
	{
		Trafficlight tl1 = new();
		await Task.Run(()=>tl1.trafflight());
	}
}