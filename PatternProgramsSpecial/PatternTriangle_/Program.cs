using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTriangle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int input_ = Convert.ToInt32(Console.ReadLine());
                if (input_ == 0 || input_ < 1 )
                    Console.WriteLine
                        (
                        $"Try the available numbers\t" +
                        $"Availabe numbers > 0 "
                        );
                for (int i = 1; i <= input_; i++)
                {
                    for (int j = input_ - 1; j >= i; j--)
                        Console.Write(" ");
                    Console.Write(" /");
                    if (i == input_)
                        Console.Write(new string('_', (input_ * 2)-2));
                    for (int h = 1; h < i; h++)
                    {
                        if (i >= input_ )
                            continue;
                        else
                            Console.Write("  ");
                    }
                    Console.Write("\\"); Console.WriteLine();
                }
            }
        }
    }
}
