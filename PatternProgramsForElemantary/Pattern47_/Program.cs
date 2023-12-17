using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern47_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int after;
            for (int i = 1; i <= 5; i++)
            {
                after = i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,3:D}" , after);
                    after += i;
                }
                Console.WriteLine();
            }
        }
    }
}
