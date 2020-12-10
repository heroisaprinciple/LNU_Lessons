using System;
using System.Collections.Generic;


namespace Lab_6._N_5
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The amount of rows: ");
            int a = int.Parse(Console.ReadLine());
            int[][] arr = new int[a][];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("The amount of cells: ");
                int b = int.Parse(Console.ReadLine());
                arr[i] = new int[b];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("X: " + i + "Y:" + j);
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("---------------\n Array\n---------------\n");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
            int max = arr[0][0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }
                }
            }
            Console.WriteLine("The largest value is : " + max);
        }
    }
}


