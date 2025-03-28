using System.Collections;
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
        private static void AskUlamToAdd()
        {
            Console.WriteLine("Enter the ulam to be added:");
            string ulamInput = Console.ReadLine();

            if (BusinessDataLogic.AddUlam(UlamtoAdd: ulamInput))
            {
                Console.WriteLine($"Added {ulamInput} successfully.");
            }
            else
            {
                Console.WriteLine($"Error: {ulamInput} already exists.");
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
            string ulamInput = Console.ReadLine();
            if (BusinessDataLogic.RemoveUlam(ulamInput))
            {
                Console.WriteLine($"Successfully removed {ulamInput} from list.");
            }
            else
            {
                Console.WriteLine($"ERROR: {ulamInput} not in list.");
            }
                ;

        }
        private static void DisplayUlam()
        {
            Console.WriteLine("---------------------\nThe list of ulam are as follows: ");
            foreach (string ulam in BusinessDataLogic.ulamList)
                Console.WriteLine(ulam);
            Console.WriteLine("\n");
        }
        private static void DisplayRandomUlam()
        {
            int rndUlamIndex = BusinessDataLogic.RandomizeUlam(BusinessDataLogic.ulamList);
            Console.WriteLine($"The selected ulam is {BusinessDataLogic.ulamList[rndUlamIndex]}. \n");
            Thread.Sleep(2000);
        }
    }
}
