using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("1'den 100'e kadar olan sayılar:");

        for (int num = 1; num <= 100; num++)
        {
            if (num < 2)
            {
                Console.WriteLine($"{num} asal değildir.");
            }
            else
            {
                bool isThisPrime = true;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isThisPrime = false;
                        break;
                    }
                }

                if (isThisPrime)
                {
                    Console.WriteLine($"{num} asal bir sayıdır.");
                }
                else
                {
                    Console.WriteLine($"{num} asal değildir.");
                }
            }
        }

        Console.ReadLine();
    }
}