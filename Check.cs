using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberRange
{
    public class Check
    {
        public void isPalindrome(int PrimeNum)
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
                Console.WriteLine("It is Palindrome");
            }
            else
            {
                Console.WriteLine("It is not Palindrome");
            }

        }
    }
}
