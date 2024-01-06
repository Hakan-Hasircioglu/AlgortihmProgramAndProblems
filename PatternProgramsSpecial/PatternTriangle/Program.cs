using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTriangle
{
    internal class Program
    {static void Main(string[] args)
        {
            int number = 5; //Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = number - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >= 1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                for (int l = 0; l <= 1; l++)
                {

                }
            }
        }
    }
}