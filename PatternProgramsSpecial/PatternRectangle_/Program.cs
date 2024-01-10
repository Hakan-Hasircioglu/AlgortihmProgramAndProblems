using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatterrnRectangle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int input_ = Convert.ToInt32(Console.ReadLine());
                if (input_ == 0)
                    continue;
                Console.WriteLine(new string('_', (input_ * 2) + 2));
                for (int i = 1; i <= input_; i++)
                {
                    Console.Write('|');
                    for (int j = 1; j <= (input_ * 2); j++)
                    {
                        if (i == input_)
                        {
                            Console.Write(new string('_', input_ * 2));
                            break;
                        }
                        else
                            Console.Write(" ");
                    }
                    
                    Console.Write('|');
                    Console.WriteLine();
                }
            }
        }
    }
}
