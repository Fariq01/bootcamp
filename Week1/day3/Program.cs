﻿class Cars
{ 

	protected int wheels;

	public Cars(string x) {

		wheels = int.Parse(x);

	}
	public Cars(int x) {

		wheels = x;
	}
	
	
	protected void forward()
	
	{
		Console.WriteLine("forward..");
	}
	
	public void forward(string x)
	
	{
		Console.WriteLine(x);
	}

}

class Truck : Cars {

	public string type;

	public Truck (string x) : base(x){

		type = x;

	}

	public void jump()

	{
		Console.WriteLine("Jump with " + wheels + " wheels");
		forward();
	}

}


////// inheritance, encapsulation, swap object parent child class



class Program {

	static void Main() {

		Cars car1 = new Cars(8);

		Truck truck1 = new Truck("bass");
		
		
		//overload method
		car1.forward("vroom");
		
		//protected
		// int a = car1.wheels;
		// Console.WriteLine(a);
		
		
		//usecase 2
		
		// Cars car2 = new Truck("boosted");
		 
		// string type = car2.type;
		
		Cars truck2 = new Truck("truckun");
		
		// protected
		// int  wheels = truck2.wheels;
		
		// usecase 3
		string type = truck1.type;
		Console.WriteLine(type);
		truck1.jump();
		
		
		
		
	}

}