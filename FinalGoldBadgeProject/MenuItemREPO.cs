using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGoldBadgeProject
{
    public class MenuItemREPO : MenuItem

    {
        private readonly List<MenuItem> _MenuDirectory = new List<MenuItem>();

        //Build out our CRUD Method

        //Create
        public bool AddMenuItem(MenuItem content)
        {
            int MenuDirectoryCount = _MenuDirectory.Count();

            _MenuDirectory.Add(content);

            if (_MenuDirectory.Count() == MenuDirectoryCount ++ )
            {
                return true;
            }

            return false;
        }

        //Read

        public List<MenuItem> GetAllMenuItem()
        {
            return _MenuDirectory;
        }

   

        //Delete

        public bool DeleteExistingItem(MenuItem content)
        {
            bool deleteItem = _MenuDirectory.Remove(content);
            return deleteItem;
        }

        //Just A Little Help
        public MenuItem GetMealNumber(int mealNum)
        {
            //this is a loop to search through all items inthe  menu
            //to find one that has a meal number property that matches the 
            //mealNum variable that the user gives
            foreach (MenuItem item in _MenuDirectory)
            {
                if (item.MealNumber == mealNum)
                {
                    return item;
                }
            }
        return null;
        }

    }
}
