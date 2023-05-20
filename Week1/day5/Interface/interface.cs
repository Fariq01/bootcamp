namespace Interface;

interface IDrive
    
{
    void drive();
 
}

interface IStop
{
    void stop();
}


interface ITurn
{
    void turn();
}

class car : IDrive, IStop, ITurn
{

    public void drive()
    {
        Console.WriteLine("car drive...");
    }

    public void stop()
    {
        Console.WriteLine("car stop...");
    }

    public void turn()
    {
        Console.WriteLine("car turn...");
    }

}

class plane : IDrive, ITurn
{
    public void drive()
    {
        Console.WriteLine("plane drive...");
    }

    public void turn()
    {
        Console.WriteLine("plane turn...");
    }

}

