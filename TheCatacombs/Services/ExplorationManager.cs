// ExplorationManager.cs
using TheCatacombs.Models;
using TheCatacombs.UI;

namespace TheCatacombs.Services
{
    public class ExplorationManager
    {
        private GameManager gameManager;
        private CharacterManager characterManager;

        public ExplorationManager(GameManager gameManager)  // Adicione o GameManager como parâmetro
        {
            this.gameManager = gameManager;
            this.characterManager = gameManager.GetCharacterManager();
        }

        public void StartExploration()
        {
            var input = DisplayExplorationOptions();

            switch (input)
            {
                case "1":
                    OpenDoor();
                    break;
                case "2":
                    gameManager.StartCombat();
                    break;
                case "3":
                    characterManager.DisplayCharacterInfo();
                    StartExploration();
                    break;
                case "0":
                    EndExploration();
                    break;
                default:
                    ConsoleUI.DisplayMessage("Opção inválida!");
                    StartExploration();
                    break;
            }

        }

        private void OpenDoor()
        {
            ConsoleUI.DisplayMessage("Você abriu a porta.");
            ConsoleUI.DisplayMessage("Voce se depara com uma princesa");
            ConsoleUI.DisplayMessage("A princesa diz: 'Obrigada por me salvar!'");
            ConsoleUI.DisplayMessage("Mas eu não sou uma princesa de verdade, eu sou uma bruxa!");

            gameManager.StartCombat(false);


        }

        private string DisplayExplorationOptions()
        {
            ConsoleUI.DisplayMessage("Você está em uma sala escura e úmida.");
            ConsoleUI.DisplayMessage("Você vê uma porta à sua frente.");
            ConsoleUI.DisplayMessage("O que você faz?");
            ConsoleUI.DisplayMessage("1 - Abre a porta");
            ConsoleUI.DisplayMessage("2 - Explora a sala");
            ConsoleUI.DisplayMessage("3 - Exibe informações do personagem");
            ConsoleUI.DisplayMessage("4 - Exibe informações da arma");

            string input = ConsoleUI.GetUserInput();

            return input;
        }

        private void EndExploration()
        {
            // Implementação para o fim da exploração...
        }
    }
}
