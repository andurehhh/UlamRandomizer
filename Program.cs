using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using UlamRandomizerBusinessLogic;
using UlamCommon;
using System.Diagnostics.Metrics;

namespace UlamRandomizer
{
    internal class Program
    {
        static AccountBusinessLogic ABL = new AccountBusinessLogic();

        static void Main(string[] args)
        {
            if (LoginMessage())
            {

                BusinessLogic BL = new BusinessLogic();
                int optionChosen;
                Console.WriteLine($"Welcome to AnUlam {ABL.IdentifyAccountUser().FirstName}!");
                do
                {
                    DisplayActions();
                    optionChosen = GetUserInput();

                    switch (optionChosen)
                    {
                        case 0:
                            break;
                        case 1:
                            AddAnotherUlam();
                            break;

                        case 2:
                            AskUlamToRemove();
                            break;

                        case 3:
                            DisplayUlam();
                            break;

                        case 4:

                            DisplayEditUlam();

                            break;

                        case 5:

                            DisplayRandomUlam();

                            break;

                        case 6:
                            DisplayWholeList();
                            break;

                        default:
                            Console.WriteLine("Thank you for using our services!");
                            break;
                    }
                } while (optionChosen != 7);

            }
        }

        private static int GetUserInput()
        {
            try
            {
                Console.WriteLine("\nPlease enter what you would like to do:");
                int optionChosen = Convert.ToInt16(Console.ReadLine());
                return optionChosen;
            }
            catch
            {
                Console.WriteLine("ERROR: Invalid input.");
                return 0;
            }
        }
        private static void DisplayActions()
        {
            string[] options = { "[1] add Ulam", "[2] Remove Ulam", "[3] Display Ulam", "[4] Search an Ulam", "[5] Pick an Ulam!", "[6] see whole list, [7] Exit" };

            Console.WriteLine("---------------------");
            foreach (string opt in options)
            {
                Console.WriteLine(opt);
            }
        }
        private static void DisplayArrowActions()
        {
            string[] options = { "[<-] Reject", "[->] Choose", "[v] Skip", "[^] Back to menu" };

            Console.WriteLine("---------------------");
            foreach (string opt in options)
            {
                Console.WriteLine(opt);
            }
            Console.WriteLine("---------------------\n");
        }
        private static void AskUlamToAdd()
        {
            Console.WriteLine("Enter the ulam to be added:");
            string UlamName = Console.ReadLine();
            Console.WriteLine("Enter the ulam's Main Ingredient:");
            string MainIngredient1 = Console.ReadLine();
            Console.WriteLine("Enter the ulam's 2nd Main Ingredient:");
            string MainIngredient2 = Console.ReadLine();
            Console.WriteLine("Enter a short Description:");
            string Description = Console.ReadLine();

            if (UlamName == "" || MainIngredient1 == "")
            {
                Console.WriteLine("ERROR: Incomplete Input.");
            }
            else
            {
                Ulam NewUlam = BusinessLogic.CreateUlamObj(UlamName, MainIngredient1, MainIngredient2,Description);

                if (!BusinessLogic.IsInList(NewUlam))
                {
                    Console.WriteLine($"Added {NewUlam.UlamName} successfully.");
                }
                else
                {
                    Console.WriteLine($"ERROR: {NewUlam.UlamName} already exists.");
                }
            }
        }
        private static void AddAnotherUlam()
        {
            char ulamAnother;
            do
            {
                AskUlamToAdd();
                Console.WriteLine("\nAdd another one? Y/N");
                ulamAnother = (char)Console.ReadLine()[0];
            }
            while (ulamAnother.Equals('Y') || ulamAnother.Equals('y'));
        }
        private static void AskUlamToRemove()
        {

            Console.WriteLine("Enter the ulam you wish to remove:");
            string UlamName = Console.ReadLine();

            Ulam ulamToDelete = BusinessLogic.SearchUlamList(UlamName);
            if (UlamName == "")
            {
                Console.WriteLine("ERROR: Missing Ulam Input");
            }
            else
            {
                if (BusinessLogic.IsInList(ulamToDelete))
                {

                    BusinessLogic.RemoveUlam(ulamToDelete);
                    Console.WriteLine($"Successfully removed {UlamName} from list.");
                }
                else
                {
                    Console.WriteLine($"ERROR: {UlamName} not in list.");
                }
            }

        }
        private static void DisplayUlam()
        {
            Console.WriteLine("---------------------\nThe list of ulam are as follows: ");
            foreach (Ulam ulam in BusinessLogic.GetUlams())
            {
                Console.WriteLine(ulam.UlamName);
                Console.WriteLine($"Main Ingredient 1: {ulam.MainIngredient1}");
                Console.WriteLine($"Main Ingredient 2: {ulam.MainIngredient2}");
                Console.WriteLine($"Description: {ulam.ulamDescription}\n");
            }

        }

        private static void DisplayRandomUlam()
        {

            //remove, choose or skip
            ConsoleKey kc;
            do
            {
                int RandomUlamIndex = BusinessLogic.RandomizeUlam();

                string ulamRandomized = BusinessLogic.GetUlams()[RandomUlamIndex].UlamName;
                Console.WriteLine($"The selected ulam is {ulamRandomized}. \n");
                Ulam SelectedRandomUlam = BusinessLogic.GetUlams()[RandomUlamIndex];

                DisplayArrowActions();
                kc = Console.ReadKey(true).Key;
                switch (kc)
                {
                    case ConsoleKey.LeftArrow: //Reject
                        if (BusinessLogic.GetUlams().Count > 1)
                        {
                            RemoveFromRandom(SelectedRandomUlam);
                        }
                        else
                        {
                            Console.WriteLine("ERROR: This is the last ulam.");
                        }
                        break;

                    case ConsoleKey.RightArrow: //Accept
                        ChosenFromRandom(SelectedRandomUlam);
                        Console.ReadKey(true);
                        kc = ConsoleKey.UpArrow;
                        break;

                    case ConsoleKey.DownArrow: //Skip
                        //DisplayRandomUlam();
                        break;

                    case ConsoleKey.UpArrow: //Back
                        break;

                    default:
                        Console.WriteLine("Invalid button, try again.");
                        break;
                }

            }
            while (kc != ConsoleKey.UpArrow);

        }

        public static void ChosenFromRandom(Ulam SelectedRandomUlam)
        {
            Console.WriteLine($"Ulam: {SelectedRandomUlam.UlamName} \n" +
                $"Main Ingredient1: {SelectedRandomUlam.MainIngredient1}"+
                $"Main Ingredient1: {SelectedRandomUlam.MainIngredient1}");

        }

        public static void RemoveFromRandom(Ulam SelectedRandomUlam)
        {
            BusinessLogic.RemoveUlam(SelectedRandomUlam);
            Console.WriteLine($"--Removed {SelectedRandomUlam.UlamName}-- \n");

        }
        public static void DisplayEditUlam()
        {
            Console.WriteLine("Please enter the ulam to edit: ");
            string ulamToFind = Console.ReadLine();
            if (ulamToFind == "")
            {
                Console.WriteLine("ERROR: please enter an ulam.");
            }
            Ulam ulamFound = BusinessLogic.SearchUlamList(ulamToFind);

            if (ulamFound != null)
            {
                Console.WriteLine();
                ChosenFromRandom(ulamFound);
                EditUlam(ulamFound);

            }
            else
            {
                Console.WriteLine("Ulam is not included in the list.");
            }
        }

        private static void EditUlam(Ulam ulamToEdit)
        {

            Ulam newUlam = ulamToEdit;
            Console.WriteLine("Please enter new Main Ingredient:");

            newUlam.MainIngredient1 = Console.ReadLine();

            Console.WriteLine("Enter the second Main Ingredient (leave blank if none.):");
            newUlam.MainIngredient2 = Console.ReadLine();

            Console.WriteLine("Please enter new Description: (Do not Enter for new Line)");
            
            newUlam.ulamDescription = Console.ReadLine();


            BusinessLogic.EditUlam(newUlam);
            Console.WriteLine("Ulam Successfully edited!");
        }
        private static bool LoginMessage()
        {
            bool retry = true;
            do
            {
                Console.WriteLine("Please Enter your Username: ");
                string user = Console.ReadLine();
                Console.WriteLine("Password: ");
                string pass = Console.ReadLine();
                bool login = ABL.ConfirmLogin(user, pass);

                if (login)
                {
                    Console.WriteLine("Login Successful!");
                    return true;

                }
                else
                {
                    retry = false;
                    Console.WriteLine("ERROR: Wrong username or Password");
                }
            } 
            while (retry == false);
            return false;
        }

        private static void DisplayWholeList()
        {
            Console.WriteLine("Here is the list of all available ulam.");
            var ulamList = BusinessLogic.GetUlams();

            Console.WriteLine("Here are the list of all ulam.");
            int index = 1;
            foreach (Ulam current in ulamList){
                Console.WriteLine($"{index}. ");
                Console.WriteLine($"Ulam Name: {current.UlamName}");
                Console.WriteLine($"Main Ingredient 1: {current.MainIngredient1}");
                Console.WriteLine($"Main Ingredient 2: {current.MainIngredient2}");
                Console.WriteLine($"Ulam Description: {current.ulamDescription}");
                index++;
                Console.WriteLine(" ");
            }
        } 
    }
}
