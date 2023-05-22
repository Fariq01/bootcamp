using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carClass;
class car

{
	public body totalBody;
	
	public void setBody(body totalBody)
	
	{
		this.totalBody = totalBody;
	}
	
	public body getBody()
	
	{
		return totalBody.bodySize;
	}
	
	public void displayCar()
	
	{
		Console.WriteLine(totalBody.bodySize);
	}
	
}

class body

{
	public int bodySize;
	public string bodyType;
	public door doorSize;
	
	public door doorType;

	public body(int bodySize)
	{
		this.bodySize = bodySize;
	}


}

class door

{
	public int doorSize;
	
	public string doorType;
	
	public door(int doorSize, string doorType)
	
	{
		this.doorSize = doorSize;
		this.doorType = doorType;
	}
	
	
	

}

