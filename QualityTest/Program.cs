using QualityTest.Models;
using System;
using System.Collections.Generic;
using QualityTest.Controller;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QualityTest.Models.Student;

namespace QualityTest
{
    
    class Program
    {
        private String RollNumber;
        private String FullName;
        private DateTime Birthday;
        private String Email;
        private String Phone;
        private DateTime CreatedAt;
        private StudentStatus Status;
        private List<Student> students;
        private StudentController controller;

        private 
        static void Main(string[] args)
        {
            Program mainX = new Program();
            mainX.GenerateMenu();
            Console.ReadLine();
        }
        private void GenerateMenu(){
            menu();
            int i = int.Parse(Console.ReadLine());
            Boolean value=true;
            while (value)
            {
                switch (i)
                {
                    case 1:
                        input();
                        break;
                    case 2:
                        show();
                        break;
                    case 3:
                        break;
                }


            }
            
        }
        private void menu()
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1.Create new Student");
            Console.WriteLine("2.Show list Student");
            Console.WriteLine("3.Exit");
        }
        private void input()
        {
            Console.WriteLine("input New Student: ");

            Console.WriteLine("input RollNumber: ");
            RollNumber = Console.ReadLine();
            Console.WriteLine("input FullName: ");
            FullName = Console.ReadLine();
            Console.WriteLine("input Birthday: ");
            Birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("input Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("input Phone: ");
            Phone = Console.ReadLine();
                        Console.WriteLine("input Status (1 is Active; 0 is Deactive: ");
            int check = int.Parse(Console.ReadLine());
            if (check == 1)
            {
                Status = StudentStatus.Active;
            }
            if(check ==0)
            {
                Status = StudentStatus.Deactive;

            }
            students.Add(controller.CreateStudent(RollNumber, FullName, Birthday, Email, Phone, Status));
        
        }
        private void show()
        {
            controller.PrintListStudent(students);
        }

    }
}
