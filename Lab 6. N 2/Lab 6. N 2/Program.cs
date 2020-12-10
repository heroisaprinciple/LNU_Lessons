using System;
using System.Collections.Generic;


namespace Lab_6._N_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amount of numbers in array: ");
            int a = int.Parse(Console.ReadLine());
            double[] arr = new double[a];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("X: " + i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("The amount of prime numbers: " + count);
        }
    }
}