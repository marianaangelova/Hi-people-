using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  1 < K < N  ");
            Console.WriteLine("  N = 10,  K = 8 ");
            int n = 10;

            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            int k = 8;

            long factorialk = 1;

            for (int i = 1; i <= k; i++)
            {
                factorialk = factorialk * i;
            }
            int nk = n - k;

            long factorialnk = 1;

            for (int i = 1; i <= nk; i++)
            {
                factorialnk = factorialnk * i;
            }
            Console.WriteLine("N!*K!/(N-K)!=  " + ((factorial * factorialk) / factorialnk));

        }
    }
}
