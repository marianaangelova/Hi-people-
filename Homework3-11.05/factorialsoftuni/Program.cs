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

            Console.WriteLine("N!/K! =  " + factorial / factorialk);

        }
    }
}
