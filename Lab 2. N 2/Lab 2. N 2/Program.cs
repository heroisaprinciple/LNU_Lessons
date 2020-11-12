using System;

namespace Comparison_of_two
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter second Name: ");
            string secondname = Console.ReadLine();

            bool result = firstname.Equals(secondname, System.StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Ordinal Comparison: {0} and {1} are {2}", firstname, secondname, result ? "equal. " : "not equal. "); //сравнить строчки, не считая uppercase и lowercase
            Console.WriteLine("The length of the first name is: " + firstname.Length);
            Console.WriteLine("The length of the second name is: " + secondname.Length);
            if (firstname.Length > secondname.Length)
            {
                Console.WriteLine(firstname + " is larger than " + secondname);
            }
            else if (firstname.Length == secondname.Length)
            {
                Console.WriteLine(firstname + " is equal to " + secondname);
            }
            else
            {
                Console.WriteLine(secondname + " is larger than " + firstname);
            }
            if (firstname[firstname.Length - 1] == secondname[secondname.Length - 1])
            {
                Console.WriteLine("The last elements are equal.");
            }
            else
            {
                Console.WriteLine("The last elements are not equal.");
            }




        }

    }
}