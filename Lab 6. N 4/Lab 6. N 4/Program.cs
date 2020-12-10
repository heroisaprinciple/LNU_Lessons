using System;
using System.Collections.Generic;


namespace Lab_6._N_4
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amount of cells in array: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Amount of rows in array: ");
            int b = int.Parse(Console.ReadLine());
            int[,] arr = new int[a, b];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("X: " + i + "Y:" + j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("---------------\n Our array\n---------------\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            Console.WriteLine("The largest value in the array: " + max);
        }
    }
}