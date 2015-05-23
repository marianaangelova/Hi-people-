using System;

namespace b_bigger_than_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int c = a; c < b; c++)
            {
                if(c % 3 == 0)
                {
                    Console.WriteLine(c);
                }
            }

        }
    }
}
