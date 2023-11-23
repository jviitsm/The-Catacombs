using TheCatacombs.Services;

namespace TheCatacombs.UI
{
    public class ConsoleUI
    {
        private Game game;

        public ConsoleUI(Game game)
        {
            this.game = game;
        }

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