namespace birdClass;
using animalClass;

class bird : animal
{
    public string beak;
    public string feather;

    public bird(string beak, string feather):base(2, feather)
    {
        this.beak = beak;
        this.feather = feather;
    }

    public void tweet()
    {
        Console.WriteLine("tweet..");
    }

    //override method dari class animal
    public override void dataOfAnimal(int id, string habitat)
    {
        
        Console.WriteLine("bird id : " + id);
        Console.WriteLine("bird habitat : " + habitat);
    }
}
