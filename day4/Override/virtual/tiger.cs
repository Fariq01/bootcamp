namespace tigerClass;
using animalClass;

class tiger : animal
{
    public int teeth;
    public int claws;

    public tiger(int teeth, int claws) : base (teeth, "surface")
    {
        this.teeth = teeth;
        this.claws = claws;
    }

    public void roar()
    {
        Console.WriteLine("Roar !!!");
    }

    public void dataOfTiger()
    {
        dataOfAnimal("surface", 1, true);
        Console.WriteLine("teeth : " + teeth);
        Console.WriteLine("claws : " + claws);
    }
}

