namespace FactoryMethod
{
    public class SeaLogistic : ILogistic
    {
        public ITransport CreateTransport()
        {
            return new Ship();
        }

        public void PlanningDelivery()
        {
            ITransport transport = CreateTransport();
            Console.WriteLine("Planning delivery using" + transport.GetType().Name);
            transport.Deliver();
        }
    }
}