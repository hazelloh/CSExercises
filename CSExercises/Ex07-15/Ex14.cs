using System;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter side a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter side b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter side c");
            double c = Convert.ToDouble(Console.ReadLine());
            double y = (a+b+c)/2;
            double area = y*((y-a)*(y-b)*(y-c));
            Console.WriteLine("Area of Triangle {0}",Math.Sqrt(area));


        }
    }
}