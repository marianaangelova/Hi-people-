using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string...");
            string a = Console.ReadLine();
            Console.WriteLine("Select a number of position...");
            int n = int.Parse(Console.ReadLine());
            Console.Write("This is your letter:");
            Console.WriteLine(a[n-1]);
        }
    }
}
