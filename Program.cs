using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using UlamRandomizerBusinessLogic;
using UlamCommon;

namespace UlamRandomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int optionChosen;
            Console.WriteLine("Welcome to AnUlam!");
            BusinessLogic.CreateDummyUlam();
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

                        DisplayRandomUlam();

                        break;

                    default:
                        Console.WriteLine("Thank you for using our services!");
                        break;
                }
            } while (optionChosen != 5);

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
            string[] options = { "[1] add Ulam", "[2] Remove Ulam", "[3] Display Ulam", "[4] Pick an Ulam!", "[5] Exit" };

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
            string MainIngredient = Console.ReadLine();

            if (UlamName == "" || MainIngredient == "")
            {
                Console.WriteLine("ERROR: Incomplete Input.");
            }
            else
            {
                Ulam NewUlam = BusinessLogic.CreateUlamObj(UlamName, MainIngredient);

                if (BusinessLogic.AddUlam(NewUlam))
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
            //string ulamInput = Console.ReadLine();
            string UlamName = Console.ReadLine();
            if (UlamName == "")
            {
                Console.WriteLine("ERROR: Missing Ulam Input");
            }
            else
            {
                if (BusinessLogic.RemoveUlam(BusinessLogic.SearchUlamList(UlamName)))
                {
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
            foreach (Ulam ulam in BusinessLogic.GetUlamList())
            {
                Console.WriteLine(ulam.UlamName);
                Console.WriteLine($"Main Ingredient: {ulam.MainIngredient}");
                Console.WriteLine("\n");
            }

        }
        private static void DisplayRandomUlam()
        {
            if (BusinessLogic.GetUlamList().Count > 0)
            {
                int rndUlamIndex = BusinessLogic.RandomizeUlam();
                string ulamRandomized = BusinessLogic.GetUlamList()[rndUlamIndex].UlamName;
                Console.WriteLine($"The selected ulam is {ulamRandomized}. \n");
                ConfirmRandomUlam(rndUlamIndex);
            }
            else
            {
                Console.WriteLine("ERROR: No item in the list.");
            }

        }

        private static void ConfirmRandomUlam(int RandomUlamIndex)
        {
            Ulam SelectedRandomUlam = BusinessLogic.GetUlamList()[RandomUlamIndex];

            //remove, choose or skip
            DisplayArrowActions();
            var kc = Console.ReadKey(true).Key;
            switch (kc)
            {
                case ConsoleKey.LeftArrow: //Reject
                    RemoveFromRandom(SelectedRandomUlam);
                    break;

                case ConsoleKey.RightArrow: //Accept
                    ChosenFromRandom(SelectedRandomUlam);
                    Console.ReadKey(true);
                    break;

                case ConsoleKey.UpArrow: //Back
                    break;

                case ConsoleKey.DownArrow: //Skip
                    DisplayRandomUlam();
                    break;

                default:
                    Console.WriteLine("Invalid button, try again.");
                    ConfirmRandomUlam(RandomUlamIndex);
                    break;
            }

        }

        public static void ChosenFromRandom(Ulam SelectedRandomUlam)
        {
            Console.WriteLine($"Ulam Chosen: {BusinessLogic.GetUlamName(SelectedRandomUlam)} \n" +
                $"Main Ingredient: {BusinessLogic.GetUlamMainIng(SelectedRandomUlam)}");

        }

        public static void RemoveFromRandom(Ulam SelectedRandomUlam)
        {
            BusinessLogic.RemoveUlam(SelectedRandomUlam);
            Console.WriteLine($"--Removed {BusinessLogic.GetUlamName(SelectedRandomUlam)}-- \n");
            DisplayRandomUlam();
            if (BusinessLogic.GetUlamList().Count > 0)
            {
                ConfirmRandomUlam(BusinessLogic.RandomizeUlam());
            }

        }


    }
}
