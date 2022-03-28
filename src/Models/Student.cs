using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YudemyAPI.Models
{
    public class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public double Funds { get; private set; }
        public ICollection<Course> Courses { get; private set; }

        public Student()
        {
            Courses = new HashSet<Course>();
        }

        public Student(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }

        public void AddFunds(double funds)
        {
            Funds += funds;
        }

        public void DebitFunds(double funds)
        {
            if (Funds >= funds)
                Funds -= funds;
        }
    }
}
