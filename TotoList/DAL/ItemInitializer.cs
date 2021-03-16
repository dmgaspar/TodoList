using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoList.Models;

namespace ToDoList.DAL
{
    public class ItemInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ItemContext>
    {
        protected override void Seed(ItemContext context)
        {
            new Item { Activity = "Go to supermarket", Date = "03/04/2021" };
            new Item { Activity = "Go to academy", Date = "03/04/2021" };
            new Item { Activity = "Pay electricity account", Date = "08/04/2021" };
            new Item { Activity = "Finish the project today course", Date = "05/04/2021" };
            new Item { Activity = "Call mom", Date = "03/04/2021" };
            context.SaveChanges();
        }

    }
}