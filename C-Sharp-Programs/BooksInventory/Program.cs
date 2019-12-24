using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksInventory
{
    public class BI
    {
        public BI(string author, string title)
        {
            Author = author;
            Title = title;
        }
        public string Author { get; set; }
        public string Title { get; set; }
        public string GetInfo()
        {
            
            return Author + " " + Title;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<BI> listBook = new List<BI>();
           // BI book = new BI("J.K. Rowling" , "Harry Potter and the Philosopher's Stone");
           // string Info = book.GetInfo();
           // Console.WriteLine(Info);
          //  Console.ReadLine();
            while (true)
            {

                Console.WriteLine("Do you want to add an item, or are you Done with the list?");
                string Choice = Console.ReadLine();
                if (Choice == "Done")
                {
                    foreach (BI item in listBook)
                    {
                        Console.WriteLine(item.GetInfo());
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("What's the Authors name?");
                    string Name = Console.ReadLine();
                    Console.WriteLine("What's the Title of the book?");
                    string bookName = Console.ReadLine();
                    BI Item = new BI(Name, bookName);
                    listBook.Add(Item);
                }
            }
            Console.ReadLine();

        }
    }
}
