using outClass;

static class Program
{
    static void Main()
    {
        int sum;
        int minus;
        
        Kalkulator kal1 = new();
        kal1.Calculate(2,3, out sum, out minus);
        Console.WriteLine("tambah : " + sum + " minus : " + minus);
    }
}