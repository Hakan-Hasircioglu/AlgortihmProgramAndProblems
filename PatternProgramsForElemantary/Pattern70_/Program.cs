using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern70_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int s = i; s >= 1; s--)
                {

                    Console.Write($"{"  _  ",10}");
                }
                Console.WriteLine();
                for (int p = i; p >= 1; p--)
                {
                    Console.Write($"{" /|\\ ",10}");

                }
                Console.WriteLine();
                for (int r = i; r >= 1; r--)
                {
                    Console.Write($"{"//|\\\\",10}");
                }
                Console.WriteLine();
                for (int j = i; j >= 1; j--)
                {
                    Console.Write($"{"{-_-}",10}");

                }
                Console.WriteLine();

                for (int t = i; t >= 1; t--)
                {
                    Console.Write($"{"_---_",10}");

                }
                Console.WriteLine();
                for (int k = i; k >= 1; k--)
                {
                    Console.Write($"{" /_|_\\",10}");

                }
                Console.WriteLine();
                for (int q = i; q >= 1; q--)
                {
                    Console.Write($"{"   | | ",10}");

                }
                Console.WriteLine();
                for (int w = i; w >= 1; w--)
                {
                    Console.Write($"{" |_|_",10}");

                }
                Console.WriteLine();
            }
            
        }
    }
}
