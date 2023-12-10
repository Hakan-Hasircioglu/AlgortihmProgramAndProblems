using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write( i);
                int j = i + 4;
                j++;
                for (; j <= 25; j += 5)
                {
                    Console.Write("{0,3:D}", j);
                }
                Console.WriteLine();
            }
        }
    }
}
