namespace nested;
public class department
{ 
    public string deptName{get; set;}

    public department(string deptName)
    {
        this.deptName = deptName;
    }

    public void displayDepartment()
    {
        Console.WriteLine("Department : " + deptName);
    }


  public class employeee 
    {
        string employee;
        List<string> employees;
        

        public employeee()
        {
            employees = new List<string>();
        }


        public void addEmployee(string name)
        {

                employees.Add(name);
                
        }

        public void displayEmployee()
        {
            Console.WriteLine("employee : ");

            for(int i = 0; i < employees.Count; i++)
            {
                 Console.WriteLine(employees[i]);
            }
           
        }

    
        

    }
}


