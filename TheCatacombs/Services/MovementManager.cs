using TheCatacombs.Entities;
using TheCatacombs.UI;

namespace TheCatacombs.Services
{
    public class MovementManager
    {
        private Player player;
        private GameManager gameManager;

        public MovementManager(GameManager gameManager)
        {
            this.gameManager = gameManager;
            this.player = gameManager.GetPlayer();
        }

        public void Move()
        {
            ConsoleUI.DisplayMessage("Escolha a direção para se mover (n/s/e/w):");
            ConsoleUI.DisplayMessage("1 - Sair da movimentação");
            string direction = ConsoleUI.GetUserInput();

            int currentX = player.CurrentRoom.X;
            int currentY = player.CurrentRoom.Y;

            switch (direction.ToLower())
            {
                case "n":
                    MoveTo(currentX, currentY - 1);
                    break;
                case "s":
                    MoveTo(currentX, currentY + 1);
                    break;
                case "e":
                    MoveTo(currentX + 1, currentY);
                    break;
                case "w":
                    MoveTo(currentX - 1, currentY);
                    break;
                case "1":
                    gameManager.GetExplorationManager().StartExploration();
                    break;

                default:
                    ConsoleUI.DisplayMessage("Direção inválida.");
                    break;
            }
        }

        private void MoveTo(int targetX, int targetY)
        {
            Room targetRoom = GetRoomAt(targetX, targetY);

            if (targetRoom != null)
            {
                player.CurrentRoom = targetRoom;
                DisplayPlayerPosition();
                ConsoleUI.DisplayMessage("--------------------");
                ConsoleUI.DisplayMessage("--------------------");
                Move();
            }
            else
            {
                ConsoleUI.DisplayMessage("Você não pode se mover nessa direção.");
            }
        }

        private Room GetRoomAt(int x, int y)
        {
            // Aqui você pode adicionar lógica personalizada para verificar se a posição é válida
            // com base no tamanho da sala e na posição atual do jogador.
            // Por exemplo, você pode verificar se a posição está dentro de certos limites.

            // Este exemplo apenas retorna sempre uma nova sala, independentemente da posição.
            return new Room($"Você está na sala: ({x}, {y})");
        }

        private void DisplayPlayerPosition()
        {
            ConsoleUI.DisplayMessage($"Você está agora na sala: {player.CurrentRoom.Description}");
        }
    }
}
