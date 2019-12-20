using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class app
    {
       public  static void Run()
        {
            ItemRepository Items = new ItemRepository();
            string Choice;
            
            while (true)
            {
                Choice = ConsoleUtils.GetUserChoice();

                switch (Choice)
                {
                    case "add":
                        string description = ConsoleUtils.GetDescription();
                        ToDoItem Item = new ToDoItem()
                        {
                            Description = description,
                            IsDone = false,
                            IsPending = false
                        };
                        Items.Create(Item);
                        break;
                    case "delete":
                        int ID = ConsoleUtils.GetIdToDelete();
                        Items.Delete(ID);
                        break;
                    case "mark done":
                        int DoneId = ConsoleUtils.GetIdToMarkAsDone();
                        Items.MarkAsDone(DoneId);
                        break;
                    case "list pending":
                        var pending = Items.GetPendingItems();
                        ConsoleUtils.PrintTable(pending);
                        break;
                    case "list done":
                        var done = Items.GetDoneItems();
                        ConsoleUtils.PrintTable(done);
                        break;
                    case "list all":
                        var all = Items.GetAll();
                        ConsoleUtils.PrintTable(all);
                        break;
                    case "quit":
                        return;
                     

                }
            }
        }
    }
}
