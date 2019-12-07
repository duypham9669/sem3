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
