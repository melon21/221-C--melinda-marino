using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class ToDoItem
    {
        public int Id { get; private set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public bool IsPending { get; set; }
       
    }
}
