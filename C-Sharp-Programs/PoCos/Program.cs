using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class DriversLicense
    {
        public DriversLicense(string firstName, string lastName, string gender, int ln)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            LicenseNumber = ln;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int LicenseNumber { get; set; }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            DriversLicense dl = new DriversLicense("Tim", "Smith", "Male", 1234);
            string fullName = dl.GetFullName();
            Console.WriteLine(fullName);
            Console.ReadLine();
        }
    }
}
