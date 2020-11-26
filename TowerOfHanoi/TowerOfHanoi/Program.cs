using System;
using static System.Console;

namespace TowerOfHanoi
{
    internal class Program
    {
        private static int count = 0;

        private static void Main(string[] args)
        {
            var discs = 0;
            WriteLine("Please enter the number of Discs!");
            discs = Convert.ToInt32(ReadLine());
            Tower(discs, 1, 2, 3);
        }

        private static void Tower(int n, int sourcePeg, int destinationPeg, int sparePeg)
        {
            if (n == 1)
            {
                WriteLine(count + " " + sourcePeg + "->" + destinationPeg);
                count++;
            }
            else
            {
                Tower(n - 1, sourcePeg, sparePeg, destinationPeg);
                WriteLine(count + " " + sourcePeg + "->" + destinationPeg);
                count++;
                Tower(n - 1, sparePeg, destinationPeg, sourcePeg);
            }
        }
    }
}