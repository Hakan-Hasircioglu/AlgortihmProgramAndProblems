using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong num = 0;
            ulong total = 0;
            for (ulong i = 1; ; i++)
            {
                num +=i;
                total = 0;
                ulong j = 1;
                for ( ; j < num+1; j++) 
                {
                    ;
                    if (num % j == 0 )
                    {
                        Console.WriteLine(j);
                        total++;
                        
                    }
                    
                }
                if (total >= 5) { Console.WriteLine(num + " " + i + "th"); return; }
            }
        }
    }
}
