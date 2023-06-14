using System.IO;
using System.Xml.Serialization;
using XMLC;

static class Program

{
	static void Main()
	
	{
		Employee employee1 = new Employee{name = "Budi", role = "English Engineer", salary = 1000 };
		
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
		
		using(StreamWriter writer = new StreamWriter("file.xml"))
		
		{
			xmlSerializer.Serialize(writer, employee1);
		}
		
		Employee deserializeEmployee;
		using(StreamReader reader = new StreamReader("file.xml"))
		
		{
			deserializeEmployee = (Employee)xmlSerializer.Deserialize(reader);
		}
		
		Console.WriteLine("Employee " + "name : " + deserializeEmployee.name + ", role : " + deserializeEmployee.role + ", salary : " + deserializeEmployee.salary);
		
	}
}
