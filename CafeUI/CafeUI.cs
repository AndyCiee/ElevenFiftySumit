using FinalGoldBadgeProject;
using System;
using System.Collections.Generic;

namespace CafeUI
{
    class CafeUI
    {
        static void Main(string[] args)
        {
            CafeUI ui = new CafeUI();
            ui.Run();
        }
        private readonly MenuItemREPO _repo = new MenuItemREPO();

        public void Run()
        {
            //SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool _isRunning = true;
            while (_isRunning)
            {

                Console.Clear();
                Console.WriteLine("Welcome to Komodo Cafe \n" +
                                   "Select Menu Item:\n" +
                                   "1. Menu Item \n" +
                                   "2. Meal Options \n" +
                                   "3. Remove Exisiting Menu Item \n" +
                                   "4. Exit \n");

                string userInput = Console.ReadLine();
                Console.Clear();
                switch (userInput)
                {
                    case "1":
                        DisplayAllMenuItems();
                        break;
                    case "2":
                        CreateNewMenuItem();
                        break;
                    case "3":
                        DeleteMenuItem();
                        break;

                    default:
                        Console.WriteLine("Invalid Selection. Press any key to return to main menu.");
                        break;
                }
            }

        }





        private void DisplayAllMenuItems()
        {
            List<MenuItem> listofContent = _repo.GetAllMenuItem();

            foreach (MenuItem itemInfo in listofContent)
            {
                DisplayMeal(itemInfo);
            }

            PressAnyKeyToReturnToMainMenu();
        }


        //private void DisplayAllMealOptions()
        //{
        //    Console.Write("Enter Meal");
        //    string title = Console.ReadLine();

        //    MenuItem content = _repo.GetItemByTitle(title);

        //    if (content != null)
        //    {
        //        DisplayMeal(content);

        //        PressAnyKeyToReturnToMainMenu();
        //    }

        //    else
        //    {
        //        Console.WriteLine("Invalid Selection. Press any key to return to main menu.");
        //        GetMenuSelection();
        //    }



        private void CreateNewMenuItem()
        {
            Console.Clear();
            MenuItem menuInfo = new MenuItem();

            Console.WriteLine("Enter Meal Number: ");
            menuInfo.MealNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Meal Name");
            menuInfo.MealName = Console.ReadLine();

            Console.WriteLine("Enter a description: ");
            menuInfo.Description = Console.ReadLine();

            Console.WriteLine("Enter Ingredients:");
            menuInfo.Ingredients = Console.ReadLine();


            Console.WriteLine("Enter a Price");
            menuInfo.Price = Convert.ToDecimal(Console.ReadLine());

            _repo.AddMenuItem(menuInfo);

            PressAnyKeyToReturnToMainMenu();

        }


        //private void UpdateMenuItem()
        //{
        //    Console.WriteLine("Enter item to be edited: ");
        //    string item = Console.ReadLine();

        //    Console.WriteLine("Enter a description:");
        //    string description = Console.ReadLine();

        //    _repo.UpdateMenuItemDescription(item, description);

        //    PressAnyKeyToReturnToMainMenu();
        //}

        private void DeleteMenuItem()
        {
            Console.Clear();
            Console.WriteLine("Enter item to be deleted");
            int deleteitem = Convert.ToInt32(Console.Read());

            MenuItem singleMenuItem = _repo.GetMealNumber(deleteitem);
            PressAnyKeyToReturnToMainMenu();
        }

        private void PressAnyKeyToReturnToMainMenu()
        {
            Console.WriteLine("Press any key to return to Main Menu.");
            Console.ReadKey();
            RunMenu();
        }
        private void DisplayMeal(MenuItem meal)
        {
            Console.WriteLine($"Meal Number: {meal.MealNumber}\n" +
                $"Meal Name: {meal.MealName}\n" +
                $"Meal Description:{meal.Description}\n" +
                $"Meal Ingredients: {meal.Ingredients}\n" +
                $"Meal Price: {meal.Price}");
        }

        //private void SeedContentList()
        //{
        //    MenuItem bread = new MenuItem();


        //}
    }
}
