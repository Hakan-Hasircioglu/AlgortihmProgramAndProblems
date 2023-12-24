using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern55_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int add = 3, k = 1;
            for (int i = 1; i <= 100;)
            {               
                for (int j = 1; j <= k; j++)
                {
                    Console.Write($"{i,4}");
                    i += add; add += 2;
                }
                Console.WriteLine();
                k++;
            }
        }
    }
}
