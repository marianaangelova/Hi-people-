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
            double number, maxValue = Double.MinValue, minValue = Double.MaxValue;
            string goOn = "Y";

            Console.WriteLine("Please enter a series of numbers, when you wish to stop entering numbers please enter -99.");
            Console.WriteLine("The smallest and largest values will then be displayed.");
            Console.WriteLine("Remember not to enter 777 unless you want the series to end.");
            do
            {
                while (!double.TryParse(Console.ReadLine(), out number))
                    Console.WriteLine("Please enter whole numbers only");

                while (number != 777)
                {
                    process(ref minValue, ref maxValue, number);

                    while (!double.TryParse(Console.ReadLine(), out number))
                        Console.WriteLine("Please enter whole numbers only");
                }
                Console.WriteLine("The smallest value is {0} and the largest value is {1}.", minValue, maxValue);
                Console.WriteLine("Do you want to enter another series of numbers?");
                Console.WriteLine("If so enter y, if you want to end press any other key");
                goOn = Console.ReadLine();
                if (goOn.ToUpper() == "Y")
                {
                    Console.WriteLine("Please enter your set of numbers.");
                    Console.WriteLine("Remember not to enter 77 unless you want the series to end.");
                }

            } while (goOn.ToUpper() == "Y");
        }
        static void process(ref double minValue, ref double maxValue, double number)
        {
            if (number > maxValue)
            {
                maxValue = number;
            }
            if (number < minValue)
            {
                minValue = number;
            }
        }
    }
}
