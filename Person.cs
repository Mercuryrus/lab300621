using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab300621
{
    class Person
    {
        public string _name;
        public int _id;
        public int _age;
        public Work _job;

        public Person(string name, int id, int age, Work job)
        {
            _name = name;
            _id = id;
            _age = age;
            _job = job;
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {_name} ID: {_id} Age: {_age} Job: {_job.ToString()}");
        }
    }
}

