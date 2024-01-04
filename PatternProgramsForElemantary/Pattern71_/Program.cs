using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern71_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 5; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(k);
                }
                k++;
                Console.WriteLine();
            }
        }
    }
}