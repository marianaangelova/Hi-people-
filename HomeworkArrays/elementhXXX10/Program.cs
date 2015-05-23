using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elementhXXX10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 3, 7, 8, 9, 11, 7, 6, 8, 10 };

            foreach (int item in array)
            {
                Console.WriteLine(item * 10);
            }
        }
    }
}
