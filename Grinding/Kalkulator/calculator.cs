namespace Kalkulator;

    public class Calculator
    {
        
        public void SumAverage(ref int result, int[] numbers)
        {
            int sum = 0;
            foreach(var i in numbers)
            {
                sum += i;
            }

            result = sum / numbers.Length;

        }

        public void Divide(int a, int b, out int divide, out int modulo)
        {
            divide = a / b;
            modulo = a % b;
        }

        public int DisplayList(in List<int> list)
        {
            int result = 0;
            // List<int> list = new() {6,7,8,9,10};

            foreach(var i in list)
            {
                result += i;
            }

            return result;

        }


    }
