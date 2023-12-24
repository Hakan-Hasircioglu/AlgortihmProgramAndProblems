using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern51_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int subs = 0, subs2 = 0, k = 1, alt = 0;
            Console.WriteLine("_____________________");
            for (int i = 15; i >= 1; i -= subs)
            {

                alt = i;
                subs++;
                for (int j = 1; j <= k; j++)
                {

                    Console.Write("|" + "{0,2}", alt);
                    alt -= subs2;
                    subs2 = 1;
                }
                Console.WriteLine("|");
                Console.Write("_____________________");
                Console.WriteLine();
                k++;
            }
        }
    }
}
