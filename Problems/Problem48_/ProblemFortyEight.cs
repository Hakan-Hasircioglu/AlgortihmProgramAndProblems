using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem48_
{
    internal class ProblemFortyEight
    {
        
        static void Main(string[] args)
        {
            BigInteger primeSum = 0, sum = 0, answer;
            for (int i = 1; i <= 1000; i++)
            { 
                primeSum = BigInteger.Pow(i, i);
                sum += primeSum;
                primeSum = 0;                
            }
            answer = sum % 10000000000; //Find the last ten digits of the series
            Console.WriteLine(answer); 
        }
    }
}
