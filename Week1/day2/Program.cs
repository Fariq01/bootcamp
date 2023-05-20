// See https://aka.ms/new-console-template for more information

class trial

{
	public char[] foods = new char[]{'p','i','z','z','a'};
	
		public void FoodCharReverse()
	{
		for(int i = foods.Length - 1; i>=0; i--)
		
		{
			Console.WriteLine(foods[i]);
		}
	}
}

class Human
{
	public string name;
	public int age;
	public bool isLive;
	
	//walk
	public string direction;
	
	//eat
	public string food;
	
	//salary
	public int salaries;
	
	
	
	
///////////	Method


	
	//method tanpa settergetter
	public string eat()
	
	{
		food = "sate";
		return food;
		
	}
	
	
	//settergetter pisah di method
	public void SetWalk(String direction)
	{
		this.direction = direction;
	}
	
	public string GetWalk()
	
	{
		return this.direction;
	}
	
	//settergetter gabung di variabel
	public int salary
	{
		set
		{
			salaries = 1000 * value;
		}
	 	get
		{
			return salaries;
		}
	}

	
	
	
	
}

static class Program
{
	static void Main()
	{
		Human human1 = new Human();
		human1.name = "Asep";
		human1.age = 20;
		human1.isLive = true;
		
		
		// Console.WriteLine(human1.name + " " + human1.age + " " + human1.isLive);
		human1.SetWalk("Forward");
		// Console.WriteLine(human1.GetWalk());
		// Console.WriteLine(human1.eat());
		
		human1.salary = 5;
		// Console.Write(human1.salary);
		
		// human1.FoodCharReverse();
		
		Console.WriteLine("Nama : " + human1.name + ", Age : " + human1.age + ", " + "isLive : " + human1.isLive);
		Console.Write("Walk : " + human1.GetWalk() + ", Eat : " + human1.eat() + Environment.NewLine + "salary : " + human1.salary);
	}

}


 