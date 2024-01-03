using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern69_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Char k;
            for (char i = 'A'; i <= 'E'; i++)
            {
                k = i;
                for (char j = 'A'; j <=i; j++)
                {
                    Console.Write($"{k,2}");
                    k--;
                }
                Console.WriteLine();
            }
        }
    }
}
