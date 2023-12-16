using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern16_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            for (int i = 1; i <= 5; i++)
            {
                
                for(int j = 0; j < 5; j++)
                {
                    k = i + j;
                    Console.Write("{0,2:D}" , k);
                }
                Console.WriteLine();
                
            }
           
        }
    }
}
