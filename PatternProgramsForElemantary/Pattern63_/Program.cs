using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern63_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{(j + k) % 2,2}");
                }
                Console.WriteLine();
                k++;
            }
            
        }
    }
}
