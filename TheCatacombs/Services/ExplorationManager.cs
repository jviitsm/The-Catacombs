// ExplorationManager.cs
using TheCatacombs.Entities;
using TheCatacombs.UI;

namespace TheCatacombs.Services
{
    public class ExplorationManager
    {
        private GameManager gameManager;
        private CharacterManager characterManager;
        private RoomManager roomManager;
        private Room currentRoom;

        public ExplorationManager(GameManager gameManager)  // Adicione o GameManager como parâmetro
        {
            this.gameManager = gameManager;
            this.characterManager = gameManager.GetCharacterManager();
            this.roomManager = new RoomManager();
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
                    gameManager.GetMovementManager().Move();
                    break;
                case "3":
                    characterManager.DisplayCharacterInfo();
                    StartExploration();
                    break;
                case "4":
                    characterManager.DisplayWeaponInfo();
                    StartExploration();
                    break;
                case "0":
                    gameManager.StartCombat();
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
            GenerateRandomRoom();
            StartExploration();
        }

        private void GenerateRandomRoom()
        {
            currentRoom = roomManager.GetRandomRoom();
            gameManager.GetPlayer().SetCurrentRoom(currentRoom);
            ConsoleUI.DisplayMessage(currentRoom.Description);
        }

        private string DisplayExplorationOptions()
        {
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
