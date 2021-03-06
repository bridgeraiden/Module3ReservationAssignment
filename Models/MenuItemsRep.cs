using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module3ReservationAssignment.Models
{
    public class MenuItemsRep : MenuItemsIRep
    {
        private Dictionary<int, MenuItems> items;

        public MenuItemsRep()
        {
            items = new Dictionary<int, MenuItems>();
            new List<MenuItems> {
                new MenuItems {Id=1, Name = "Spaghetti", Price = 19.99}
               
                }.ForEach(r => AddMenuItems(r));
        }

        public MenuItems this[int id] => items.ContainsKey(id) ? items[id] : null;

        public IEnumerable<MenuItems> MenuItems => items.Values;

        public MenuItems AddMenuItems(MenuItems Menuitems)
        {
            if (MenuItems.Id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                MenuItems.Id = key;
            }
            items[MenuItems.Id] = MenuItems;
            return (MenuItems)MenuItems;
        }

        public void DeleteReservation(int id) => items.Remove(id);

        public MenuItems UpdateMenuItems(MenuItems MenuItems) => AddMenuItems(MenuItems);
    }
}

    }
}
