namespace genericsClass;

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

        public class employee<Temp>
        {
            List<Temp> id;
            List<Temp> name;

            public employee()
            {
                id = new List<Temp>();
                name = new List<Temp>();
            }


            public void addEmployee(Temp id, Temp name)
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

    }
