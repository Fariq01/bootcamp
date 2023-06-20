using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID_C
{
	public class TaskManager : ITaskManager
	{
		private Dictionary<string, List<string>> _employeeTask;
		private Dictionary<List<string>, List<string>, List<string>> _stocks;
		private int _stock;
		private int _price;
		private int _product;

		public void AddTask(string employeeName, string task)
		
		{
			if(_employeeTask.ContainsKey(employeeName))
			
			{
				_employeeTask[employeeName] = new List<string>();
			}
			
			_employeeTask[employeeName].Add(task);
		}
		
		public void AddStock(string product, int stock, int price)
		
		{
			
			
		}
	}
}