namespace genericsClass;


///generic
	public class department<Tdept>
	{
		public Tdept deptName;

		public department(Tdept deptName)
		{
			this.deptName = deptName;
		}

		public void displayDepart()
		{
			Console.WriteLine("Department : " + deptName);
		}
	}

	public class employee<Temp1, Temp2>
	{
			List<Temp1> id;
			List<Temp2> name;

			public employee()
			{
				id = new List<Temp1>();
				name = new List<Temp2>();
			}


			public void addEmployee(Temp1 id1, Temp2 name1)
			{
				id.Add(id);
				name.Add(name);
			}

			public void displayEmployee()
			{
				for(int i = 0; id.Count; i++)
				{
					Console.WriteLine(id[i]);
				}

				  for(int i = 0; name.Count; i++)
				{
					Console.WriteLine(name[i]);
				}
			}
	}

