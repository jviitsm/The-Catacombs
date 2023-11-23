using TheCatacombs.Services;
using TheCatacombs.UI;

namespace TheCatacombs
{
    class Program
    {

        static void Main()
        {
            Game game = new Game();

            game.Start();

            // Adicione um loop principal aqui para manter o jogo em execução
            while (true)
            {
                // Aqui você pode adicionar lógica adicional do jogo, como processamento de comandos do jogador, eventos, etc.
                // Por exemplo, você pode ter métodos como game.ProcessPlayerInput(consoleUI, consoleUI.GetUserInput()).

                // Por enquanto, pausamos o loop principal apenas para fins de exemplo.
                Console.ReadLine();
            }
        }
    }
}