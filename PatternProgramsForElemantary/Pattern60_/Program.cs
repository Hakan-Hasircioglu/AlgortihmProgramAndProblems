using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern60_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    a = i % 2;
                    Console.Write($"{a,2}");
                }
                Console.WriteLine();
            }
        }
    }
}
