using System;

namespace Pattern23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 1; i <= 25; i++)
            {
                if (num % 2 == 0)
                {
                    Console.Write("{0,2:D}" , 0);
                }
                else
                {
                    Console.Write("{0,2:D}", 1);
                }
                if (i % 5 == 0)
                {
                     num++;
                    Console.WriteLine();
                }
                
                
            }
        }
    }
}
