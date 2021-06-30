using System;
using System.Collections.Generic;
using System.Linq;

namespace lab300621
{
    class Program
    {
        static void Main()
        {
            int countPersons = 20;
            List<Person> persons = new List<Person>();
            
            for (int i = 0; i < countPersons; i++)
            {
                Person currentPerson = CreatePerson(i);
                persons.Add(currentPerson);
            }

            ShowPersons(persons);
            Console.WriteLine("--------------------------------------------");
            ShowPersons(persons, Work.Developer);
            Console.WriteLine("--------------------------------------------");
        }

        public static Person CreatePerson(int id)
        {
            //Console.WriteLine("Введите Имя:");
            //string name = Console.ReadLine();
            string name = "Илья_" + id;
            //Console.WriteLine("Введите возраст:");
            //int age = int.Parse(Console.ReadLine());
            int age = id + 23;
            //Console.WriteLine("Введите тип работы (int): ");
            //int intJob = int.Parse(Console.ReadLine());
            int intJob = (new Random()).Next((int)Work.Unemployed, (int)Work.Seller + 1);

            return new Person(name, id, age, (Work)intJob);
        }

        public static void ShowPersons(List<Person> persons, Work currentWork = Work.Undefiend)
        {
            var showPersons = persons
                .Where(x => (x._job == currentWork) || (currentWork == Work.Undefiend))
                .ToList();

            foreach (var showPerson in showPersons)
            {
                Console.WriteLine();
                showPerson.DisplayInfo();
            }
        }
    }
}