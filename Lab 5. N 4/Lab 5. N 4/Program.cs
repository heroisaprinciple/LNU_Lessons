using System;
using System.Collections.Generic;


namespace Lab_5._N_4
{
    public enum Colors { Red = 52, Blue = 14, Green = 2, Yellow = 7, Cyan = 72, Black = 666, Magenta = 100 }
    public static class Extensions
    {
        public static void PrintColors(this Colors color)
        {
            int[] values = (int[])Enum.GetValues(color.GetType());
            Array.Sort(values);
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("{0} = {1}", (Colors)values[i], values[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Colors someColor = Colors.Red;
            someColor.PrintColors();
        }
    }
}