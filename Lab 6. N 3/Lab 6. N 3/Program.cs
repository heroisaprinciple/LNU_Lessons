using System;
using System.Collections.Generic;


namespace Lab_6._N_3
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
            int arrLength = arr.Length;
            bool isBool = false;
            for (int i = 0; i < (arr.Length) / 2; i++)
            {
                if (arr[i] == arr[--arrLength])
                {
                    isBool = true;
                }
                else
                {
                    isBool = false;
                    break;
                }
            }

            if (isBool)
            {
                Console.WriteLine("Array is symmetrical");
            }
            else
            {
                Console.WriteLine("Array is assymetrical");
            }
        }
    }
}