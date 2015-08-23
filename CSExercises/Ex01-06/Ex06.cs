using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter an integer");
            int x = Convert.ToInt16(Console.ReadLine());
            double y = Convert.ToDouble (x);
            y = Math.Sqrt(x);
            Console.WriteLine("The square root of the number is {0:0.00}", y);
        }
    }
}
