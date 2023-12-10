using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern14_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                Console.Write(i);
                for (int j = i + 5; j <= 25; j += 5)
                {
                    Console.Write("{0,3:D}", j);
                }
                Console.WriteLine();
            }
        }
    }
}
