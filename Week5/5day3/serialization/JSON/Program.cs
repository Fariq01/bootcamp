using JSONC;
using System.IO;
using System.Text.Json;

static class Program

{
	static void Main()
	
	{
		Employee employee1 = new Employee{name = "Budi", role = "Ilustration Engineer", salary = 1000 };
		
		string jsonString = JsonSerializer.Serialize(employee1);
		

		//using(StreamWriter writer = new StreamWriter(jsonString, "employee.json"))
		
		{
			
		}
		
	}
}