using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишете низ от символи и конзолата ще провери дали е равен на Hello");
            string hello = "Hello";
            Console.Write("Enter a string:");
            string input = Console.ReadLine();
            bool result = input.ToLower().Equals(hello.ToLower());
            Console.WriteLine("Result is: {0}", result);
        }
    }
}
