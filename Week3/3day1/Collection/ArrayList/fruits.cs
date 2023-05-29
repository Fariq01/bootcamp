using System;
using System.Collections;

namespace ArrListC;

public class Fruits
{
	private List<string> _fruitsList = new();

	public bool AddFruits(string input)
	{
		if (!_fruitsList.Contains(input))
		{
			_fruitsList.Add(input);
			return true;
		}
		else 
		{
			return false;
		}
	}

	public bool DeleteFruits(string input)
	{
		if(_fruitsList.Contains(input))
		
		{
			_fruitsList.Remove(input);
			return true;
		}else
		
		{
			
			return false;
		}
		
		// Console.WriteLine(input + " has been removed");
	}

	// public void updateFruits()

	// {
	// 	_fruitsList.Re
	// }

	public List<string> GetFruits()
	{
		/*string output = "";

		foreach (var i in fruits1)
		{
			// string output = "";
			// int input = Convert.ToInt32(output);

			// if(input < fruits.Count)
			// {
			// 	output += ", ";
			// }

			Console.WriteLine(i + ", ");
		}*/
		return _fruitsList;
	}

}
