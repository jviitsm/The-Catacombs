using TheCatacombs.Models;
using TheCatacombs.UI;

namespace TheCatacombs.Services
{

    public class ExplorationManager
    {
        public void StartExploration(Player player)
        {
            ConsoleUI.DisplayMessage("Você acorda em uma sala escura e úmida.");
            ConsoleUI.DisplayMessage("Você está em uma sala escura e úmida.");
            ConsoleUI.DisplayMessage("Você vê uma porta à sua frente.");
            ConsoleUI.DisplayMessage("O que você faz?");
            ConsoleUI.DisplayMessage("1 - Abre a porta");
            ConsoleUI.DisplayMessage("2 - Explora a sala");
            ConsoleUI.DisplayMessage("3 - Exibe informações do personagem");
            ConsoleUI.DisplayMessage("4 - Exibe informações da arma");

            string input = ConsoleUI.GetUserInput();

            switch (input)
            {
                case "1":
                    break;
                case "2":
                    PerformExplorationRound(player);
                    break;
                case "3":
                    CharacterManager.DisplayCharacterInfo(player);
                    break;
                case "4":
                    break;
                case "0":
                    EndExploration();
                    break;
                default:
                    ConsoleUI.DisplayMessage("Opção inválida!");
                    break;
            }

        }

        private static void PerformExplorationRound(Player player)
        {
            ConsoleUI.DisplayMessage("Você explora a sala...");
            ConsoleUI.DisplayMessage("Você encontra um monstro! e ele te ataca!");

            CombatManager combatManager = new();

            combatManager.StartCombat(player);



        }

        private static void EndExploration()
        {
            // Implementação para o fim da exploração...
        }
    }

}