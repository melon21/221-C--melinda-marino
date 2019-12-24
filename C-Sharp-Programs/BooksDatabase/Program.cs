using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksDatabase
{ public class BD
    {
        public BD(string author, string title)
        {
            Title = title;
            Author = author;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string GetInfo()
        { 
            return Title + " " + "by" + " " + Author;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BD book1 = new BD("The Hobbit", "Tolkien");
            BD book2 = new BD("Cat In The Hat", "Dr.Seuss");
            BD book3 = new BD("Tom Sawyer", "Mark Twain");
            string Info1 = book1.GetInfo();
            Console.WriteLine(Info1);
            string Info2 = book2.GetInfo();
            Console.WriteLine(Info2);
            string Info3 = book1.GetInfo();
            Console.WriteLine(Info3);
            Console.ReadLine();
        }
    }
}
