int n = Convert.ToInt32(Console.ReadLine());
string a = "foo";
string b = "bar";

for(int i = 1; i <= n; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
  
        Console.Write(a + b);
        
    }else if(i % 3 == 0)
    {
 
        Console.Write(a);
    }
    else if(i % 5 == 0)
    {
      
        Console.Write(b);
    }
        
    else
    {
        Console.Write(i);
    }
    
}