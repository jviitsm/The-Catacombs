using TheCatacombs.Services;
using TheCatacombs.UI;

namespace TheCatacombs
{
    class Program
    {
        static void Main()
        {
            GameManager gameManager = GameManager.Instance; // Use a instância única

            gameManager.StartGame();

            // Loop principal do jogo
            while (true)
            {
                // Adicione lógica adicional do jogo, como processamento de comandos do jogador, eventos, etc.
                // Por exemplo, você pode ter métodos como game.ProcessPlayerInput(consoleUI, consoleUI.GetUserInput()).

                // Aqui, pausamos o loop principal apenas para fins de exemplo.
                Console.ReadLine();
            }
        }
    }
}
