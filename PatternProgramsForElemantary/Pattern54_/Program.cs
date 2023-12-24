using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern54_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1, change = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{ num, 2}");
                    change = num;
                    num++;
                }
                num = change;   
                Console.WriteLine();
            }
        }
    }
}
