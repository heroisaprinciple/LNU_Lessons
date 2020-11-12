using System;
class Number
{
    static int Main()
    {

        int m, n;
        Console.WriteLine("Choose m (1<m<5)...");
        m = int.Parse(Console.ReadLine());
        if (m < 1 || m > 5)
        {
            Console.WriteLine("The code will not work due to the condition");
            return 0;
        }
        Console.WriteLine("Choose n (1<n<5)");
        n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 5)
        {
            Console.WriteLine("The code will not work due to the condition");
            return 0;
        }
        Console.WriteLine("m^n=" + Math.Pow(m, n));
        return 0;
    }
}