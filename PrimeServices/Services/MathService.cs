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

        public int Reverse(int input)
        {
            int num = input;
            int reminder, reverse = 0;

            while (num != 0)
            {
                reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num /= 10;
            }
            return reverse;
        }
        public string ReverseString(string input)
        {
            string result = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }

            return result;

        }

        public bool IsPalindrome(string input)
        {
            string reverse = "";
            string data = input;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }
            if (reverse != data)
            {
                return false;
            }
            return true;
        }
    }
}
