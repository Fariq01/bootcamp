using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID_C
{
	public interface ITaskManager
	{
		public void Calculate(int a, int b);
		public void AddTask(string employeeName, string task);
		
		
	}
}