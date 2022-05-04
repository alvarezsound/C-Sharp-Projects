using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var studentContext = new StudentContext())
            {
                var student = new Student() { StudentId = 0, StudentFName = "Jeff", StudentLName = "Alvarez", StudentGPA = 3.8 };

                studentContext.Students.Add(student);
                studentContext.SaveChanges();

                Console.WriteLine("Student successfully added");
                Console.ReadLine();
            }
        }
    }
}