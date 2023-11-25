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

        public static void ConsoleClear()
        {
            Console.Clear();
            Console.Write("\f\u001bc\x1b[3J");
        }

    }
}