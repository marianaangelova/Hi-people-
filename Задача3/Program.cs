using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Въведете дължината на страната на триъгълника");
            Console.Write("b=");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Въведете дължината на височината на триъгълника");
            Console.Write("h=");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("Лицето на вашият триъгълник е: ");
            Console.Write("S=");
            float s = (b * h) / 2;
            Console.WriteLine(s);

        }
    }
}
