using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern33_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character;
            for (int i = 69; i >= 65; i--)
            {
                character = ((char)i);
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(" " + character);
                    character = ((char)(character + 5));
                }
                Console.WriteLine();
            }
        }
    }
}
