using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4_
{
    class ProblemFour
    {
        static void Main(string[] args)
        {
            int largestPalindrome = 0;
            int Palindrome = 0;
            for (int i = 1000; i > 100; i--)
            {
                for (int j = 1000; j > 100; j--)
                {
                    Palindrome = i * j;
                    string stringPalindrome = Palindrome.ToString();
                    char[] charArray = stringPalindrome.ToCharArray();
                    Array.Reverse(charArray);
                    int reversePalindrome = int.Parse(new string(charArray));
                    if (Palindrome == (reversePalindrome))
                    {
                        if (Palindrome > largestPalindrome) { largestPalindrome = Palindrome; }
                    }
                }
            }
            Console.WriteLine(largestPalindrome);
        }
    }
}
