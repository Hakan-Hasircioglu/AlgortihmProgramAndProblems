using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern22_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 0; i <25; i++)
            {
                if (i % 5 == 0)
                {
                    num++;
                    Console.WriteLine();
                }
                if (num % 2 == 0) 
                    Console.Write("{0,2:D}" , 0);
                else
                    Console.Write("{0,2:D}", 1);
            }
            Console.WriteLine();
        }
    }
}
