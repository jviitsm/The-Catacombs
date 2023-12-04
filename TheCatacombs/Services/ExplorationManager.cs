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
            ConsoleUI.DisplayMessage($"x{gameManager.GetPlayer().CurrentRoom.X}, y{gameManager.GetPlayer().CurrentRoom.Y}");
            var input = DisplayExplorationOptions();

            switch (input)
            {

                case "1":
                    gameManager.StartMoving();
                    break;
                case "2":
                    characterManager.DisplayCharacterInfo();
                    gameManager.StartExploration();
                    break;
                case "3":
                    characterManager.DisplayWeaponInfo();
                    gameManager.StartExploration();
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

        public void EnterNewRoom()
        {
            ConsoleUI.DisplayMessage("Você abriu a porta.");
            GenerateRandomRoom();
            gameManager.StartExploration();
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
            ConsoleUI.DisplayMessage("1 - Explora a sala");
            ConsoleUI.DisplayMessage("2 - Exibe informações do personagem");
            ConsoleUI.DisplayMessage("3 - Exibe informações da arma");

            string input = ConsoleUI.GetUserInput();

            return input;
        }

        private void EndExploration()
        {
            // Implementação para o fim da exploração...
        }
    }
}
