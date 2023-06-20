using SOLID_C;
static class Program

{
	static void Main()
	
	{
		Employee employee1 = new();
		employee1.SetEmployee("Budi", "manajer");
		
		TaskManager task1 = new();
		
		task1.AddTask(employee1.GetName(), "");
		
	}
}