using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Student
    {
        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
        public string Name { get; set; }
        public int Grade { get; set; }
        public string studentInfo()
        {

            return Name + ": " + Grade;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

                 string Choice = Console.ReadLine();
            while (true)
            {
                List<Student> listName = new List<Student>();
                Console.WriteLine("Do you want to add a student's info?");
                Console.ReadLine();
                if (Choice == "Quit")
                {
                    foreach (Student item in listName)
                    {
                        Console.WriteLine(item.studentInfo());
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("What's the student's name?");
                    string Name = Console.ReadLine();
                    Console.WriteLine("What's their grade?");
                    int Grade = Console.ReadLine();
                    Student Item = new Student(Name, Grade);
                    listName.Add(Item);
                }
                Console.ReadLine();


            }
        }
        
    }
}
