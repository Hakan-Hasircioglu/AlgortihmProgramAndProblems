using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern42_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int add = 0;
            int sub = 1;
            int count = 3;
            for (int i = 1; i <= 20; i++)
            {
                if (i > count)
                {
                    i = i - sub;
                    Console.WriteLine();
                    count += 2;
                    sub++;
                }
                Console.Write("{0,2:D}" , i);
                if (i == 1) { Console.WriteLine(); }
            }
            Console.WriteLine();
            /* I learned better
            
             for(int i = 1; i <= 5; i++)
                {
                for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" " + (i + j - 1));
                    }
                    Console.WriteLine();
                }
             */
        }
    }
}
