using FactoryMethod;

class Program
{
    static void Main()
    {
        ILogistic roadLogistic = new RoadLogistic();
        roadLogistic.PlanningDelivery();

        ILogistic seaLogistic = new SeaLogistic();
        seaLogistic.PlanningDelivery();
    }
}