using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern44_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int add = 1, iBefore;
            for (int i = 1; i <= 10; i += add)
            {
                iBefore = i;
                for (int j = 1; j <= add; j++)
                {
                    Console.Write("{0,3:D}" , i);
                    i--;
                }
                i = iBefore;
                add++;
                Console.WriteLine();
            }
        }
    }
}
