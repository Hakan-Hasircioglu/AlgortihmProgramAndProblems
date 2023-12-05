using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern24_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("{0,2:D}" , 1);
                    }
                    else
                    {
                        Console.Write("{0,2:D}", 0);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
