using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern38_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("{0,2:D}" , j);
                }
                Console.WriteLine();
            }
        }
    }
}
