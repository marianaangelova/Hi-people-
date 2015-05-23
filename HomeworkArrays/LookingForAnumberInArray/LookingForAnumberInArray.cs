using System;

    class LookingForAnumberInArray
    {
        static void Main()
        {
            int[] array = new int[] { 10, 3, 7, 8, 9, 11, 7, 6, 8, 10 };
            for (int i = 0; i < array.Length; i++)
            {
                if(i == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

