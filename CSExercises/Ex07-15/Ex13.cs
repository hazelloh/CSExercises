using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter distance");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 2.40 + (0.4 * (x));
            y = Math.Round(y);
            y = Math.Ceiling(y);
            Console.WriteLine("Total fare is {0}", y);
        }
    }
}
