namespace FactoryMethod
{
    public interface ILogistic
    {
         public ITransport CreateTransport();
         public void PlanningDelivery();
        
    }
}