namespace FactoryMethod.Product
{
  public class Phone : IProduct
  {
    public void Assemble()
    {
        Console.WriteLine("Assembling a phone.");
    }

    public void TestProduct()
    {
        Console.WriteLine("Testing the phone.");
    }
 }
 
}