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
            foreach (Student i in students)
            {
                if (i.Status.Equals("Active"))
                {
                    Console.WriteLine(i.FullName);

                }
            }
        }
        public Student CreateStudent(String RollNumber, String FullName, DateTime Birthday, String Email, String Phone, DateTime CreatedAt, StudentStatus Status)
        {


            Student student = new Student();
            student.RollNumber = RollNumber;
            student.FullName = FullName;
            student.Birthday = Birthday;
            student.Email = Email;
            student.Phone = Phone;
            student.Status = Status;
            return student;

        }
    }
}
 
