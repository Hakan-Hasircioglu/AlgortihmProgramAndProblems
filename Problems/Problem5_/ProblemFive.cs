using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_
{
    internal class ProblemFive
    {
        static void Main(string[] args)
        {
            /* 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
              What is the smallest positive number that is evenly divisible by all of the numbers from to ?
            */
            bool stopIt = false;
            for (int i = 1; ; i++) //infinite loop start
            {
                int smallestNum = 0;
                for (int j = 1; j <= 20 ; j++) // loop to 10
                {                   
                    if (i % j == 0) 
                    {                        
                        smallestNum = smallestNum + j;                        
                        if (smallestNum == 210)
                        {
                            stopIt = true; // the end condition of the infinite loop
                            Console.WriteLine(i);
                        }
                    }           
                }
                if (stopIt) { break; }// infinite loop end
            }
            // Answer: 232792560
        }
    }
}
