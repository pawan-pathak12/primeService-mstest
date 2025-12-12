namespace PrimeServices.Services
{
    public class MathService
    {
        public bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        public bool IsOdd(int n)
        {
            return n % 2 != 0;
        }
        public int FindMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        public bool IsPositive(int a)
        {
            return a > 0;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Square(int n)
        {
            return n * n;
        }

    }
}
