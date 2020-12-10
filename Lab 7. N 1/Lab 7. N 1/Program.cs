using System;
using System.Collections.Generic;

namespace Lab_7._N_1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<string> PhoneNumbers { get; set; }
        public Person(string name, int age, IEnumerable<string> phoneNumbers)
        {
            Name = name;
            Age = age;
            PhoneNumbers = phoneNumbers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>
            {
                new Person("Alex", 22, new List<string>() { "0661237896", "0441537545" }),
                new Person("Leonard", 35, new List<string>() { "0723125799", "0951554325" }),
                new Person("Catherine", 19, new List<string>() { "0952100000", "0941543222" }),
                new Person("Maddison", 45, new List<string>() { "0324555750", "0667533395" }),
                new Person("Layla", 18, new List<string>() { "0732133321", "0941567430" })
            };

            foreach (var Person in PersonList)
            {
                Console.WriteLine("\n Name: " + Person.Name + " " + "Age: " + Person.Age);
            }

            Console.WriteLine("\n Using the AddRange Method...");

            PersonList.AddRange(new List<Person>() {
                new Person("Nina", 26, new List<string>() { "0732154655", "0941565434" }),
                new Person("Natalie", 40, new List<string>() { "0732143278", "0941587600" })});

            foreach (var Person in PersonList)
            {
                Console.WriteLine("\n Name: " + Person.Name + " " + "Age: " + Person.Age);
            }

            foreach (var item in PersonList)
            {
                Console.WriteLine("\n {0} phone numbers:", item.Name);
                foreach (var number in item.PhoneNumbers)
                {
                    Console.WriteLine("\t -{0}", number);
                }
            }
        }
    }
}