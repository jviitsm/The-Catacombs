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
            bool continueMoving = true;

            while (continueMoving)
            {
                int currentX = player.CurrentRoom.X;
                int currentY = player.CurrentRoom.Y;

                Console.Clear();
                ConsoleUI.DisplayMessage("--------------------");
                player.CurrentRoom.DrawRoom();
                ConsoleUI.DisplayMessage("--------------------");
                ConsoleUI.DisplayMessage("Escolha a direção para se mover:");
                ConsoleUI.DisplayMessage("W - Cima");
                ConsoleUI.DisplayMessage("S - Baixo");
                ConsoleUI.DisplayMessage("A - Esquerda");
                ConsoleUI.DisplayMessage("D - Direita");
                ConsoleUI.DisplayMessage("1 - Sair da movimentação");
                string direction = ConsoleUI.GetUserInput();


                switch (direction.ToLower())
                {
                    case "w":
                        continueMoving = MoveTo(currentX, currentY + 1);
                        break;
                    case "s":
                        continueMoving = MoveTo(currentX, currentY - 1);
                        break;
                    case "d":
                        continueMoving = MoveTo(currentX + 1, currentY);
                        break;
                    case "a":
                        continueMoving = MoveTo(currentX - 1, currentY);
                        break;
                    case "1":
                        continueMoving = false;
                        gameManager.GetExplorationManager().StartExploration();
                        break;
                    default:
                        ConsoleUI.DisplayMessage("Direção inválida.");
                        continueMoving = true;
                        break;
                }
            }
        }

        private bool MoveTo(int targetX, int targetY)
        {
            if (IsValidPosition(targetX, targetY, player.CurrentRoom.Width, player.CurrentRoom.Height))
            {
                if (HasMonsterAtPosition(targetX, targetY))
                {
                    ConsoleUI.DisplayMessage("Você encontrou um monstro! Combate iniciado.");
                    player.CurrentRoom.SetNewPosition(targetX, targetY);
                    player.CurrentRoom.setLastMonsterID(player.CurrentRoom.MonstersPositions.Find(monster => monster.X == targetX && monster.Y == targetY).ID);
                    gameManager.StartCombat();
                    return false;
                }
                else
                {
                    player.CurrentRoom.SetNewPosition(targetX, targetY);
                    ConsoleUI.DisplayMessage("Você se moveu para a posição: " + targetX + "," + targetY);
                    ConsoleUI.DisplayMessage("--------------------");
                    return true;
                }
            }
            else
            {
                ConsoleUI.DisplayMessage("Você não pode se mover nessa direção.");
                return false;
            }
        }

        private bool HasMonsterAtPosition(int x, int y)
        {
            return player.CurrentRoom.MonstersPositions.Any(monster => monster.X == x && monster.Y == y && !monster.IsDefeated);
        }

        private bool IsValidPosition(int x, int y, int maxX, int maxY)
        {
            return x >= 0 && x < maxX && y >= 0 && y < maxY;
        }


    }
}
