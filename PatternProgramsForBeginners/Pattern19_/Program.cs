using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern19_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num <= 25)
            {
                if (num % 2 == 0)
                {
                    Console.Write("{0,2:D}", 1);
                }
                else
                {
                    Console.Write("{0,2:D}", 0);
                }
                num++;
                if (num % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
