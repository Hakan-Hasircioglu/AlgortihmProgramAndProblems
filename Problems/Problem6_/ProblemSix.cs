using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_
{
    internal class ProblemSix
    {
        static void Main(string[] args)
        {
            /*
             Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
             */
            int sumSqrNum, sqrNum, sumNumSqr, sumNum ;
            sumSqrNum = sqrNum = sumNum = sumNumSqr = 0;
            int result;

            for (int i = 1; i <= 100; i++)
            {
                {// find The sum of the squares of the first hundred natural numbers is
                    sqrNum = i * i;
                    sumSqrNum += sqrNum;                   
                }
                {// The square of the sum of the first hundred natural numbers is
                    sumNum =sumNum + i;
                    sumNumSqr = sumNum * sumNum;                    
                }
            }
            result = sumNumSqr - sumSqrNum;
            Console.WriteLine(result);
            // Answer: 25164150
        }
    }
}
