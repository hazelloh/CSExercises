using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter distance");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 2.40 + (0.4 *(x));
            Console.WriteLine("Total fare is {0:0.00}", y);
        }   
    }
}
