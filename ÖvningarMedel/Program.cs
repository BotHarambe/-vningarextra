using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningarMedel
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x == 0)
            {
                var staffList = new List<Staff>();
                var studentList = new List<Student>();

                int numStaff = 2;
                int numStudent = 5;

                for (int i = 0; i < numStaff; i++)
                {
                    staffList.Add(new Staff("Staff" + (i + 1), 30, "S" + (i + 1)));
                    Console.WriteLine(staffList[i].Name);
                }

                for (int i = 0; i < numStudent; i++)
                {
                    studentList.Add(new Student("Student" + (i + 1), 20, i + 1));
                    Console.WriteLine(studentList[i].Name);
                }
                x = 1;
            }
            Console.ReadLine();
        }
    }
}

