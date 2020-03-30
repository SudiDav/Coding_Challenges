using System;
using System.IO;
using System.Linq;

namespace Sock_Merchant
{
    class Program
    {
        // Complete the sockMerchant function below.
        // added this below!
        static int sockMerchant(int n, int[] ar)
        {
            var socks = ar.ToList().GroupBy(x => x);
            var totPairOfSocks = 0;
            foreach (var item in socks)
            {
                totPairOfSocks += item.Count() / 2;
            }
            return totPairOfSocks;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
