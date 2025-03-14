using Consolima.Controls;

namespace Consolima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    MenuHandler menuHandler = new MenuHandler();
                    menuHandler.MainMenuProcess();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
