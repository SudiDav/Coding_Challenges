using System;

namespace VolumeOfCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //V = πrexp2h
           
            Console.WriteLine("Enter the Heights");
            double heights = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Radius");
            double radius = Convert.ToDouble(Console.ReadLine());

            var result = Math.PI * Math.Pow(radius, 2) * heights;

            Console.WriteLine($"The Volume is {result:0.##}");
            Console.ReadKey();
        }
    }
}
