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
    class Book
    {
        public Book(string title, string authors, int pages, int sku, string publisher, string price)
        {
            Title = title;
            Authors = authors;
            Pages = pages;
            SKU = sku;
            Publisher = publisher;
            Price = price;

        }
        public string Title { get; set; }
        public string Authors { get; set; }
        public int Pages { get; set; }
        public int SKU { get; set; }
        public string Publisher { get; set; }
        public string Price { get; set; }

    }
    class Airplane
    {
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string Variant { get; set; }

        public int Capacity { get; set; }
        public int Engines { get; set; }
    }
}
