using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern40_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 10; i+=2)
            {
                for (int j = 2; j <= i; j+=2)
                {
                    if (j == 10)
                    {
                        Console.Write("{0,3:D}", j);
                    }
                    else
                    {
                        Console.Write("{0,2:D}" , j);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
