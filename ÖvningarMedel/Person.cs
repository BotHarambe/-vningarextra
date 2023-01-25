using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningarMedel
{
    class Person
    {       public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        class Student : Person
        {
            public int StudentId { get; set; }

            public Student(string name, int age, int studentId) : base(name, age)
            {
                StudentId = studentId;
            }
        }

        class Staff : Person
        {
            public string StaffId { get; set; }

            public Staff(string name, int age, string staffId) : base(name, age)
            {
                StaffId = staffId;
            }
        }

    }

