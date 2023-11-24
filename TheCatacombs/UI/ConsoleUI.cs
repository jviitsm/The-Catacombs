using TheCatacombs.Services;

namespace TheCatacombs.UI
{
    public class ConsoleUI
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetUserInput()
        {
            return Console.ReadLine();
        }

    }
}