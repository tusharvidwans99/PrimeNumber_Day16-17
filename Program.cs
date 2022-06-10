namespace PrimeNumberRange
{

    /// <summary>
    /// In this program we are going to see multiple operation on prime numbers and on Collections.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> primes = new List<int>();


            Check check = new Check();
            Console.WriteLine("Enter the range of numbers from 2 to check it is Prime or Not: ");
            Console.Write("start: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("End: ");
            int end = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine($"Prime Numbers which is Anagrams too in the range {start}-{end} are: ");

            for (int i=start; i<=end;i++)
            {
                if (check.isPrime(i))
                {
                    if (check.isPalindrome(i))
                    {
                        primes.Add(i);

                    }
                }

            }

            Program program = new Program();
            program.printList(primes);
        }

        public void printList(List<int> Primes)
        {
            foreach(int element in Primes)
            {
                Console.WriteLine(element);
            }
        }

        
    }
}