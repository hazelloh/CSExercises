﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter distance");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 2.40 + (0.4 * (x));
            y = y * 10;
            y = Math.Round(y);
            Console.WriteLine("Total fare is {0:0.00}", y/10);
        }
    }
}
