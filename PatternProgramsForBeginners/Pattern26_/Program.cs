﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern26_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= 'E'; j++)
                    Console.Write("{0,2:D}" , i);
                Console.WriteLine();
            }
        }
    }
}
