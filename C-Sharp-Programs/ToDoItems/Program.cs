using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoItems
{
    class ToDoItem
    {
        public ToDoItem (string des, string due, string pri)
        {
            Description = des;
            DueDate = due;
            Priority = pri;
        }

        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }
        public string Layout()
        {
            return Description + "|" + DueDate + "|" + Priority;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ToDoItem> toDos = new List<ToDoItem>();
            while(true)
            {
              
            Console.WriteLine("Do you want to add an item, or are you done with the list?");
            string Choice = Console.ReadLine();
                if (Choice == "Done")
                {
                    foreach(ToDoItem item in toDos)
                    {
                        Console.WriteLine(item.Layout());
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("What do you want to add?");
                    string description = Console.ReadLine();
                    Console.WriteLine("When is it due?");
                    string doDate = Console.ReadLine();
                    Console.WriteLine("What is the priority?");
                    string pri = Console.ReadLine();
                    ToDoItem Item = new ToDoItem(description, doDate, pri);
                    toDos.Add(Item);
                }
            }
            Console.ReadLine();
        }
    }
}
