using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_
{      
    internal class ProblemThree
    {      
        static void Main(string[] args)
        {
            ulong num = 13195;
            for (ulong i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    num /= i;
                }
            }
            if (num != 1)   { Console.WriteLine(num); }
        }

    }

}