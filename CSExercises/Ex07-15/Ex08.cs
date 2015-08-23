using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a temperature in Celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = (1.8 * celsius) + 32;
            Console.WriteLine("The temperature in Fahrenheit:{0}", fahrenheit);

        }
    }
}
