namespace animalClass;

class animal
{
    protected int id;
    protected string habitat;
    public animal(int id, string habitat)
    {
        this.id = id;
        this.habitat = habitat;        
    }

    public virtual void dataOfAnimal (int id, string habitat)
    {
        Console.WriteLine("id : " + id);
        Console.WriteLine("habitat : " + habitat);
    }

    protected void dataOfAnimal (string habitat, int id, bool isAlive)
    {
        Console.WriteLine("id : " + id);
        Console.WriteLine("habitat : " + habitat);
        Console.WriteLine("isAlive :" + isAlive);
    }


}