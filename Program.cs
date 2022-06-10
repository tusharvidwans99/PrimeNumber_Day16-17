namespace PrimeNumberRange
{

    /// <summary>
    /// In this program we are going to see multiple operation on prime numbers and on Collections.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            Check check = new Check();
            int status = 1;
            Console.WriteLine("Enter the range of numbers from 2 to check it is Prime or Not: ");
            Console.Write("start: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("End: ");
            int end = Convert.ToInt32(Console.ReadLine());
            int num = start;

            Console.WriteLine("Prime Numbers are: ");
            while (num <= end)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        //Console.WriteLine($"{num} is not a prime number");
                        status = 0;
                        break;
                    }
                }
                if (status == 1)
                {
                    Console.Write($"Prime Number: {num} :");
                    check.isPalindrome(num);
                }

                num++;
                status = 1;
            }

        }
    }
}