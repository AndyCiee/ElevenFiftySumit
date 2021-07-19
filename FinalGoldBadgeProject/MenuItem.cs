using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGoldBadgeProject
{
    //POCO
    public class MenuItem
    {

        public MenuItem() { }

        public MenuItem(Item item)
        {
            Item = item;
        }

        public MenuItem(Item item, string description)
        {
            Item = item;
            Description = description;
           
        }
        public Item Item { get; set; }
        public string Description { get; set; }
        public decimal Price
        {
            get{
            switch (Item)
                {
                    case (Item)1: return 10.50m;
                    case (Item)2: return 8.75m;
                    case (Item)3: return 9.00m;
                    case (Item)4: return 5.50m;
                    case (Item)5: return 3.25m;
                    case (Item)6: return 1.50m;
                }

                return 0;
            }
        }
    }
    public enum Item
    {
        Bread = 1,
        Cake,
        Donuts,
        Pasteries,
        Muffins,
        Coffee
    }
   
    }
}
