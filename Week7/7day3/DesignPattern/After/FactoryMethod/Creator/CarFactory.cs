using FactoryMethod.Product;
namespace FactoryMethod.Creator
{
    public class CarFactory : IFactory
    {
        public IProduct CreateProduct()
        {
            return new Car();
        } 

        // public void Produce()
        // {
        //     IProduct product = CreateProduct();
        //     Console.WriteLine("Producing a car.");
        //     product.Assemble();
        //     product.TestProduct();
        // }
    }
}