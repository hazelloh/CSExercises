using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter integer value x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter integer value y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter integer value x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter integer value y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double diffx = Math.Pow(x2-x1,2);
            double diffy = Math.Pow(y2-y1,2);
            Console.WriteLine("Distance between the 2 points{0}",Math.Sqrt(diffx+diffy));


           
        }
    }
}
