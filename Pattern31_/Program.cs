using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern31_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character;
            for (char i = 'A'; i <= 'E'; i++)
            {
                character = i;
                for (int j = 1; ; j++)
                {
                    Console.Write("{0,2:D}" , character);
                    character++;
                    if (j % 5 == 0 )
                    {
                        break;
                    }     
                }
                Console.WriteLine();
            }   
        }
    }
}
