namespace enums;

public enum dayOnWeek
{
    monday,    
    tuesday,   
    wednesday, 
    thursday, 
    friday,
    saturday,
    sunday
}

public class employee
{
    public string name;
    public string role;

    List<dayOnWeek> day1 = new List<dayOnWeek>
    {
        dayOnWeek.monday,
        dayOnWeek.tuesday,
        dayOnWeek.wednesday
    };
    List<dayOnWeek> day2 = new List<dayOnWeek>
    {
        dayOnWeek.thursday,
        dayOnWeek.friday,
        dayOnWeek.saturday
    };


    public employee(string name, string role)
    {
        this.name = name;
        this.role = role;
    }

    
    public void workdays()
    {
        
        Console.Write(name + " " + role + " ");

        if(role == "software engineer")
        {
            for(int i = 0; i < day1.Count; i++)
            {
                Console.Write(day1[i]);
            }

            
        }else 
        {
               for(int i = 0; i < day2.Count; i++)
            {
                Console.Write(day2[i]);
            }
        }
    }

}



