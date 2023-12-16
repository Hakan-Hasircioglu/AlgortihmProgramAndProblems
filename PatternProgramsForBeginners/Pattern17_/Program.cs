using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern17_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 9; i <= 17; i+=2)
            {
                // I perform subtraction to find the required value for the following number
                i -= 10;
                for (int j = 1; j <= 5; j++)
                {
                    i += 2;
                    Console.Write("{0,3:D}", i);
                }         
                Console.WriteLine();
            }
        }
    }
}
