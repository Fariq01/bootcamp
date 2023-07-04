// abstrak produk
public interface IProduct
{
    void Assemble();
}

// Implementasi produk Mobil
public class Car : IProduct
{
    public void Assemble()
    {
        Console.WriteLine("Assembling a car.");
    }
}

// Implementasi produk Telepon
public class Phone : IProduct
{
    public void Assemble()
    {
        Console.WriteLine("Assembling a phone.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IProduct car = new Car();
        car.Assemble();

        IProduct phone = new Phone();
        phone.Assemble();

        Console.ReadLine();
    }
}
