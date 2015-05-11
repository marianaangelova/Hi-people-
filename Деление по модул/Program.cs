using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Деление_по_модул
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете две целочислени числа:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Остатъкът от вашето деление е:  ");
            Console.WriteLine(a / b);

        }
    }
}
