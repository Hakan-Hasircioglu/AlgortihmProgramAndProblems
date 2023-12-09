using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern28_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'E'; i >= 'A'; i--)
            {
                for (char j = 'E'; j >= 'A'; j--)
                {
                    Console.Write("{0,2:D}" , i);
                }
                Console.WriteLine();
            }
        }
    }
}
