using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern57_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = c = 0;
            b = 1;
            
            Console.WriteLine($"{b,5}");
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    Console.Write($"{c,4}");
                }
                Console.WriteLine();
            }  
        }
    }
}
