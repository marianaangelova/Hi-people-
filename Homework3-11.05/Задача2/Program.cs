using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            {
                for(int a = 1; a < n; a++)
                {
                    if((a % 3 != 0) && (a % 7 != 0))
                    {
                        Console.WriteLine(a + " ");
                    }
                }
            }
        }
    }
}
