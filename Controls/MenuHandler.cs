using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolima.Controls
{
    public class MenuHandler
    {
        public void MainMenuProcess()
        {
            int choice = 1;

            while (choice != 0)
            {
                Console.WriteLine("------ Main menu ------\n");
                Console.WriteLine("1. New game");
                Console.WriteLine("2. Load game");
                Console.WriteLine("3. Options");
                Console.WriteLine("4. About");
                Console.WriteLine("0. Exit");

                //choice = Convert.ToInt32(Console.ReadLine());

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                        case 2:
                            break;
                        case 3:
                            Console.Clear();
                            OptionsMenuProcess();
                            break;
                        case 4:
                            Console.WriteLine();
                            break;

                        case 0:
                            Console.WriteLine("Are you sure? (y/n)");
                            char exitConfirm = Console.ReadKey().KeyChar;
                            if (exitConfirm == 'y')
                                Environment.Exit(0);
                            else
                            {
                                Console.WriteLine();
                                choice = 1;
                            }
                            break;

                        default:
                            break;
                    }
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nInvalid input");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        public void OptionsMenuProcess()
        {
            int choice = 1;

            while (choice != 0)
            {
                Console.WriteLine("------ Options ------\n");
                Console.WriteLine("1. Text color");
                Console.WriteLine("0. Back");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nSelect text color:");
                            Console.WriteLine("1. Red");
                            Console.WriteLine("2. Green");
                            Console.WriteLine("3. Blue");
                            Console.WriteLine("4. Yellow");

                            Console.WriteLine("0. Back");
                            if (int.TryParse(Console.ReadLine(), out int colorChoice))
                            {
                                switch (colorChoice)
                                {
                                    case 1:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nText color changed to Red!");
                                        break;
                                    case 2:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("\nText color changed to Green!");
                                        break;
                                    case 3:
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("\nText color changed to Blue!");
                                        break;
                                    case 4:
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("\nText color changed to Blue!");
                                        break;
                                    case 0:
                                        break;
                                    default:
                                        Console.WriteLine("\nInvalid choice. Press any key to continue...");
                                        Console.ReadKey();
                                        break;
                                }
                            }
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("\nInvalid choice.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a number.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
