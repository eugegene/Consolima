using Consolima.Res.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolima.Controls
{
    public class MenuHandler
    {
        // MAIN MENU
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

        // PICK CHARACTER MENU
        public void PickCharacterMenuProcess()
        {
            int choice = 1;
            while (choice != 0)
            {
                Console.WriteLine("------ Pick verse ------\n");
                Console.WriteLine("1. Warrior");
                Console.WriteLine("2. Mage");
                Console.WriteLine("3. Archer");
                Console.WriteLine("0. Back");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 0:
                            return;
                        default:
                            InvalidOutput();
                            break;
                    }
                }
                else
                {
                    InvalidOutput();
                }
            }
        }

        // GAME MENU
        public void GameMenuProcess()
        {
            int choice = 1;

            while (choice != 0)
            {

            }
        }



        // OPTIONS MENUs
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
                            ConsoleTextColorMenuProcess();
                            break;
                        case 0:
                            return;
                        default:
                            InvalidOutput();
                            break;
                    }
                }
                else
                {
                    InvalidOutput();
                }
            }
        }

        public void ConsoleTextColorMenuProcess()
        {
            Console.WriteLine("\nSelect text color:");
            var colors = Enum.GetValues(typeof(TextColor));
            foreach (TextColor color in colors)
            {
                Console.WriteLine($"{(int)color}. {color}");
            }

            if (int.TryParse(Console.ReadLine(), out int choice) && 
            Enum.IsDefined(typeof(TextColor), choice))
            {
                var colorMap = new Dictionary<TextColor, ConsoleColor>
                {
                    { TextColor.White, ConsoleColor.White },
                    { TextColor.Red, ConsoleColor.Red },
                    { TextColor.Green, ConsoleColor.Green },
                    { TextColor.Blue, ConsoleColor.Blue },
                    { TextColor.Cyan, ConsoleColor.Cyan },
                    { TextColor.Magenta, ConsoleColor.Magenta },
                    { TextColor.Yellow, ConsoleColor.Yellow },
                    { TextColor.Gray, ConsoleColor.Gray },
                    { TextColor.DarkRed, ConsoleColor.DarkRed },
                    { TextColor.DarkGreen, ConsoleColor.DarkGreen },
                    { TextColor.DarkBlue, ConsoleColor.DarkBlue },
                    { TextColor.DarkCyan, ConsoleColor.DarkCyan },
                    { TextColor.DarkMagenta, ConsoleColor.DarkMagenta },
                    { TextColor.DarkYellow, ConsoleColor.DarkYellow },
                    { TextColor.DarkGray, ConsoleColor.DarkGray }
                };

                Console.ForegroundColor = colorMap[(TextColor)choice];
                Console.WriteLine($"\nText color changed to {((TextColor)choice)}!");
            }
            else
            {
                Console.WriteLine("\nInvalid choice!");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public void InvalidOutput()
        {
            Console.WriteLine("\nInvalid input.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}