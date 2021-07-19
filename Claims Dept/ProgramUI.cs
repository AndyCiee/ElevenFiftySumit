using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims_Dept
{
public class ProgramUI
    {
        private bool _isRunning = true;

        private readonly ClaimRepository _repo = ClaimRepository();

        public void Start()
        {
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
            Console.WriteLine("Welcome to Komodo Claims Department: \n" +
                              "1. See all claims\n" +
                              "2. Take care of next claim\n" +
                              "3. Enter a new claim\n" +
                              "4. Exit");
            string userInput = Console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    DisplayAllClaims();
                    break;
                case "2":
                    DisplayNextClaim();
                    break;
                case "3":
                    CreateNewClaim();
                    break;
                case "4":
                    //EXIT
                    _isRunning = false;
                    return;
                default:
                    Console.WriteLine("Invalid Selection. Press any key to return to main menu.");
                    GetMenuSelection();
                    return;

            }
        }

        private void DisplayAllClaims()
        {
            List<ClaimsContent> listOfContent = _repo.GetAllClaimsContent();

            foreach(ClaimsContent content in listOfContent)
            {
                DisplayContent(content);

            }

            PressAnyKeyToReturnToMainMenu();
        }

        private void DisplayNextClaim()
        {
            Console.WriteLine("Enter Next Claim");
        }
        private void CreateNewClaim()
        {
            Console.Clear();
            Console.WriteLine("Enter a claim type:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter claim description: ");
            string description = Console.ReadLine();

            Console.WriteLine
        }
    }
}
