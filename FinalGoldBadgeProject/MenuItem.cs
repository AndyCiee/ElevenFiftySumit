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

        public MenuItem(int mealNumber, string mealName,string description, string ingredients, decimal price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price;

        }  
        
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal Price { get; set;  }
        
        
    }
}
