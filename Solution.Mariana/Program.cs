using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Mariana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1(x+y)");
            Console.WriteLine("Please enter a new number");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x + y);
            Console.WriteLine("Горният ред е равен на сбора от променливите x и y");

        }
    }
}
