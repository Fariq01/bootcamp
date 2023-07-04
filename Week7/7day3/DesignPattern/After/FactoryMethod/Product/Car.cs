namespace FactoryMethod.Product
{
    public class Car : IProduct
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling a car.");
        }

        public void TestProduct()
        {
            Console.WriteLine("Testing the car.");
        }
    }
}