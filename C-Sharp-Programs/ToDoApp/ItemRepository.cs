using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class ItemRepository
    {
        private ItemContext db;
        public ItemRepository()
        {
            db = new ItemContext();
            db.Database.EnsureCreated();

        }
         public void Create(ToDoItem item)
        {
            db.Items.Add(item);
            db.SaveChanges();

        }
        public List<ToDoItem> GetAll()
        {
            return db.Items.ToList();
        }
        public List<ToDoItem> GetDoneItems()
        {
            return db.Items.Where(Item => Item.IsDone).ToList()
        }
        public List<ToDoItem> GetPendingItems()
        {
            return db.Items.Where(Item => Item.IsPending).ToList()
        }
        public void Delete(int Id)
        {
            ToDoItem item = db.Items.Find(Id);
            db.Items.Remove(item);
            db.SaveChanges();
          
        }
        public void Update(ToDoItem Item)
        {
            ToDoItem Existing = db.Items.Find(Item.Id);
            db.Entry(Existing).CurrentValues.SetValues(Item);
            db.Update(Existing);
            db.SaveChanges();
        }
    }
}
