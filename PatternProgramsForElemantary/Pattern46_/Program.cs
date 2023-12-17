using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern46_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 2;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,3:D}", sum);
                    sum += 2;
                }
                Console.WriteLine();
            }
        }
    }
}
