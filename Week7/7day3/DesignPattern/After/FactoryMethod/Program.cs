using FactoryMethod.Creator;
using FactoryMethod.Product;

class Program
{
    static void Main()
    {
        // IFactory carFactory = new CarFactory();
        // carFactory.Produce();

        // IFactory phoneFactory = new PhoneFactory();
        // carFactory.Produce();

        IFactory carFactory = new CarFactory();
        IProduct car = carFactory.CreateProduct();
        car.Assemble();

        IFactory phoneFactory = new PhoneFactory();
        IProduct phone = phoneFactory.CreateProduct();
        phone.Assemble();
    }
}