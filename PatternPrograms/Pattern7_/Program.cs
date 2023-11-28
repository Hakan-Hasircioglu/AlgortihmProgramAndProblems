using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 50; i+=2)
            {
                Console.Write("{0,3:D}", i );
                
                if (i % 10 == 9)
                {
                    Console.WriteLine();
                }
            }
            
        }
    }
}
