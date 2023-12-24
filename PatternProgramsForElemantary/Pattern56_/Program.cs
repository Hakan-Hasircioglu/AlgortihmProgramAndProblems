using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern56_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, add = 4;
            for (int i = 1; i <= 5; i++)
            {     
                k = i;

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{k , 3}");
                    k += add;
                    add--; 
                }
                add = 4;
                Console.WriteLine();
            }
        }
    }
}
