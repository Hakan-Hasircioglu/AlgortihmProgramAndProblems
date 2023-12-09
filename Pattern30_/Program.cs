using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern30_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.Write("{0,2:D}" , i);
                num++;
                if (num % 5 == 0)
                {
                    Console.WriteLine();
                }
                
            }
        }
    }
}
