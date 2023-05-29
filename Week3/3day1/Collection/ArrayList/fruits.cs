using System;
using System.Collections;

namespace ArrListC;

public class Fruits
{
	//gk jadi pake array list karena hanya menggunakan 1 tipe data, string
	private List<string> _fruitsList = new();

	public bool AddFruits(string input)
	{
		if (!_fruitsList.Contains(input))
		{
			_fruitsList.Add(input);
			return true;
		}else 
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
		
	}

	public bool UpdateFruits(string oldValue, string newValue)

	{
		for(int i = 0; i <= _fruitsList.Count(); i++)
		{
			if(_fruitsList[i] == oldValue)
			{
				_fruitsList[i] = newValue;
				return true;
			// }else
			// {
				
			}
		}

		return false;
	}

	public List<string> GetFruits()
	{

		return _fruitsList;

	}

}
