using FactoryMethod.Product;
namespace FactoryMethod.Creator
{
    public interface IFactory
    {
         IProduct CreateProduct();
        //  void Produce();
    }
}