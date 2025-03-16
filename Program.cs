using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace UlamRandomizer
{
    internal class Program
    {
        static List<string> ulamList = new List<string>();
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
                        RemoveUlam();
                        break;

                    case 3:
                        DisplayUlam();
                        break;

                    case 4:
                        RandomizeUlam();
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
        private static void AddUlam()
        {
            Console.WriteLine("Enter the ulam to be added:");
            string ulamAdded = Console.ReadLine();
            if (!ulamList.Contains(ulamAdded))
            {
                ulamList.Add(ulamAdded);
            }
            else
            {
                Console.WriteLine("Ulam already added.");
            }
        }
        private static void AddAnotherUlam()
        {
            char ulamAnother;
            do
            {
                AddUlam();
                Console.WriteLine("\nAdd another one? Y/N");
                ulamAnother = (char)Console.ReadLine()[0];
            }
            while (ulamAnother.Equals('Y') || ulamAnother.Equals('y'));
        }
        private static void RemoveUlam()
        {
            Console.WriteLine("Enter the ulam you wish to remove:");
            string forRemoval = Console.ReadLine();
            if (forRemoval != null)
            {
                if (ulamList.Contains(forRemoval))
                {
                    ulamList.Remove(forRemoval);
                    Console.WriteLine($"Removed {forRemoval} from the list.");
                }
                else
                {
                    Console.WriteLine($"{forRemoval} does not exist in the list.");
                }
            }
        }
        private static void DisplayUlam()
        {
            Console.WriteLine("---------------------\nThe list of ulam are as follows: ");
            foreach (string ulam in ulamList)
                Console.WriteLine(ulam);
            Console.WriteLine("\n");
        }
        private static void RandomizeUlam()
        {
            Random rndUlam = new Random();
            Console.WriteLine($"The selected ulam is {ulamList[rndUlam.Next(ulamList.Count)]}!\n");
        }
    }
}
