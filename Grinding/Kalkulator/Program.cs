using Kalkulator;

static class Program
{
    static void Main()
    {

        int[] numbers = {1, 2, 3, 4, 5};
        int result = 0;

        Calculator calc1 = new();
        calc1.SumAverage(ref result, numbers);
        Console.WriteLine(result);

        int divide = 0;
        int modulo = 0;
        int a = 10;
        int b = 5;

        calc1.Divide(a,b, out divide, out modulo);
        Console.WriteLine(divide + " " + modulo);

        List<int> numberList = new() {1,2,3,4,5};
        int OutputList = calc1.DisplayList(in numberList);

        Console.WriteLine(OutputList);
    


    }
}