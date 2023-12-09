using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern32_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character = 'A';
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (int k = 1; k <= 5; k++)
                {
                    Console.Write("{0,2:D}" , character);
                    for (int j = 1; ; j++)
                    {
                         character++;
                         if (j % 5 == 0)
                         {
                             break;
                         }
                    }
                }
                Console.WriteLine();
                character = i;
                character++;
            }
        }
    }
}
