using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a number ");
            double x = Convert.ToDouble(Console.ReadLine());
            x = Math.Sqrt(x);
            Console.WriteLine("The square root of the number is {0:.000}", x);
        }
    }
}
