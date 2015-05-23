using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[4, 4];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
                if (matrix[i, j] % 2 == 1)
                {
                    matrix[i, j] *= 2;
                }
            }
        } Console.WriteLine(matrix);
    }
}
