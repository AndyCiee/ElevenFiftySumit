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

            if (_MenuDirectory.Count() == MenuDirectoryCount + 1)
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

        public MenuItem GetItemByTitle(string title)
        {
            foreach (MenuItem item in _MenuDirectory)
            {
                if (item.Title== item)
                {
                    return item;
                }
            }
        }
        
        //Update
        public void UpdateMenuItemDescription(string item, string description)
        {
            MenuItem content = GetItemByTitle(item);

            content.Description = description;
        }

        //Delete

        public bool DeleteExistingItem(MenuItem content)
        {
            return _MenuDirectory.Remove(content);
        }

        public bool DeleteItemByTItle(title)
        {
            MenuItem content = GetItemByTitle(title);

            return DeleteExistingItem(content);
        }
    }
}
