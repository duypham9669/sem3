using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityTest.Models
{
    class Student
    {
        public enum StudentStatus
        {
            Active,
            Deactive
        };
        public String RollNumber { get; set; }
        public String FullName { get; set; }
        public DateTime Birthday { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public StudentStatus Status { get; set; }
        public Student(String RollNumber, String FullName, DateTime Birthday, String Email, String Phone, DateTime CreatedAt, int Status)
        {
            this.RollNumber = RollNumber;
            this.FullName = FullName;
            this.Birthday = Birthday;
            this.Email = Email;
            this.Phone = Phone;
            this.CreatedAt = CreatedAt;
            this.Status = Status;

        }

        public Student()
        {
        }
        public Boolean IsNewStudent(DateTime dateStudent)
        {
            return (((dateStudent - DateTime.Now).TotalDays) > 60) ? true : false ;
        }

        public Boolean IsDeactive(String studentStudent)
        {
            return (studentStudent.Equals("Deactive")) ? true : false;
        }

    }
}
