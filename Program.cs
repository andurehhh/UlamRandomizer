using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using UlamRandomizerBusinessLogic;

namespace UlamRandomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int optionChosen;
            Console.WriteLine("Welcome to AnUlam!");

            do
            {
                DisplayActions();
                optionChosen = GetUserInput();

                switch (optionChosen)
                {
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
            Console.WriteLine("\n Please enter what you would like to do:");
            int optionChosen = Convert.ToInt16(Console.ReadLine());
            return optionChosen;
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
            string[] options = { "[<-] Reject", "[->] Choose", "[V] Skip", "[^] Back to menu" };

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

            Ulam NewUlam = BusinessDataLogic.CreateUlamObj(UlamName, MainIngredient);

            if (BusinessDataLogic.AddUlam(NewUlam))
            {
                Console.WriteLine($"Added {NewUlam.UlamName} successfully.");//can i return the string of the ulam?
            }
            else
            {
                Console.WriteLine($"Error: {NewUlam.UlamName} already exists.");
            }
                ;
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

            if (BusinessDataLogic.RemoveUlam(BusinessDataLogic.SearchUlamList(UlamName)))
            {
                Console.WriteLine($"Successfully removed {UlamName} from list.");
            }
            else
            {
                Console.WriteLine($"ERROR: {UlamName} not in list.");
            }


        }
        private static void DisplayUlam()
        {
            Console.WriteLine("---------------------\nThe list of ulam are as follows: ");
            foreach (Ulam ulam in BusinessDataLogic.ulamList)
            {
                Console.WriteLine(ulam.UlamName);
                Console.WriteLine($"Main Ingredient: {ulam.MainIngredient}");
            }
            //Console.WriteLine("\n");
        }
        private static void DisplayRandomUlam()
        {
            if (BusinessDataLogic.ulamList.Count > 0)
            {
                int rndUlamIndex = BusinessDataLogic.RandomizeUlam();
                string ulamRandomized = BusinessDataLogic.ulamList[rndUlamIndex].UlamName;
                Console.WriteLine($"The selected ulam is {ulamRandomized}. \n");
                //Thread.Sleep(2000);
                ConfirmRandomUlam(rndUlamIndex);
            }
            else
            {
                Console.WriteLine("ERROR: No item in the list.");
            }

        }

        private static void ConfirmRandomUlam(int RandomUlamIndex)
        {
            Ulam SelectedRandomUlam = BusinessDataLogic.ulamList[RandomUlamIndex];

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
            Console.WriteLine($"Ulam Chosen: {BusinessDataLogic.GetUlamName(SelectedRandomUlam)} \n" +
                $"Main Ingredient: {BusinessDataLogic.GetUlamMainIng(SelectedRandomUlam)}");

        }

        public static void RemoveFromRandom(Ulam SelectedRandomUlam)
        {
            BusinessDataLogic.RemoveUlam(SelectedRandomUlam);
            Console.WriteLine($"Removed {BusinessDataLogic.GetUlamName(SelectedRandomUlam)}");

        }


    }
}
