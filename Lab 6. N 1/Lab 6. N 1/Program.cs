using System;
using System.Collections.Generic;


namespace Lab_6._N_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Amount of the elements in array: ");
            int a = int.Parse(Console.ReadLine());
            double[] masive = new double[a];
            for (int i = 0; i < masive.Length; i++)
            {
                Console.WriteLine("X: " + i);
                masive[i] = int.Parse(Console.ReadLine());
            }
            double[] masivecube = new double[a];
            for (int i = 0; i < masive.Length; i++)
            {
                masivecube[i] = Math.Pow(masive[i], 3);
                Console.WriteLine(masivecube[i]);
            }
        }
    }
}