using FactoryMethod.Product;
namespace FactoryMethod.Creator
{
    public class PhoneFactory : IFactory
    {
        public IProduct CreateProduct()
        {
            return new Phone();
        }

        // public void Produce()
        // {
        //     IProduct product = CreateProduct();
        //     Console.WriteLine("Producing a phone.");
        //     product.Assemble();
        //     product.TestProduct();
        // }
    }
}