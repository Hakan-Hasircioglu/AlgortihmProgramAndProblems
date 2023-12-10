using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 25; i++)
            {
                // to make it look neater
                if (i < 10)
                {
                    Console.Write(" ");
                }

                Console.Write(" " + i + " ");
                
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
