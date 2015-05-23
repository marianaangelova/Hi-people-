using System;

    class HomeworkArrays
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 3, 7, 8, 9, 11 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
