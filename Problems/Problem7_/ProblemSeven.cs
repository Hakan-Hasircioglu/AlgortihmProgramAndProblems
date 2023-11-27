using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem7_
{
    internal class ProblemSeven
    {
        
        static void Main(string[] args)
        {        
            //What is the 10001st prime number?
            ulong primes = 0;
            for (ulong i = 2; ; i++)
            {
                bool thisIsPrime = true;
                for (ulong j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        thisIsPrime = false;
                    }
                }
                if (thisIsPrime)
                {
                    primes++;
                }
                if (primes==10001) 
                {  
                    Console.WriteLine("Answer: " + i);
                    break; 
                } 
            }
            // Answer: 104743
        }
    }
}
