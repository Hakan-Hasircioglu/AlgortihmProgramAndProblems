using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern41_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            int add = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i >= num)
                {
                    Console.WriteLine();
                    num = num + add + 2;
                    add++;
                }
                if (i == 10) { Console.Write("{0,3:D}", i); }  else { Console.Write("{0,2:D}", i); } // Just for looks 
            }
            Console.WriteLine();
        }
    }
}
