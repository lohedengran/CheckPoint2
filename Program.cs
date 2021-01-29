using System;
using System.Collections.Generic;

namespace CheckPoint2
{

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int age;

        public int Age
        {
            set
            {
                if (value >= 0 && value <= 125)
                    age = value;
                else
                    throw new Exception("Age must be in the range of 1 to 125");
            }
            get { return age; }
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6];
            people[0] = new Person("Bo", "Andersson", 45);
            people[1] = new Person("Li", "Johansson", 34);
            people[2] = new Person("An", "Pettersson", 43);
            people[3] = new Person("Io", "Johansson", 66);
            people[4] = new Person("El", "Karlsson", 20);
            people[5] = new Person("Lo", "Pettersson", 55);

            foreach (var item in people)
            {
                Console.WriteLine($"Name: {item.FirstName} {item.LastName}. Age: {item.Age}");
            }
            Console.WriteLine(AverageAge(people, "Pettersson"));
        }

        private static int AverageAge(Person[] people, string nameToExclude)
        {
            int sumOfAge = 0;
            int counter = 0;

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].LastName != nameToExclude)
                {
                    sumOfAge += people[i].Age;
                    counter++;
                }
            }
            int averageAge = sumOfAge / (counter);
            return averageAge;
        }
    }
}
