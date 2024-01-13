using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMultiplicationTable_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = -1;
            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i}x{j} = {i * j}| ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
