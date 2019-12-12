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
        private int Status;
        private List<Student> students=new List<Student>();
        private StudentController controller = new StudentController();

        private
        static void Main(string[] args)
        {

            Program mainX = new Program();
            mainX.GenerateMenu();
            Console.ReadLine();
        }
        private void GenerateMenu()
        {
            Boolean chose = true;
            do
            {
                menu();
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        input();
                        break;
                    case 2:
                        show();
                        break;
                    default:
                        Console.WriteLine("MENU");
                        Console.ReadLine();
                        chose = false;
                        break;
                }
            } while (chose);

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
            Console.WriteLine("input Status (1 is Active; 0 is Deactive: )");
            Status = Convert.ToInt32(Console.ReadLine());
            while (Status > 1 && Status < 0)
            {
               
                    Console.WriteLine("input Status (1 is Active; 0 is Deactive: ");
                Status = int.Parse(Console.ReadLine());
          
            };
            CreatedAt = DateTime.Now;
            
            Student student = new Student();
            student=controller.CreateStudent(RollNumber, FullName, Birthday, Email, Phone, CreatedAt, Status);
            students.Add(student);
        }
        private void show()
        {
            
            controller.PrintListStudent(students);
            Console.ReadLine();
        }

    }
}
