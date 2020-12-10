using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    struct Person
    {
        string _firstname, _lastname;
        byte _age;
        public Person(string firstname, string lastname, byte age)
        {
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
        }
        public string isOlderThan(byte n)
        {
            if (_age > n)
            {
                return $"{_firstname} {_lastname} старший нiж {n}.";
            }
            else if (_age < n)
            {
                return $"{_firstname} {_lastname} молодший нiж {n}.";
            }
            else
            {
                return $"{_firstname} {_lastname} такого самого вiку як {n}";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            string[] input;
            byte n;
            Console.Write("Введiть iмя прiзвище та вiк через пробiл: ");
            input = Console.ReadLine().Split(' ');
            person = new Person(input[0], input[1], byte.Parse(input[2]));
            Console.Write("Введiть рандомне число n (n > 0): ");
            n = byte.Parse(Console.ReadLine());
            Console.WriteLine(person.isOlderThan(n));
            Console.ReadKey();
        }
    }
}