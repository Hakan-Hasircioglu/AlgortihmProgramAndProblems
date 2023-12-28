using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern59_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i ; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{0,2}");
                    }
                    else
                    {
                        Console.Write($"{1,2}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
