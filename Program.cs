using System.Collections;

namespace UlamRandomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ulamList = new List<string>();
            string[] options = { "[1] add Ulam", "[2] Remove Ulam", "[3] Display Ulam", "[4] Pick an Ulam!", "[5] Exit" };
            int optionChosen;
            char ans = 'Y';

            Console.WriteLine("Welcome to AnUlam!");
            Console.WriteLine("ULAM RANDOMIZER");
            do
            {
                foreach (string opt in options)
                    Console.WriteLine(opt);
                Console.WriteLine("\n Please enter what you would like to do:");
                optionChosen = Convert.ToInt16(Console.ReadLine());
            
                switch (optionChosen)
                {
                    case 1:
                        char addAgain = 'Y';
                        while (addAgain == 'Y')
                        {
                            Console.WriteLine("Enter the ulam to be added:");
                            string ulamAdded = Console.ReadLine();
                            ulamList.Add(ulamAdded);
                            Console.WriteLine("\n Add another one? Y/N");
                            addAgain = Console.ReadLine().ToUpper()[0];
                        }
                            Console.WriteLine("Would you like to do another operation? Y/N");
                        ans = Console.ReadLine().ToUpper()[0];
                        
                        break;

                    case 2:
                        Console.WriteLine("Enter the ulam you wish to remove:");
                        string forRemoval = Console.ReadLine();
                        if (forRemoval != null)
                        {
                        ulamList.Remove(forRemoval);
                        }
                        Console.WriteLine("Would you like to do another operation? Y/N");
                        ans = Console.ReadLine().ToUpper()[0];
                        break;

                    case 3:
                        Console.WriteLine("The list of ulam are as follows: ");
                        foreach (string ulam in ulamList)
                            Console.WriteLine(ulam);
                        Console.WriteLine("Would you like to do another operation? Y/N");
                        ans = Console.ReadLine().ToUpper()[0];
                        break;

                    case 4:
                        Random rndUlam = new Random();
                        Console.WriteLine($"The selected ulam is {ulamList[rndUlam.Next(1,ulamList.Count)]}!\n");
                        Console.WriteLine("Would you like to do another operation? Y/N");
                        ans = Console.ReadLine().ToUpper()[0];
                        break;

                    default:
                        Console.WriteLine("Thank you for using our services!");
                    break;
                }
            } while (ans == 'y' || ans == 'Y');

        }
    }
}
