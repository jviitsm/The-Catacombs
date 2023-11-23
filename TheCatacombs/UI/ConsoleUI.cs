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

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string GetUserInput()
        {
            return Console.ReadLine();
        }

    }
}