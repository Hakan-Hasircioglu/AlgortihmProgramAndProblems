﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_
{
    internal class ProblemOne
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (int i = 0; i < 1000; i++){if (i % 3 == 0 || i % 5 == 0)  {x += i;}}
            Console.WriteLine("Answer: " + x);

        }
        
    }
}
