using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First string...");
            string a = Console.ReadLine();
            Console.WriteLine("Second string...");
            string b = Console.ReadLine();
            Console.WriteLine("Result:");
            Console.WriteLine();
            Console.WriteLine(a.Contains (b));
            Console.WriteLine();
        }
    }
}
