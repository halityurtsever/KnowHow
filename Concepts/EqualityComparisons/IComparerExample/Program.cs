using System;
using System.Collections.Generic;

namespace IComparerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<Person>();
            personList.Add(new Person("Halit", 35));
            personList.Add(new Person("Yigit Ali", 3));
            personList.Add(new Person("Aysun", 34));

            Console.WriteLine("Sort by Name");
            personList.Sort(new PersonNameComparer());
            ListPersons(personList);

            Console.WriteLine("Sort by Name in reverse order");
            personList.Sort(new PersonNameComparer(true));
            ListPersons(personList);

            Console.WriteLine("Sort by Age");
            personList.Sort(new PersonAgeComparer());
            ListPersons(personList);

            Console.WriteLine("Sort by Age in reverse order");
            personList.Sort(new PersonAgeComparer(true));
            ListPersons(personList);
        }

        private static void ListPersons(List<Person> personList)
        {
            foreach (var person in personList)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
            Console.WriteLine();
        }
    }

    //################################################################################
    #region Person class for comparison

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; }

        public int Age { get; }
    }

    #endregion

    //################################################################################
    #region Name Comparer

    class PersonNameComparer : IComparer<Person>
    {
        private readonly bool m_IsReverse;

        public PersonNameComparer(bool isReverse = false)
        {
            m_IsReverse = isReverse;
        }

        int IComparer<Person>.Compare(Person x, Person y)
        {
            return m_IsReverse ? y.Name.CompareTo(x.Name) : x.Name.CompareTo(y.Name);
        }
    }

    #endregion

    //################################################################################
    #region Age Comparer

    class PersonAgeComparer : IComparer<Person>
    {
        private readonly bool m_IsReverse;

        public PersonAgeComparer(bool isReverse = false)
        {
            m_IsReverse = isReverse;
        }

        int IComparer<Person>.Compare(Person x, Person y)
        {
            return m_IsReverse ? y.Age.CompareTo(x.Age) : x.Age.CompareTo(y.Age);
        }
    }

    #endregion
}

