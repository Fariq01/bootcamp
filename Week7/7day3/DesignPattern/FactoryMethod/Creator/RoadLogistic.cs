namespace FactoryMethod
{
    public class RoadLogistic : ILogistic
    {
        public ITransport CreateTransport()
        {
            return new Truck();
        }

        public void PlanningDelivery()
        {
            ITransport transport = CreateTransport();
            Console.WriteLine("Planning delivery using " + transport.GetType().Name);
            transport.Deliver();
        }
    }
}