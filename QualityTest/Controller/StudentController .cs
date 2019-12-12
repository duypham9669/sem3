using QualityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QualityTest.Models.Student;

namespace QualityTest.Controller
{
    class StudentController
    {
        public void PrintListStudent(List<Student> students)
        {
            int ii = 1;
            foreach (Student i in students)
            {
                if (i.Status == 1)
                {
                    Console.WriteLine("Stt: " + ii);
                    Console.WriteLine(i.FullName);
                    Console.WriteLine("-------------------");
                    ii++;
                }
            }
        }
        public Student CreateStudent(String RollNumber, String FullName, DateTime Birthday, String Email, String Phone, DateTime CreatedAt, int Status)
        {
            Student student = new Student(RollNumber, FullName, Birthday, Email, Phone, CreatedAt, Status);
            return student;
        }
    }
}

 
