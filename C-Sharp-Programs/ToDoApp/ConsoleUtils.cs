using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class ConsoleUtils
    {
       public static string GetUserChoice()
        {
            Console.Clear();
            Console.WriteLine("Avalible Functions:");
            Console.WriteLine("add: to add an item");
            Console.WriteLine("delete: to delete an item");
            Console.WriteLine("mark done: an item to mark as done");
            Console.WriteLine("list pinding: to list the pending items");
            Console.WriteLine("list done: to list the done item");
            Console.WriteLine("list all: to list all items");
            Console.WriteLine("quit: to exit");
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            return Console.ReadLine();
        }
        public static string GetDescription()
        {
            Console.Clear();
            Console.WriteLine("Please enter a description:");
            return Console.ReadLine();
        }
        public static int GetIdToDelete()
        {
            Console.Clear();
            Console.WriteLine("Please enter a the ID of the item to delete:");
            string StringId = Console.ReadLine();
            int ID = int.Parse(StringId);
            return ID;
        }
        public static int GetIdToMarkAsDone()
        {
            Console.Clear();
            Console.WriteLine("Please enter a the ID of the item to mark as done:");
            string StringId = Console.ReadLine();
            int ID = int.Parse(StringId);
            return ID;
        }
        public static void PrintTable(List<ToDoItem> items)
        {
            var maxIdLength = 6;
            var maxDescLength = Math.Max(items.Max(x => x.Description.Length), 8) + 2;
            var maxStatusLength = 10;
            var header = $" id    | {_padEnd("item", maxDescLength)}| status  ";
            Console.WriteLine(header);
            Console.WriteLine($"{_padEnd(string.Empty, maxIdLength + 1, "-")}+{_padEnd(string.Empty, maxDescLength + 1, "-")}+{_padEnd(string.Empty, maxStatusLength + 1, "-")}");
            foreach (var item in items)
            {
                var status = item.IsPending ? "pending" : (item.IsDone ? "done" : "new");
                Console.WriteLine($" {_padEnd(item.Id.ToString(), maxIdLength)}| {_padEnd(item.Description, maxDescLength)}| {_padEnd(status, maxStatusLength)}");
            }
            Console.WriteLine("Press enter to do something else");
            Console.ReadLine();
        }

        private static string _padEnd(string str, int length, string with = " ")
        {
            if (str.Length == length) return str;
            while (str.Length < length) str += with;
            return str;
        }
    }
}
