using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID_C
{
	public class Employee
	{
		private string _name;
		private string _job;
		
		
		public (string, string) GetEmployee()
		
		{
			return (_name, _job);
		}
		
		public string GetName()
		
		{
			return _name;
		}
		
		public void SetEmployee(string name, string job)
		
		{
			_name = name;
			_job = job;
		}
		
			
	}
}