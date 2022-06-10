using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberRange
{
    public class Check
    {
        public bool isPalindrome(int PrimeNum)
        {

            int rem, rev = 0, num = PrimeNum;

            while (num != 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }

            if(rev == PrimeNum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool isPrime(int num)
        {
            int status = 1;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    //Console.WriteLine($"{num} is not a prime number");
                  
                    return false;
                }
            }
            if (status == 1)
            {
                return true;
            }
            return false;

        }

        
    }
}
