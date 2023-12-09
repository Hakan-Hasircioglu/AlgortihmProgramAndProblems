using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 50; i+=2)
            {
                Console.Write("{0,3:D}",i);
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
