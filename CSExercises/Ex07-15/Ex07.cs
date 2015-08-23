using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter salary");
            double x= Convert.ToDouble(Console.ReadLine());
            double HousingAllowance = 0.1*x;
            double TransportAllowance = 0.03*x;
            Console.WriteLine("Total Income is {0:c}",HousingAllowance+TransportAllowance+x);
            
        }
    }
}
