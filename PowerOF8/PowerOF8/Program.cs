using System;

namespace PowerOF8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBase = 2;
            int exp = 8;
            int result = 1;
            while (exp > 0)
            {
                result = result * numBase;
                exp--;
            }
            Console.WriteLine($"Result is {result}");
        }
    }
}
