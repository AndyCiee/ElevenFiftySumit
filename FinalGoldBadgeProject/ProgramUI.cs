using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalGoldBadgeProject
{
    public class ProgramUI
    {
        

        private bool _isRunning = true;

        private readonly MenuItemREPO _repo = new MenuItemREPO();

        public void Start()
        {
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            while (_isRunning)
            {
                string userInput = GetMenuSelection();
                OpenMenuItem(userInput);
            }
        }

        private string GetMenuSelection()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Komodo Cafe \n" +
                               "Select Menu Item:\n" +
                               "1. Menu Item \n" +
                               "2. Meal Options \n" +
                               "3. Description of all Menu Items \n" +
                               "4. Add New Menu Items \n" +
                               "5. Update Exisiting Menu Item \n" +
                               "6. Remove Exisiting Menu Item \n" +
                               "7. Exit \n");

            string userInput = Console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    DisplayAllMenuItems();
                    break;
                case "2":
                    DisplayAllMealOptions();
                    break;
                case "3":
                    DisplayAllDescriptions();
                    break;
                case "4":
                    CreateNewMenuItem();
                    break;
                case "5":
                    UpdateMenuItem();
                    break;
                case "6":
                    DeleteMenuItem();
                    break;
                case "7":

                    _isRunning = false;
                    return;
                default:
                    Console.WriteLine("Invalid Selection. Press any key to return to main menu.");
                    GetMenuSelection();
                    return;               
            }
        }

        private void DisplayAllMenuItems()
        {
            List<MenuItem> listofContent = _repo.GetAllMenuItem();

            foreach (MenuItem content in listofContent)
            {
                DisplayMeunItems(content);
            }

            PressAnyKeyToReturnToMainMenu();
        }

        private void DisplayAllMealOptions()
        {
            Console.Write("Enter Meal");
            string title = Console.ReadLine();

            MenuItem content = _repo.GetItemByTitle(title);

            if (content != null)
            {
                DisplayMeal(content);

                PressAnyKeyToReturnToMainMenu();
            }

            else
            {
                Console.WriteLine("Invalid Selectiom. Press any key to return to main menu.");
                GetMenuSelection();
            }

            void DisplayAllDescriptions(MenuItem content)
            {
                Console.WriteLine($"Item: {content.Item}\n" +
                                  $"Description: {content.Description}\n" +
                                  $"Price: {content.Price}\n");
                                   
            }

             void CreateNewMenuItem()
            {
                Console.Clear();
                Console.WriteLine("Enter Menu Item: ");
                string item = Console.ReadLine();

                Console.WriteLine("Enter a description: ");
                string description = Console.ReadLine();

                Console.WriteLine("Enter a Price");
                decimal price = decimal.Parse(Console.ReadLine());

                MenuItem content = new MenuItem(item, description, price);

                _repo.AddMenuItem(content);

                PressAnyKeyToReturnToMainMenu();

            }

            void UpdateMenuItem()
            {
                Console.WriteLine("Enter item to be edited: ");
                string item = Console.ReadLine();

                Console.WriteLine("Enter a description:");
                string description = Console.ReadLine();

                _repo.UpdateMenuItemDescription(item, description);

                PressAnyKeyToReturnToMainMenu();
            }

            void DeleteMenuItem()
            {
                Console.WriteLine("Enter item to be deleted");

                _repo.DeleteMenuItem(Console.ReadLine());

                PressAnyKeyToReturnToMainMenu();
            }

            void PressAnyKeyToReturnToMainMenu()
            {
                Console.WriteLine("Press any key to return to Main Menu.");
                Console.ReadKey();
                RunMenu();
            }

            void SeedContentList()
            {
                MenuItem bread = new MenuItem();


            }
        }
    }
}
